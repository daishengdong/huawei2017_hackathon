using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;



namespace Work
{

    public partial class SSCOM : Form
    {
        const byte EnterMouseMode=0x01;
        const byte LeaveMouseMode=0x02;
        const byte MouseLeftButton =0x03;
        const byte MouseRightButton =0x04;
        const byte EnterPaintButton =0x05; //进入画笔模式
        const byte LeavePaintButton= 0x06;	//退出画笔模式
        const byte ErasePaintButton= 0x07;	//擦除
        const byte EnterFullScreen= 0x08;	//全屏
        const byte ExitFillScreen= 0x09;		//退出全屏
        const byte PageUpButton=0x0A;			//上翻页
        const byte PageDownButton=0x0B;		//下翻页
        const byte ModeSwitchButton=0x0C;

        private SerialPort comm = new SerialPort();
        private long received_count = 0;
        private long send_count = 0;
        private StringBuilder builder = new StringBuilder();
        StreamReader sreader;

        public  PackFormat PF;
        public SSCOM()
        {
            InitializeComponent();
        }

        private void SSCOM_Load(object sender, EventArgs e)
        {
            PF = new PackFormat();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboBox_ComPort.Items.AddRange(ports);
            comboBox_ComPort.SelectedIndex = comboBox_ComPort.Items.Count > 0 ? 0 : -1;
            comm.NewLine = "\r\n";
            comm.DataReceived += comm_DataReceived;//事件触发
            chart1.ChartAreas[0].AxisY.Maximum = 20000;
            chart1.ChartAreas[0].AxisY.Minimum = -20000;
            chart1.Series["Series_pitch"].Color = Color.Black;
            chart1.Series["Series_roll"].Color = Color.Red;
            chart1.Series["Series_yaw"].Color = Color.Blue;
            //
            chart2.ChartAreas[0].AxisY.Maximum = 500;
            chart2.ChartAreas[0].AxisY.Minimum = -500;
            chart2.Series["Series_x"].Color = Color.Red;
            chart2.Series["Series_y"].Color = Color.Black;
            PF.SS = (byte)'s';
            PF.SB = 0;
            PF.TB = 0;
            for(int i=0;i<PF.Reserve.Length;i++)
            {
                PF.Reserve[i] = 0xA5;
            }
            PF.Sum = 0xff;
            timer.Interval = 50;
            
        }
        
        public float floatConversion(byte[] bytes)
        {
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes); // Convert big endian to little endian
            }
            float myFloat = BitConverter.ToSingle(bytes, 0);
            return myFloat;
        }
        int Aix = 0;
        /**********************调试mpu6050姿态角
        void comm_DataReceived(object sender,SerialDataReceivedEventArgs e) {
            int n = comm.BytesToRead;
            int pitch_int=0,roll_int=0,yaw_int=0;
            double pitch = 0, roll = 0,yaw=0;
            if (n >= 14) { 
                Byte[] buf=new Byte[n];
                comm.Read(buf, 0, n);
                if (buf[0] == 'A' && buf[13] == 'B') {
                    pitch_int = (int)(buf[4] << 24 | buf[3] << 16 | buf[2] << 8 | buf[1]);
                    roll_int = (int)(buf[8] << 24 | buf[7] << 16 | buf[6] << 8 | buf[5]);
                    yaw_int = (int)(buf[12] << 24 | buf[11] << 16 | buf[10] << 8 | buf[9]);
                    pitch = pitch_int / 100;
                    roll = roll_int / 100;
                    yaw = yaw_int / 100;
                    this.Invoke((EventHandler)(delegate
                    {
                        if (tabControl_UC.SelectedTab == tabPage_SiZhou)
                        {
                            if (Aix > 100)
                            {
                                chart1.Series["Series_pitch"].Points.RemoveAt(0);
                                chart1.Series["Series_roll"].Points.RemoveAt(0);
                                chart1.Series["Series_yaw"].Points.RemoveAt(0);
                            }
                            chart1.Series["Series_pitch"].Points.AddY(pitch_int);
                            chart1.Series["Series_roll"].Points.AddY(roll_int);
                            chart1.Series["Series_yaw"].Points.AddY(yaw_int);
                            label_S_Pitch.Text = pitch.ToString();
                            label_S_roll.Text = roll.ToString();
                            label_S_yaw.Text = yaw.ToString();
                            Aix++;
                        }

                    }));

                    Console.WriteLine("pitch:" + pitch.ToString());
                    Console.WriteLine("roll:" + roll.ToString());
                    Console.WriteLine("yaw:" + yaw.ToString());
                    Console.WriteLine("Aix:" + Aix.ToString());
                }
            }

        }
         * */
        //数据接受
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = comm.BytesToRead;
            /* 
            if (EnterRevMode) {
                if (n >= 10) { 
                    byte[] buf1 = new byte[n];
                    comm.Read(buf1, 0, n);
                    if (buf1[0] == 'S'&&buf1[9]=='E') {
                        short x=0, y=0;
                        x = (short)(buf1[3] << 8|buf1[2]);
                        y=(short)(buf1[5]<<8|buf1[4]);
                        Console.WriteLine("x:" + x.ToString() + "\ny:" + y.ToString());
                        this.Invoke((EventHandler)(delegate
                        {
                            if (tabControl_UC.SelectedTab == tabPage_24L01Rev)
                            {
                                if (Aix > 100)
                                {
                                    chart2.Series["Series_x"].Points.RemoveAt(0);
                                    chart2.Series["Series_y"].Points.RemoveAt(0);
                                }
                                chart2.Series["Series_x"].Points.AddY(x);
                                chart2.Series["Series_y"].Points.AddY(y);
                                label_X.Text = x.ToString();
                                label_Y.Text = y.ToString();
                                Aix++;
                            }
                         }));   
                        }
                    }else{
                        return;
                    }
                }
                return;
                */
            byte[] buf = new byte[n];
            received_count += n;
            comm.Read(buf, 0, n);
            builder.Clear();
            this.Invoke((EventHandler)(delegate
            {

                if (checkBox_IsHex.Checked)
                {
                    foreach (byte b in buf)
                    {
                        builder.Append(b.ToString("X2") + " ");
                    }
                }
                else
                {
                    
                    builder.Append(Encoding.ASCII.GetString(buf));
                }

                //显示
                if (tabControl_UC.SelectedTab ==tabPage_24L01Send)
                {
                    richTextBox_Send.AppendText("\n收到："+builder.ToString());
                }
                else if (tabControl_UC.SelectedTab==tabPage_24L01Rev)
                {
                    richTextBox_Rev.AppendText("\n收到："+builder.ToString());
                }
                this.richTextBox_RevWindow.AppendText(builder.ToString());
                
                toolStripStatusLabel_接收的数据量.Text = "收到的数据量：" + received_count.ToString();
            }));
       
        }
        /*------------------------------------------------------------------------------------------------*/
        //以下是串口调试工具部分
        private void button_打开关闭串口_Click(object sender, EventArgs e)
        {
            if (comm.IsOpen)
            {
                comm.Close();
                toolStripStatusLabel_其他串口信息.Text = "COM:已关闭         ";
            }
            else
            {
                comm.PortName = comboBox_ComPort.Text;
                comm.BaudRate = baudRate_Transfer(comboBox_波特率.Text);
                comm.DataBits = int.Parse(comboBox_数据位.Text);
                comm.StopBits = stopBits_Tranfer(comboBox_停止位.Text);
                comm.DtrEnable = checkBox_DTR.Checked;
                comm.RtsEnable = checkBox_RTS.Checked;
                toolStripStatusLabel_其他串口信息.Text = "COM:" + comboBox_ComPort.Text + "  " + comboBox_波特率.Text
                    + " " + comboBox_数据位.Text + " " + comboBox_停止位.Text + " " + comboBox_校验位.Text;
                try
                {
                    comm.Open();
                }
                catch (Exception ex)
                {
                    comm = new SerialPort();
                    MessageBox.Show(ex.Message);
                }
            }
            button_OpenSerial.Text = comm.IsOpen ? "关闭串口" : "打开串口";
            button_Send.Enabled = button_SendFile.Enabled = comm.IsOpen;
            comboBox_波特率.Enabled = comboBox_ComPort.Enabled = comboBox_数据位.Enabled = comboBox_停止位.Enabled
                = comboBox_校验位.Enabled = comboBox_流控制.Enabled = !comm.IsOpen;
            radioButton_打开串口.Checked = comm.IsOpen;

        }


        private int baudRate_Transfer(string s)
        {
            switch (s)
            {
                case "1200bps":
                    return 1200;
                case "2400bps":
                    return 2400;
                case "4800bps":
                    return 4800;
                case "9600bps":
                    return 9600;
                case "19200bps":
                    return 19200;
                case "38400bps":
                    return 38400;
                case "57600bps":
                    return 57600;
                case "115200bps":
                    return 115200;
                default: return -1;
            }
        }
        private StopBits stopBits_Tranfer(string s)
        {
            switch (s)
            {
                case "0": return StopBits.None;
                case "1": return StopBits.One;
                case "1.5": return StopBits.OnePointFive;
                case "2": return StopBits.Two;
                default: return StopBits.None;
            }

        }
        private Parity parityBit_Transfer(string s)
        {
            switch (s)
            {
                case "None": return Parity.None;
                case "Odd": return Parity.Odd;
                case "Even": return Parity.Even;
                case "Mark": return Parity.Mark;
                case "Space": return Parity.Space;
                default: return Parity.None;
            }
        }

        private void comboBox_波特率_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_串口波特率.Text = comboBox_波特率.Text;
        }

        private void comboBox_串口波特率_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_波特率.Text = comboBox_串口波特率.Text;
        }

        private void button_发送_Click(object sender, EventArgs e)
        {
            if (checkBox_定时发送.Checked == true)
            {
                timer_字符串定时发送.Interval = int.Parse(textBox_速率.Text);
                timer_字符串定时发送.Start();
            }
            else
            {
                int n = 0;
                byte[] data = Encoding.Default.GetBytes(textBox_发送窗口.Text);
                if (checkBox_Hex发送.Checked == true)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        byte temp = data[i];
                        string tempHex = temp.ToString("X2") + " ";
                        comm.Write(tempHex);
                        n++;
                    }
                }
                else
                {
                    comm.Write(data, 0, data.Length);
                    n = data.Length;
                }
                send_count += n;
                toolStripStatusLabel_发送的数据量.Text = "发送的数据量: " + send_count.ToString();
            }

        }

        private void button_清除窗口_Click(object sender, EventArgs e)
        {
            richTextBox_RevWindow.Clear();
            toolStripStatusLabel_接收的数据量.Text = "收到的数据量：0";
            received_count = 0;
        }

        private void button_保存窗口_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog_保存.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog_保存.FileName, true,
                    System.Text.Encoding.Default);
                writer.Write(richTextBox_RevWindow.Text);
                writer.Close();
                richTextBox_RevWindow.Modified = false;
            }

        }

        private void tabPage_串口调试工具_Click(object sender, EventArgs e)
        {

        }

        private void button_打开文件_Click(object sender, EventArgs e)
        {
            openFileDialog_打开文件.ShowDialog();
            textBox_文件地址.Text = openFileDialog_打开文件.FileName;
        }

        private void button_发送文件_Click(object sender, EventArgs e)
        {
            if (textBox_文件地址.Text != null)
            {
                sreader = new StreamReader(textBox_文件地址.Text);
                if (checkBox_定时发送.Checked == true)
                {
                    timer_文件定时发送.Interval = int.Parse(textBox_速率.Text);
                    timer_文件定时发送.Start();
                }
                else
                {
                    int n = 0;
                    string str = sreader.ReadLine();
                    while (str != null)
                    {
                        byte[] data = Encoding.Default.GetBytes(str);
                        comm.Write(data, 0, data.Length);
                        str = sreader.ReadLine();
                        n += data.Length;
                    }
                    send_count += n;
                    toolStripStatusLabel_发送的数据量.Text = "发送的数据量: " + send_count.ToString();
                    sreader.Close();
                }
            }
        }

        private void timer_文件定时发送_Tick(object sender, EventArgs e)
        {
            string str = sreader.ReadLine();
            if (str != null)
            {
                byte[] data = Encoding.Default.GetBytes(str);
                comm.Write(data, 0, data.Length);
                send_count += data.Length;
                toolStripStatusLabel_发送的数据量.Text = "发送的数据量: " + send_count.ToString();
            }
            else
            {
                sreader.Close();
                timer_文件定时发送.Stop();
            }
        }

        private void timer_字符串定时发送_Tick(object sender, EventArgs e)
        {
            int n = 0;
            byte[] data = Encoding.Default.GetBytes(textBox_发送窗口.Text);
            if (checkBox_Hex发送.Checked == true)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    byte temp = data[i];
                    string tempHex = temp.ToString("X2") + " ";
                    comm.Write(tempHex);
                    n++;
                }
            }
            else
            {

                comm.Write(data, 0, data.Length);
                n = data.Length;
            }
            send_count += n;
            toolStripStatusLabel_发送的数据量.Text = "发送的数据量: " + send_count.ToString();
            timer_字符串定时发送.Stop();
        }
        private bool EnterSendMode=false;
        //使24L01进入
        private void button_SendMode_Click(object sender, EventArgs e)
        {
            if (comm.IsOpen)
            {
                //模式选择
                byte[] tmp = new byte[10];
                tmp[0] = 0x00;
                comm.Write(tmp, 0, 1);
                richTextBox_Send.AppendText("\n发送：" + tmp[0].ToString());
                Thread.Sleep(100);
                //发送地址
                richTextBox_Send.AppendText("\n发送：");
                string hexString = textBox_SendAddr.Text;
                byte[] returnBytes = new byte[hexString.Length / 2];
                for (int i = 0; i < returnBytes.Length; i++)
                {
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    richTextBox_Send.AppendText(returnBytes[i].ToString("X2") + " ");
                    // Thread.Sleep(100);
                }
                comm.Write(returnBytes, 0, returnBytes.Length);
                Thread.Sleep(100);
                //接收地址
                richTextBox_Send.AppendText("\n发送：");
                hexString = textBox_RevAddress.Text;
                byte[] RevBytes = new byte[hexString.Length / 2];
                for (int i = 0; i < RevBytes.Length; i++)
                {
                    RevBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    richTextBox_Send.AppendText(RevBytes[i].ToString("X2") + " ");
                    // Thread.Sleep(100);
                }
                comm.Write(RevBytes, 0, RevBytes.Length);
                Thread.Sleep(100);
                //通道选择
                tmp[0] = 0x01;
                comm.Write(tmp, 0, 1);
                richTextBox_Send.AppendText("\n发送：" + tmp[0].ToString());

                EnterSendMode=true;
            }
            else {
                MessageBox.Show("please open com frist!!");
            }
        }

        private void button_MouseUp_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private bool FullPrint=false;
        private void button_FullPrint_Click(object sender, EventArgs e)
        {
            if (EnterSendMode)
            {

                if (FullPrint==false)
                {
                    PF.FB = 0x08;
                    comm.Write(PF.GetData(), 0, 10);
                    FullPrint = true;
                    button_FullPrint.BackColor = Color.Blue;
                }
                else
                {
                    PF.FB = 0x09;
                    comm.Write(PF.GetData(), 0, 10);
                    FullPrint = false;
                    button_FullPrint.BackColor = Color.White;
                }

            }
            else
            {
                MessageBox.Show("please Enter SendMode frist");
            }

        }
        //发送上翻页的命令
        private void button_PageUp_Click(object sender, EventArgs e)
        {
        //    byte[] Buffer=new byte[10];
        //    Buffer[0]=(byte)'s';
            if (EnterSendMode)
            {
                PF.FB = 0x0A;
                comm.Write(PF.GetData(), 0, 10);
            }
            else {
                MessageBox.Show("please Enter SendMode frist");
            }
        }
        private bool EnterRevMode=false;
        private void button_24L01RevMode_Click(object sender, EventArgs e)
        {
            if (comm.IsOpen)
            {
                //模式选择
                byte[] tmp = new byte[10];
                tmp[0] = 0x01;
                comm.Write(tmp,0,1);
                richTextBox_Rev.AppendText("\n发送："+tmp[0].ToString());
                Thread.Sleep(100);
                //接收地址
                richTextBox_Rev.AppendText("\n发送：");
                string hexString = textBox_RevAddress.Text;
                byte[] returnBytes = new byte[hexString.Length / 2];
                for (int i = 0; i < returnBytes.Length; i++){
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    richTextBox_Rev.AppendText(returnBytes[i].ToString("X2")+" ");
                   // Thread.Sleep(100);
                }
                comm.Write(returnBytes, 0, returnBytes.Length);
                Thread.Sleep(100);
                //通道选择
                tmp[0] = 0x01;
                comm.Write(tmp, 0, 1);
                richTextBox_Rev.AppendText("\n发送：" + tmp[0].ToString());
                
            }
            else {
                MessageBox.Show("open comm frist!!");
            }
        }
        private bool PrintMode=false;
        private void button_ButtonPaint_Click(object sender, EventArgs e)
        {
            if (EnterSendMode)
            {
                if (PrintMode == false)
                {
                    PF.FB = 0x05;
                    comm.Write(PF.GetData(), 0, 10);
                    PrintMode = true;
                    button_ButtonPaint.BackColor = Color.Red;
                }
                else {
                    PF.FB = 0x06;
                    comm.Write(PF.GetData(),0,10);
                    PrintMode = false;
                    button_ButtonPaint.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("please Enter SendMode frist");
            }
        }

        private void button_ButtonErase_Click(object sender, EventArgs e)
        {
            if (EnterSendMode)
            {
                PF.FB = 0x07;
                comm.Write(PF.GetData(), 0, 10);
            }
            else
            {
                MessageBox.Show("please Enter SendMode frist");
            }
        }

        private void button_PageDown_Click(object sender, EventArgs e)
        {
            if (EnterSendMode)
            {
                PF.FB = 0x0B;
                comm.Write(PF.GetData(), 0, 10);
            }
            else
            {
                MessageBox.Show("please Enter SendMode frist");
            }
        }


        private void button_MouseLeftKeyDown_Click(object sender, EventArgs e)
        {
            if (EnterSendMode)
            {
                PF.FB = 0x03;//MouseLeftButton
                comm.Write(PF.GetData(), 0, 10);
            }
            else
            {
                MessageBox.Show("please Enter SendMode frist");
            }
        }

        private void button_MouseRightKeyDown_Click(object sender, EventArgs e)
        {
            if (EnterSendMode)
            {
                PF.FB = 0x04;//MouseRightButton
                comm.Write(PF.GetData(), 0, 10);
            }
            else
            {
                MessageBox.Show("please Enter SendMode frist");
            }
        }

        private void button_MouseMidKeyDown_Click(object sender, EventArgs e)
        {

        }

        private bool MouseLeft = false, MouseRight = false, MouseUpFlag = false, MouseDownFlag = false;
        private void MouseLeftDown(object sender, MouseEventArgs e)
        {
            MouseLeft = true;
            timer.Start();
        }

        private void MouseRightDown(object sender, MouseEventArgs e)
        {
            MouseRight = true;
            timer.Start();
        }

        private void MouseUp_Down(object sender, MouseEventArgs e)
        {
            MouseUpFlag = true;
            timer.Start();
        }

        private void MouseDown_Down(object sender, MouseEventArgs e)
        {
            MouseDownFlag = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(MouseLeft)
            {
                if (EnterSendMode)
                {
                    PF.FB = 0x01;//MouseMove
                    PF.SB = -10;
                    PF.TB = 0;
                    comm.Write(PF.GetData(), 0, 10);
                    PF.SB = 0;
                    PF.TB = 0;
                }
            }
            if (MouseRight)
            {
                if (EnterSendMode)
                {
                    PF.FB = 0x01;//MouseMove
                    PF.SB = 10;
                    PF.TB = 0;
                    comm.Write(PF.GetData(), 0, 10);
                    PF.SB = 0;
                    PF.TB = 0;
                }
            }
            if (MouseUpFlag)
            {
                if (EnterSendMode)
                {
                    PF.FB = 0x01;//MouseMove
                    PF.SB = 0;
                    PF.TB = -10;
                    comm.Write(PF.GetData(), 0, 10);
                    PF.SB = 0;
                    PF.TB = 0;
                }
            }
            if (MouseDownFlag)
            {
                if (EnterSendMode)
                {
                    PF.FB = 0x01;//MouseMove
                    PF.SB = 0;
                    PF.TB = 10;
                    comm.Write(PF.GetData(), 0, 10);
                    PF.SB = 0;
                    PF.TB = 0;
                }
            }
        }

        private void MouseLeft_UP(object sender, MouseEventArgs e)
        {
            MouseLeft = false;
            timer.Stop();
        }

        private void MouseRight_Up(object sender, MouseEventArgs e)
        {
            MouseRight = false;
            timer.Stop();
        }

        private void MouseUP_UP(object sender, MouseEventArgs e)
        {
            MouseUpFlag = false;
            timer.Stop();
        }

        private void MouseDown_UP(object sender, MouseEventArgs e)
        {
            MouseDownFlag = false;
            timer.Stop();
        }

        private void button_RevStart_Click(object sender, EventArgs e)
        {
            EnterRevMode = true;
        }

    }
    /*------------------------------------------------------------------------------------------------*/
    //数据包格式
    public class PackFormat
    {
        public byte SS;
        public byte FB;
        public SByte SB;
        public sbyte TB;
        public byte[] Reserve = new byte[5];
        public Byte Sum;
        public Byte[] GetData()
        {

            byte[] Buf = new byte[10];
            //Buffer[0]=(byte)'s';
            Buf[0] = SS;
            Buf[1] = FB;
            Buf[2] = (byte)SB;
            Buf[3] = (byte)TB;
            {
                for (int i = 0; i < 5; i++)
                    Buf[4 + i] = Reserve[i];
            }
            Buf[9] = Sum;
            return Buf;
        }
    };
}

          
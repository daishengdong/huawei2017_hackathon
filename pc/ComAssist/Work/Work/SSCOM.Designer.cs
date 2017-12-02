namespace Work
{
    partial class SSCOM
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ComboBox comboBox_唤醒时间间隔;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl_UC = new System.Windows.Forms.TabControl();
            this.tabPage_ComDebug = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_发送的数据量 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_接收的数据量 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_其他串口信息 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_发送窗口 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Send = new System.Windows.Forms.Button();
            this.label_字符串 = new System.Windows.Forms.Label();
            this.checkBox_Hex发送 = new System.Windows.Forms.CheckBox();
            this.label_速度单位 = new System.Windows.Forms.Label();
            this.textBox_速率 = new System.Windows.Forms.TextBox();
            this.checkBox_定时发送 = new System.Windows.Forms.CheckBox();
            this.checkBox_RTS = new System.Windows.Forms.CheckBox();
            this.checkBox_DTR = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_流控制 = new System.Windows.Forms.ComboBox();
            this.comboBox_校验位 = new System.Windows.Forms.ComboBox();
            this.label_流控制 = new System.Windows.Forms.Label();
            this.label_校验位 = new System.Windows.Forms.Label();
            this.comboBox_停止位 = new System.Windows.Forms.ComboBox();
            this.label_停止位 = new System.Windows.Forms.Label();
            this.comboBox_数据位 = new System.Windows.Forms.ComboBox();
            this.comboBox_波特率 = new System.Windows.Forms.ComboBox();
            this.label_数据位 = new System.Windows.Forms.Label();
            this.label_波特率 = new System.Windows.Forms.Label();
            this.button_帮助 = new System.Windows.Forms.Button();
            this.radioButton_打开串口 = new System.Windows.Forms.RadioButton();
            this.button_OpenSerial = new System.Windows.Forms.Button();
            this.comboBox_ComPort = new System.Windows.Forms.ComboBox();
            this.label_串口号 = new System.Windows.Forms.Label();
            this.checkBox_IsHex = new System.Windows.Forms.CheckBox();
            this.button_ClearWindow = new System.Windows.Forms.Button();
            this.button_SaveWindow = new System.Windows.Forms.Button();
            this.button_SendFile = new System.Windows.Forms.Button();
            this.textBox_文件地址 = new System.Windows.Forms.TextBox();
            this.button_OPENFILE = new System.Windows.Forms.Button();
            this.richTextBox_RevWindow = new System.Windows.Forms.RichTextBox();
            this.tabPage_串口配置工具 = new System.Windows.Forms.TabPage();
            this.groupBox_param = new System.Windows.Forms.GroupBox();
            this.button_RevMode = new System.Windows.Forms.Button();
            this.checkBox_包完整模式 = new System.Windows.Forms.CheckBox();
            this.panel_包长设定 = new System.Windows.Forms.Panel();
            this.radioButton_包长设定_64 = new System.Windows.Forms.RadioButton();
            this.radioButton_包长设定_32 = new System.Windows.Forms.RadioButton();
            this.radioButton_包长设定_16 = new System.Windows.Forms.RadioButton();
            this.radioButton_包长设定_8 = new System.Windows.Forms.RadioButton();
            this.radioButton_包长设定_4 = new System.Windows.Forms.RadioButton();
            this.radioButton_包长设定_2 = new System.Windows.Forms.RadioButton();
            this.textBox_SendAddr = new System.Windows.Forms.TextBox();
            this.textBox_RevAddress = new System.Windows.Forms.TextBox();
            this.checkBox_纠错编码使能 = new System.Windows.Forms.CheckBox();
            this.label_射频发射功率单位 = new System.Windows.Forms.Label();
            this.textBox_延时触发间隔 = new System.Windows.Forms.TextBox();
            this.comboBox_串口奇偶校验 = new System.Windows.Forms.ComboBox();
            this.comboBox_串口波特率 = new System.Windows.Forms.ComboBox();
            this.comboBox_射频发射功率 = new System.Windows.Forms.ComboBox();
            this.comboBox_射频空中速率 = new System.Windows.Forms.ComboBox();
            this.label_包完整模式 = new System.Windows.Forms.Label();
            this.label_包长设定 = new System.Windows.Forms.Label();
            this.label_目标地址 = new System.Windows.Forms.Label();
            this.label_本机地址 = new System.Windows.Forms.Label();
            this.label_纠错编码使能 = new System.Windows.Forms.Label();
            this.label_延时触发间隔 = new System.Windows.Forms.Label();
            this.label_唤醒时间间隔 = new System.Windows.Forms.Label();
            this.label_串口奇偶校验 = new System.Windows.Forms.Label();
            this.label_串口波特率 = new System.Windows.Forms.Label();
            this.label_射频发射功率 = new System.Windows.Forms.Label();
            this.label_射频空中速率 = new System.Windows.Forms.Label();
            this.label_射频工作频率单位 = new System.Windows.Forms.Label();
            this.textBox_射频工作频率 = new System.Windows.Forms.TextBox();
            this.label_射频工作频率 = new System.Windows.Forms.Label();
            this.tabPage_24L01Send = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SendMode = new System.Windows.Forms.Button();
            this.richTextBox_Send = new System.Windows.Forms.RichTextBox();
            this.button_MouseDown = new System.Windows.Forms.Button();
            this.button_MouseRight = new System.Windows.Forms.Button();
            this.button_MouseRightKeyDown = new System.Windows.Forms.Button();
            this.button_MouseMidKeyDown = new System.Windows.Forms.Button();
            this.button_PageDown = new System.Windows.Forms.Button();
            this.button_PageUp = new System.Windows.Forms.Button();
            this.button_ButtonErase = new System.Windows.Forms.Button();
            this.button_ButtonPaint = new System.Windows.Forms.Button();
            this.button_FullPrint = new System.Windows.Forms.Button();
            this.button_MouseLeftKeyDown = new System.Windows.Forms.Button();
            this.button_MouseLeft = new System.Windows.Forms.Button();
            this.button_MouseUp = new System.Windows.Forms.Button();
            this.tabPage_24L01Rev = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_RevStart = new System.Windows.Forms.Button();
            this.button_RevMouseRight = new System.Windows.Forms.Button();
            this.button_RevMouseMode = new System.Windows.Forms.Button();
            this.button_RevPageDown = new System.Windows.Forms.Button();
            this.button_RevPageUp = new System.Windows.Forms.Button();
            this.button_Erase = new System.Windows.Forms.Button();
            this.button_Paint = new System.Windows.Forms.Button();
            this.button_RevFullPrint = new System.Windows.Forms.Button();
            this.button_RevLeft = new System.Windows.Forms.Button();
            this.button_24L01RevMode = new System.Windows.Forms.Button();
            this.richTextBox_Rev = new System.Windows.Forms.RichTextBox();
            this.tabPage_SiZhou = new System.Windows.Forms.TabPage();
            this.label_S_roll = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_S_yaw = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_S_Pitch = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.saveFileDialog_保存 = new System.Windows.Forms.SaveFileDialog();
            this.timer_文件定时发送 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog_打开文件 = new System.Windows.Forms.OpenFileDialog();
            this.timer_字符串定时发送 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            comboBox_唤醒时间间隔 = new System.Windows.Forms.ComboBox();
            this.tabControl_UC.SuspendLayout();
            this.tabPage_ComDebug.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_串口配置工具.SuspendLayout();
            this.groupBox_param.SuspendLayout();
            this.panel_包长设定.SuspendLayout();
            this.tabPage_24L01Send.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_24L01Rev.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage_SiZhou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_唤醒时间间隔
            // 
            comboBox_唤醒时间间隔.FormattingEnabled = true;
            comboBox_唤醒时间间隔.Items.AddRange(new object[] {
            "50ms",
            "100ms",
            "200ms",
            "400ms",
            "600ms",
            "1s",
            "1.5s",
            "2s",
            "2.5s",
            "3s",
            "4s",
            "5s"});
            comboBox_唤醒时间间隔.Location = new System.Drawing.Point(104, 153);
            comboBox_唤醒时间间隔.Name = "comboBox_唤醒时间间隔";
            comboBox_唤醒时间间隔.Size = new System.Drawing.Size(100, 20);
            comboBox_唤醒时间间隔.TabIndex = 20;
            comboBox_唤醒时间间隔.Text = "1s";
            // 
            // tabControl_UC
            // 
            this.tabControl_UC.Controls.Add(this.tabPage_ComDebug);
            this.tabControl_UC.Controls.Add(this.tabPage_串口配置工具);
            this.tabControl_UC.Controls.Add(this.tabPage_24L01Send);
            this.tabControl_UC.Controls.Add(this.tabPage_24L01Rev);
            this.tabControl_UC.Controls.Add(this.tabPage_SiZhou);
            this.tabControl_UC.Location = new System.Drawing.Point(0, 4);
            this.tabControl_UC.Name = "tabControl_UC";
            this.tabControl_UC.SelectedIndex = 0;
            this.tabControl_UC.Size = new System.Drawing.Size(663, 470);
            this.tabControl_UC.TabIndex = 0;
            // 
            // tabPage_ComDebug
            // 
            this.tabPage_ComDebug.AllowDrop = true;
            this.tabPage_ComDebug.BackColor = System.Drawing.Color.Yellow;
            this.tabPage_ComDebug.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_ComDebug.CausesValidation = false;
            this.tabPage_ComDebug.Controls.Add(this.statusStrip1);
            this.tabPage_ComDebug.Controls.Add(this.textBox_发送窗口);
            this.tabPage_ComDebug.Controls.Add(this.panel2);
            this.tabPage_ComDebug.Controls.Add(this.panel1);
            this.tabPage_ComDebug.Controls.Add(this.button_帮助);
            this.tabPage_ComDebug.Controls.Add(this.radioButton_打开串口);
            this.tabPage_ComDebug.Controls.Add(this.button_OpenSerial);
            this.tabPage_ComDebug.Controls.Add(this.comboBox_ComPort);
            this.tabPage_ComDebug.Controls.Add(this.label_串口号);
            this.tabPage_ComDebug.Controls.Add(this.checkBox_IsHex);
            this.tabPage_ComDebug.Controls.Add(this.button_ClearWindow);
            this.tabPage_ComDebug.Controls.Add(this.button_SaveWindow);
            this.tabPage_ComDebug.Controls.Add(this.button_SendFile);
            this.tabPage_ComDebug.Controls.Add(this.textBox_文件地址);
            this.tabPage_ComDebug.Controls.Add(this.button_OPENFILE);
            this.tabPage_ComDebug.Controls.Add(this.richTextBox_RevWindow);
            this.tabPage_ComDebug.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage_ComDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ComDebug.Name = "tabPage_ComDebug";
            this.tabPage_ComDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ComDebug.Size = new System.Drawing.Size(655, 444);
            this.tabPage_ComDebug.TabIndex = 0;
            this.tabPage_ComDebug.Text = "串口调试工具";
            this.tabPage_ComDebug.Click += new System.EventHandler(this.tabPage_串口调试工具_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_发送的数据量,
            this.toolStripStatusLabel_接收的数据量,
            this.toolStripStatusLabel_其他串口信息});
            this.statusStrip1.Location = new System.Drawing.Point(3, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(645, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_发送的数据量
            // 
            this.toolStripStatusLabel_发送的数据量.Name = "toolStripStatusLabel_发送的数据量";
            this.toolStripStatusLabel_发送的数据量.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabel_发送的数据量.Text = "发送的数据量：0";
            // 
            // toolStripStatusLabel_接收的数据量
            // 
            this.toolStripStatusLabel_接收的数据量.Name = "toolStripStatusLabel_接收的数据量";
            this.toolStripStatusLabel_接收的数据量.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabel_接收的数据量.Text = "接收的数据量：0";
            // 
            // toolStripStatusLabel_其他串口信息
            // 
            this.toolStripStatusLabel_其他串口信息.Name = "toolStripStatusLabel_其他串口信息";
            this.toolStripStatusLabel_其他串口信息.Size = new System.Drawing.Size(170, 17);
            this.toolStripStatusLabel_其他串口信息.Text = "COM：已关闭 9600bps  8 1 ";
            // 
            // textBox_发送窗口
            // 
            this.textBox_发送窗口.Location = new System.Drawing.Point(144, 393);
            this.textBox_发送窗口.Name = "textBox_发送窗口";
            this.textBox_发送窗口.Size = new System.Drawing.Size(506, 21);
            this.textBox_发送窗口.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Send);
            this.panel2.Controls.Add(this.label_字符串);
            this.panel2.Controls.Add(this.checkBox_Hex发送);
            this.panel2.Controls.Add(this.label_速度单位);
            this.panel2.Controls.Add(this.textBox_速率);
            this.panel2.Controls.Add(this.checkBox_定时发送);
            this.panel2.Controls.Add(this.checkBox_RTS);
            this.panel2.Controls.Add(this.checkBox_DTR);
            this.panel2.Location = new System.Drawing.Point(147, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 90);
            this.panel2.TabIndex = 13;
            // 
            // button_Send
            // 
            this.button_Send.Enabled = false;
            this.button_Send.Location = new System.Drawing.Point(89, 65);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(79, 22);
            this.button_Send.TabIndex = 14;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_发送_Click);
            // 
            // label_字符串
            // 
            this.label_字符串.AutoSize = true;
            this.label_字符串.Location = new System.Drawing.Point(3, 72);
            this.label_字符串.Name = "label_字符串";
            this.label_字符串.Size = new System.Drawing.Size(89, 12);
            this.label_字符串.TabIndex = 15;
            this.label_字符串.Text = "字符串输入框：";
            // 
            // checkBox_Hex发送
            // 
            this.checkBox_Hex发送.AutoSize = true;
            this.checkBox_Hex发送.Location = new System.Drawing.Point(3, 50);
            this.checkBox_Hex发送.Name = "checkBox_Hex发送";
            this.checkBox_Hex发送.Size = new System.Drawing.Size(66, 16);
            this.checkBox_Hex发送.TabIndex = 14;
            this.checkBox_Hex发送.Text = "Hex发送";
            this.checkBox_Hex发送.UseVisualStyleBackColor = true;
            // 
            // label_速度单位
            // 
            this.label_速度单位.AutoSize = true;
            this.label_速度单位.Location = new System.Drawing.Point(133, 31);
            this.label_速度单位.Name = "label_速度单位";
            this.label_速度单位.Size = new System.Drawing.Size(35, 12);
            this.label_速度单位.TabIndex = 4;
            this.label_速度单位.Text = "ms/次";
            // 
            // textBox_速率
            // 
            this.textBox_速率.Location = new System.Drawing.Point(81, 26);
            this.textBox_速率.Name = "textBox_速率";
            this.textBox_速率.Size = new System.Drawing.Size(46, 21);
            this.textBox_速率.TabIndex = 3;
            this.textBox_速率.Text = "200";
            // 
            // checkBox_定时发送
            // 
            this.checkBox_定时发送.AutoSize = true;
            this.checkBox_定时发送.Location = new System.Drawing.Point(3, 28);
            this.checkBox_定时发送.Name = "checkBox_定时发送";
            this.checkBox_定时发送.Size = new System.Drawing.Size(72, 16);
            this.checkBox_定时发送.TabIndex = 2;
            this.checkBox_定时发送.Text = "定时发送";
            this.checkBox_定时发送.UseVisualStyleBackColor = true;
            // 
            // checkBox_RTS
            // 
            this.checkBox_RTS.AutoSize = true;
            this.checkBox_RTS.Location = new System.Drawing.Point(81, 7);
            this.checkBox_RTS.Name = "checkBox_RTS";
            this.checkBox_RTS.Size = new System.Drawing.Size(42, 16);
            this.checkBox_RTS.TabIndex = 1;
            this.checkBox_RTS.Text = "RTS";
            this.checkBox_RTS.UseVisualStyleBackColor = true;
            // 
            // checkBox_DTR
            // 
            this.checkBox_DTR.AutoSize = true;
            this.checkBox_DTR.Location = new System.Drawing.Point(3, 7);
            this.checkBox_DTR.Name = "checkBox_DTR";
            this.checkBox_DTR.Size = new System.Drawing.Size(42, 16);
            this.checkBox_DTR.TabIndex = 0;
            this.checkBox_DTR.Text = "DTR";
            this.checkBox_DTR.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_流控制);
            this.panel1.Controls.Add(this.comboBox_校验位);
            this.panel1.Controls.Add(this.label_流控制);
            this.panel1.Controls.Add(this.label_校验位);
            this.panel1.Controls.Add(this.comboBox_停止位);
            this.panel1.Controls.Add(this.label_停止位);
            this.panel1.Controls.Add(this.comboBox_数据位);
            this.panel1.Controls.Add(this.comboBox_波特率);
            this.panel1.Controls.Add(this.label_数据位);
            this.panel1.Controls.Add(this.label_波特率);
            this.panel1.Location = new System.Drawing.Point(6, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 117);
            this.panel1.TabIndex = 12;
            // 
            // comboBox_流控制
            // 
            this.comboBox_流控制.FormattingEnabled = true;
            this.comboBox_流控制.Location = new System.Drawing.Point(50, 94);
            this.comboBox_流控制.Name = "comboBox_流控制";
            this.comboBox_流控制.Size = new System.Drawing.Size(82, 20);
            this.comboBox_流控制.TabIndex = 14;
            this.comboBox_流控制.Text = "None";
            // 
            // comboBox_校验位
            // 
            this.comboBox_校验位.FormattingEnabled = true;
            this.comboBox_校验位.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBox_校验位.Location = new System.Drawing.Point(50, 73);
            this.comboBox_校验位.Name = "comboBox_校验位";
            this.comboBox_校验位.Size = new System.Drawing.Size(82, 20);
            this.comboBox_校验位.TabIndex = 18;
            this.comboBox_校验位.Text = "None";
            // 
            // label_流控制
            // 
            this.label_流控制.AutoSize = true;
            this.label_流控制.Location = new System.Drawing.Point(3, 99);
            this.label_流控制.Name = "label_流控制";
            this.label_流控制.Size = new System.Drawing.Size(41, 12);
            this.label_流控制.TabIndex = 13;
            this.label_流控制.Text = "流控制";
            // 
            // label_校验位
            // 
            this.label_校验位.AutoSize = true;
            this.label_校验位.Location = new System.Drawing.Point(3, 78);
            this.label_校验位.Name = "label_校验位";
            this.label_校验位.Size = new System.Drawing.Size(41, 12);
            this.label_校验位.TabIndex = 17;
            this.label_校验位.Text = "校验位";
            // 
            // comboBox_停止位
            // 
            this.comboBox_停止位.FormattingEnabled = true;
            this.comboBox_停止位.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.comboBox_停止位.Location = new System.Drawing.Point(50, 51);
            this.comboBox_停止位.Name = "comboBox_停止位";
            this.comboBox_停止位.Size = new System.Drawing.Size(82, 20);
            this.comboBox_停止位.TabIndex = 16;
            this.comboBox_停止位.Text = "1";
            // 
            // label_停止位
            // 
            this.label_停止位.AutoSize = true;
            this.label_停止位.Location = new System.Drawing.Point(3, 56);
            this.label_停止位.Name = "label_停止位";
            this.label_停止位.Size = new System.Drawing.Size(41, 12);
            this.label_停止位.TabIndex = 15;
            this.label_停止位.Text = "停止位";
            // 
            // comboBox_数据位
            // 
            this.comboBox_数据位.FormattingEnabled = true;
            this.comboBox_数据位.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBox_数据位.Location = new System.Drawing.Point(50, 28);
            this.comboBox_数据位.Name = "comboBox_数据位";
            this.comboBox_数据位.Size = new System.Drawing.Size(82, 20);
            this.comboBox_数据位.TabIndex = 14;
            this.comboBox_数据位.Text = "8";
            // 
            // comboBox_波特率
            // 
            this.comboBox_波特率.FormattingEnabled = true;
            this.comboBox_波特率.Items.AddRange(new object[] {
            "1200bps",
            "2400bps",
            "4800bps",
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.comboBox_波特率.Location = new System.Drawing.Point(50, 7);
            this.comboBox_波特率.Name = "comboBox_波特率";
            this.comboBox_波特率.Size = new System.Drawing.Size(82, 20);
            this.comboBox_波特率.TabIndex = 14;
            this.comboBox_波特率.Text = "115200bps";
            this.comboBox_波特率.SelectedIndexChanged += new System.EventHandler(this.comboBox_波特率_SelectedIndexChanged);
            // 
            // label_数据位
            // 
            this.label_数据位.AutoSize = true;
            this.label_数据位.Location = new System.Drawing.Point(3, 33);
            this.label_数据位.Name = "label_数据位";
            this.label_数据位.Size = new System.Drawing.Size(41, 12);
            this.label_数据位.TabIndex = 13;
            this.label_数据位.Text = "数据位";
            // 
            // label_波特率
            // 
            this.label_波特率.AutoSize = true;
            this.label_波特率.Location = new System.Drawing.Point(3, 12);
            this.label_波特率.Name = "label_波特率";
            this.label_波特率.Size = new System.Drawing.Size(41, 12);
            this.label_波特率.TabIndex = 13;
            this.label_波特率.Text = "波特率";
            // 
            // button_帮助
            // 
            this.button_帮助.Location = new System.Drawing.Point(222, 268);
            this.button_帮助.Name = "button_帮助";
            this.button_帮助.Size = new System.Drawing.Size(79, 22);
            this.button_帮助.TabIndex = 11;
            this.button_帮助.Text = "帮助";
            this.button_帮助.UseVisualStyleBackColor = true;
            // 
            // radioButton_打开串口
            // 
            this.radioButton_打开串口.AutoCheck = false;
            this.radioButton_打开串口.AutoSize = true;
            this.radioButton_打开串口.Location = new System.Drawing.Point(117, 271);
            this.radioButton_打开串口.Name = "radioButton_打开串口";
            this.radioButton_打开串口.Size = new System.Drawing.Size(14, 13);
            this.radioButton_打开串口.TabIndex = 10;
            this.radioButton_打开串口.TabStop = true;
            this.radioButton_打开串口.UseVisualStyleBackColor = true;
            // 
            // button_OpenSerial
            // 
            this.button_OpenSerial.Location = new System.Drawing.Point(137, 268);
            this.button_OpenSerial.Name = "button_OpenSerial";
            this.button_OpenSerial.Size = new System.Drawing.Size(79, 22);
            this.button_OpenSerial.TabIndex = 9;
            this.button_OpenSerial.Text = "打开串口";
            this.button_OpenSerial.UseVisualStyleBackColor = true;
            this.button_OpenSerial.Click += new System.EventHandler(this.button_打开关闭串口_Click);
            // 
            // comboBox_ComPort
            // 
            this.comboBox_ComPort.FormattingEnabled = true;
            this.comboBox_ComPort.Location = new System.Drawing.Point(56, 271);
            this.comboBox_ComPort.Name = "comboBox_ComPort";
            this.comboBox_ComPort.Size = new System.Drawing.Size(55, 20);
            this.comboBox_ComPort.TabIndex = 8;
            // 
            // label_串口号
            // 
            this.label_串口号.AutoSize = true;
            this.label_串口号.Location = new System.Drawing.Point(9, 276);
            this.label_串口号.Name = "label_串口号";
            this.label_串口号.Size = new System.Drawing.Size(41, 12);
            this.label_串口号.TabIndex = 7;
            this.label_串口号.Text = "串口号";
            // 
            // checkBox_IsHex
            // 
            this.checkBox_IsHex.AutoSize = true;
            this.checkBox_IsHex.Location = new System.Drawing.Point(580, 246);
            this.checkBox_IsHex.Name = "checkBox_IsHex";
            this.checkBox_IsHex.Size = new System.Drawing.Size(66, 16);
            this.checkBox_IsHex.TabIndex = 6;
            this.checkBox_IsHex.Text = "Hex显示";
            this.checkBox_IsHex.UseVisualStyleBackColor = true;
            // 
            // button_ClearWindow
            // 
            this.button_ClearWindow.Location = new System.Drawing.Point(495, 242);
            this.button_ClearWindow.Name = "button_ClearWindow";
            this.button_ClearWindow.Size = new System.Drawing.Size(79, 22);
            this.button_ClearWindow.TabIndex = 5;
            this.button_ClearWindow.Text = "清除窗口";
            this.button_ClearWindow.UseVisualStyleBackColor = true;
            this.button_ClearWindow.Click += new System.EventHandler(this.button_清除窗口_Click);
            // 
            // button_SaveWindow
            // 
            this.button_SaveWindow.Location = new System.Drawing.Point(410, 242);
            this.button_SaveWindow.Name = "button_SaveWindow";
            this.button_SaveWindow.Size = new System.Drawing.Size(79, 22);
            this.button_SaveWindow.TabIndex = 4;
            this.button_SaveWindow.Text = "保存窗口";
            this.button_SaveWindow.UseVisualStyleBackColor = true;
            this.button_SaveWindow.Click += new System.EventHandler(this.button_保存窗口_Click);
            // 
            // button_SendFile
            // 
            this.button_SendFile.Enabled = false;
            this.button_SendFile.Location = new System.Drawing.Point(325, 242);
            this.button_SendFile.Name = "button_SendFile";
            this.button_SendFile.Size = new System.Drawing.Size(79, 22);
            this.button_SendFile.TabIndex = 3;
            this.button_SendFile.Text = "发送文件";
            this.button_SendFile.UseVisualStyleBackColor = true;
            this.button_SendFile.Click += new System.EventHandler(this.button_发送文件_Click);
            // 
            // textBox_文件地址
            // 
            this.textBox_文件地址.Location = new System.Drawing.Point(85, 242);
            this.textBox_文件地址.Name = "textBox_文件地址";
            this.textBox_文件地址.Size = new System.Drawing.Size(234, 21);
            this.textBox_文件地址.TabIndex = 2;
            // 
            // button_OPENFILE
            // 
            this.button_OPENFILE.Location = new System.Drawing.Point(0, 242);
            this.button_OPENFILE.Name = "button_OPENFILE";
            this.button_OPENFILE.Size = new System.Drawing.Size(79, 22);
            this.button_OPENFILE.TabIndex = 1;
            this.button_OPENFILE.Text = "打开文件";
            this.button_OPENFILE.UseVisualStyleBackColor = true;
            this.button_OPENFILE.Click += new System.EventHandler(this.button_打开文件_Click);
            // 
            // richTextBox_RevWindow
            // 
            this.richTextBox_RevWindow.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_RevWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_RevWindow.Location = new System.Drawing.Point(2, -2);
            this.richTextBox_RevWindow.Name = "richTextBox_RevWindow";
            this.richTextBox_RevWindow.ReadOnly = true;
            this.richTextBox_RevWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_RevWindow.Size = new System.Drawing.Size(651, 242);
            this.richTextBox_RevWindow.TabIndex = 0;
            this.richTextBox_RevWindow.Text = "";
            // 
            // tabPage_串口配置工具
            // 
            this.tabPage_串口配置工具.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_串口配置工具.Controls.Add(this.groupBox_param);
            this.tabPage_串口配置工具.Location = new System.Drawing.Point(4, 22);
            this.tabPage_串口配置工具.Name = "tabPage_串口配置工具";
            this.tabPage_串口配置工具.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_串口配置工具.Size = new System.Drawing.Size(655, 444);
            this.tabPage_串口配置工具.TabIndex = 1;
            this.tabPage_串口配置工具.Text = "串口配置工具";
            // 
            // groupBox_param
            // 
            this.groupBox_param.Controls.Add(this.button_RevMode);
            this.groupBox_param.Controls.Add(this.checkBox_包完整模式);
            this.groupBox_param.Controls.Add(this.panel_包长设定);
            this.groupBox_param.Controls.Add(this.textBox_SendAddr);
            this.groupBox_param.Controls.Add(this.textBox_RevAddress);
            this.groupBox_param.Controls.Add(this.checkBox_纠错编码使能);
            this.groupBox_param.Controls.Add(this.label_射频发射功率单位);
            this.groupBox_param.Controls.Add(this.textBox_延时触发间隔);
            this.groupBox_param.Controls.Add(comboBox_唤醒时间间隔);
            this.groupBox_param.Controls.Add(this.comboBox_串口奇偶校验);
            this.groupBox_param.Controls.Add(this.comboBox_串口波特率);
            this.groupBox_param.Controls.Add(this.comboBox_射频发射功率);
            this.groupBox_param.Controls.Add(this.comboBox_射频空中速率);
            this.groupBox_param.Controls.Add(this.label_包完整模式);
            this.groupBox_param.Controls.Add(this.label_包长设定);
            this.groupBox_param.Controls.Add(this.label_目标地址);
            this.groupBox_param.Controls.Add(this.label_本机地址);
            this.groupBox_param.Controls.Add(this.label_纠错编码使能);
            this.groupBox_param.Controls.Add(this.label_延时触发间隔);
            this.groupBox_param.Controls.Add(this.label_唤醒时间间隔);
            this.groupBox_param.Controls.Add(this.label_串口奇偶校验);
            this.groupBox_param.Controls.Add(this.label_串口波特率);
            this.groupBox_param.Controls.Add(this.label_射频发射功率);
            this.groupBox_param.Controls.Add(this.label_射频空中速率);
            this.groupBox_param.Controls.Add(this.label_射频工作频率单位);
            this.groupBox_param.Controls.Add(this.textBox_射频工作频率);
            this.groupBox_param.Controls.Add(this.label_射频工作频率);
            this.groupBox_param.Location = new System.Drawing.Point(28, 22);
            this.groupBox_param.Name = "groupBox_param";
            this.groupBox_param.Size = new System.Drawing.Size(585, 406);
            this.groupBox_param.TabIndex = 0;
            this.groupBox_param.TabStop = false;
            this.groupBox_param.Text = "无线模块参数配置";
            // 
            // button_RevMode
            // 
            this.button_RevMode.Location = new System.Drawing.Point(11, 354);
            this.button_RevMode.Name = "button_RevMode";
            this.button_RevMode.Size = new System.Drawing.Size(131, 30);
            this.button_RevMode.TabIndex = 30;
            this.button_RevMode.Text = "接收模式";
            this.button_RevMode.UseVisualStyleBackColor = true;
            // 
            // checkBox_包完整模式
            // 
            this.checkBox_包完整模式.AutoSize = true;
            this.checkBox_包完整模式.Location = new System.Drawing.Point(104, 297);
            this.checkBox_包完整模式.Name = "checkBox_包完整模式";
            this.checkBox_包完整模式.Size = new System.Drawing.Size(15, 14);
            this.checkBox_包完整模式.TabIndex = 27;
            this.checkBox_包完整模式.UseVisualStyleBackColor = true;
            // 
            // panel_包长设定
            // 
            this.panel_包长设定.Controls.Add(this.radioButton_包长设定_64);
            this.panel_包长设定.Controls.Add(this.radioButton_包长设定_32);
            this.panel_包长设定.Controls.Add(this.radioButton_包长设定_16);
            this.panel_包长设定.Controls.Add(this.radioButton_包长设定_8);
            this.panel_包长设定.Controls.Add(this.radioButton_包长设定_4);
            this.panel_包长设定.Controls.Add(this.radioButton_包长设定_2);
            this.panel_包长设定.Location = new System.Drawing.Point(84, 273);
            this.panel_包长设定.Name = "panel_包长设定";
            this.panel_包长设定.Size = new System.Drawing.Size(221, 15);
            this.panel_包长设定.TabIndex = 26;
            // 
            // radioButton_包长设定_64
            // 
            this.radioButton_包长设定_64.AutoSize = true;
            this.radioButton_包长设定_64.Location = new System.Drawing.Point(178, -1);
            this.radioButton_包长设定_64.Name = "radioButton_包长设定_64";
            this.radioButton_包长设定_64.Size = new System.Drawing.Size(35, 16);
            this.radioButton_包长设定_64.TabIndex = 4;
            this.radioButton_包长设定_64.TabStop = true;
            this.radioButton_包长设定_64.Text = "64";
            this.radioButton_包长设定_64.UseVisualStyleBackColor = true;
            // 
            // radioButton_包长设定_32
            // 
            this.radioButton_包长设定_32.AutoSize = true;
            this.radioButton_包长设定_32.Location = new System.Drawing.Point(143, -1);
            this.radioButton_包长设定_32.Name = "radioButton_包长设定_32";
            this.radioButton_包长设定_32.Size = new System.Drawing.Size(35, 16);
            this.radioButton_包长设定_32.TabIndex = 3;
            this.radioButton_包长设定_32.TabStop = true;
            this.radioButton_包长设定_32.Text = "32";
            this.radioButton_包长设定_32.UseVisualStyleBackColor = true;
            // 
            // radioButton_包长设定_16
            // 
            this.radioButton_包长设定_16.AutoSize = true;
            this.radioButton_包长设定_16.Location = new System.Drawing.Point(108, -1);
            this.radioButton_包长设定_16.Name = "radioButton_包长设定_16";
            this.radioButton_包长设定_16.Size = new System.Drawing.Size(35, 16);
            this.radioButton_包长设定_16.TabIndex = 1;
            this.radioButton_包长设定_16.TabStop = true;
            this.radioButton_包长设定_16.Text = "10";
            this.radioButton_包长设定_16.UseVisualStyleBackColor = true;
            // 
            // radioButton_包长设定_8
            // 
            this.radioButton_包长设定_8.AutoSize = true;
            this.radioButton_包长设定_8.Location = new System.Drawing.Point(73, -1);
            this.radioButton_包长设定_8.Name = "radioButton_包长设定_8";
            this.radioButton_包长设定_8.Size = new System.Drawing.Size(29, 16);
            this.radioButton_包长设定_8.TabIndex = 2;
            this.radioButton_包长设定_8.TabStop = true;
            this.radioButton_包长设定_8.Text = "8";
            this.radioButton_包长设定_8.UseVisualStyleBackColor = true;
            // 
            // radioButton_包长设定_4
            // 
            this.radioButton_包长设定_4.AutoSize = true;
            this.radioButton_包长设定_4.Location = new System.Drawing.Point(38, -1);
            this.radioButton_包长设定_4.Name = "radioButton_包长设定_4";
            this.radioButton_包长设定_4.Size = new System.Drawing.Size(29, 16);
            this.radioButton_包长设定_4.TabIndex = 1;
            this.radioButton_包长设定_4.TabStop = true;
            this.radioButton_包长设定_4.Text = "4";
            this.radioButton_包长设定_4.UseVisualStyleBackColor = true;
            // 
            // radioButton_包长设定_2
            // 
            this.radioButton_包长设定_2.AutoSize = true;
            this.radioButton_包长设定_2.Location = new System.Drawing.Point(3, -1);
            this.radioButton_包长设定_2.Name = "radioButton_包长设定_2";
            this.radioButton_包长设定_2.Size = new System.Drawing.Size(29, 16);
            this.radioButton_包长设定_2.TabIndex = 0;
            this.radioButton_包长设定_2.TabStop = true;
            this.radioButton_包长设定_2.Text = "2";
            this.radioButton_包长设定_2.UseVisualStyleBackColor = true;
            // 
            // textBox_SendAddr
            // 
            this.textBox_SendAddr.Location = new System.Drawing.Point(104, 246);
            this.textBox_SendAddr.Name = "textBox_SendAddr";
            this.textBox_SendAddr.Size = new System.Drawing.Size(100, 21);
            this.textBox_SendAddr.TabIndex = 25;
            this.textBox_SendAddr.Text = "3443101001";
            // 
            // textBox_RevAddress
            // 
            this.textBox_RevAddress.Location = new System.Drawing.Point(104, 221);
            this.textBox_RevAddress.Name = "textBox_RevAddress";
            this.textBox_RevAddress.Size = new System.Drawing.Size(100, 21);
            this.textBox_RevAddress.TabIndex = 24;
            this.textBox_RevAddress.Text = "3443101001";
            // 
            // checkBox_纠错编码使能
            // 
            this.checkBox_纠错编码使能.AutoSize = true;
            this.checkBox_纠错编码使能.Location = new System.Drawing.Point(104, 201);
            this.checkBox_纠错编码使能.Name = "checkBox_纠错编码使能";
            this.checkBox_纠错编码使能.Size = new System.Drawing.Size(15, 14);
            this.checkBox_纠错编码使能.TabIndex = 23;
            this.checkBox_纠错编码使能.UseVisualStyleBackColor = true;
            // 
            // label_射频发射功率单位
            // 
            this.label_射频发射功率单位.AutoSize = true;
            this.label_射频发射功率单位.Location = new System.Drawing.Point(210, 178);
            this.label_射频发射功率单位.Name = "label_射频发射功率单位";
            this.label_射频发射功率单位.Size = new System.Drawing.Size(17, 12);
            this.label_射频发射功率单位.TabIndex = 22;
            this.label_射频发射功率单位.Text = "ms";
            // 
            // textBox_延时触发间隔
            // 
            this.textBox_延时触发间隔.Location = new System.Drawing.Point(104, 175);
            this.textBox_延时触发间隔.Name = "textBox_延时触发间隔";
            this.textBox_延时触发间隔.Size = new System.Drawing.Size(100, 21);
            this.textBox_延时触发间隔.TabIndex = 21;
            this.textBox_延时触发间隔.Text = "5";
            // 
            // comboBox_串口奇偶校验
            // 
            this.comboBox_串口奇偶校验.FormattingEnabled = true;
            this.comboBox_串口奇偶校验.Items.AddRange(new object[] {
            "无校验",
            "奇校验",
            "偶校验"});
            this.comboBox_串口奇偶校验.Location = new System.Drawing.Point(104, 129);
            this.comboBox_串口奇偶校验.Name = "comboBox_串口奇偶校验";
            this.comboBox_串口奇偶校验.Size = new System.Drawing.Size(100, 20);
            this.comboBox_串口奇偶校验.TabIndex = 19;
            this.comboBox_串口奇偶校验.Text = "无校验";
            // 
            // comboBox_串口波特率
            // 
            this.comboBox_串口波特率.FormattingEnabled = true;
            this.comboBox_串口波特率.Items.AddRange(new object[] {
            "1200bps",
            "2400bps",
            "4800bps",
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps"});
            this.comboBox_串口波特率.Location = new System.Drawing.Point(104, 103);
            this.comboBox_串口波特率.Name = "comboBox_串口波特率";
            this.comboBox_串口波特率.Size = new System.Drawing.Size(100, 20);
            this.comboBox_串口波特率.TabIndex = 18;
            this.comboBox_串口波特率.Text = "9600bps";
            this.comboBox_串口波特率.SelectedIndexChanged += new System.EventHandler(this.comboBox_串口波特率_SelectedIndexChanged);
            // 
            // comboBox_射频发射功率
            // 
            this.comboBox_射频发射功率.FormattingEnabled = true;
            this.comboBox_射频发射功率.Items.AddRange(new object[] {
            "-8.5dBm",
            "-5.5dBm",
            "-2.5dBm",
            "0.5dBm",
            "3.5dBm",
            "6.5dBm",
            "9.5dBm",
            "12.5dBm"});
            this.comboBox_射频发射功率.Location = new System.Drawing.Point(104, 77);
            this.comboBox_射频发射功率.Name = "comboBox_射频发射功率";
            this.comboBox_射频发射功率.Size = new System.Drawing.Size(100, 20);
            this.comboBox_射频发射功率.TabIndex = 17;
            this.comboBox_射频发射功率.Text = "0.5dBm";
            // 
            // comboBox_射频空中速率
            // 
            this.comboBox_射频空中速率.FormattingEnabled = true;
            this.comboBox_射频空中速率.Items.AddRange(new object[] {
            "1Kbps",
            "2Kbps",
            "5Kbps",
            "10Kbps",
            "25Kbps",
            "40Kbps"});
            this.comboBox_射频空中速率.Location = new System.Drawing.Point(104, 55);
            this.comboBox_射频空中速率.Name = "comboBox_射频空中速率";
            this.comboBox_射频空中速率.Size = new System.Drawing.Size(100, 20);
            this.comboBox_射频空中速率.TabIndex = 16;
            this.comboBox_射频空中速率.Text = "1Kbps";
            // 
            // label_包完整模式
            // 
            this.label_包完整模式.AutoSize = true;
            this.label_包完整模式.Location = new System.Drawing.Point(9, 297);
            this.label_包完整模式.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_包完整模式.Name = "label_包完整模式";
            this.label_包完整模式.Size = new System.Drawing.Size(77, 12);
            this.label_包完整模式.TabIndex = 14;
            this.label_包完整模式.Text = "包完整模式：";
            // 
            // label_包长设定
            // 
            this.label_包长设定.AutoSize = true;
            this.label_包长设定.Location = new System.Drawing.Point(9, 273);
            this.label_包长设定.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_包长设定.Name = "label_包长设定";
            this.label_包长设定.Size = new System.Drawing.Size(65, 12);
            this.label_包长设定.TabIndex = 13;
            this.label_包长设定.Text = "包长设定：";
            // 
            // label_目标地址
            // 
            this.label_目标地址.AutoSize = true;
            this.label_目标地址.Location = new System.Drawing.Point(9, 249);
            this.label_目标地址.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_目标地址.Name = "label_目标地址";
            this.label_目标地址.Size = new System.Drawing.Size(89, 12);
            this.label_目标地址.TabIndex = 12;
            this.label_目标地址.Text = "发送目标地址：";
            // 
            // label_本机地址
            // 
            this.label_本机地址.AutoSize = true;
            this.label_本机地址.Location = new System.Drawing.Point(9, 224);
            this.label_本机地址.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_本机地址.Name = "label_本机地址";
            this.label_本机地址.Size = new System.Drawing.Size(89, 12);
            this.label_本机地址.TabIndex = 11;
            this.label_本机地址.Text = "本机接收地址：";
            // 
            // label_纠错编码使能
            // 
            this.label_纠错编码使能.AutoSize = true;
            this.label_纠错编码使能.Location = new System.Drawing.Point(9, 201);
            this.label_纠错编码使能.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_纠错编码使能.Name = "label_纠错编码使能";
            this.label_纠错编码使能.Size = new System.Drawing.Size(89, 12);
            this.label_纠错编码使能.TabIndex = 10;
            this.label_纠错编码使能.Text = "纠错编码使能：";
            // 
            // label_延时触发间隔
            // 
            this.label_延时触发间隔.AutoSize = true;
            this.label_延时触发间隔.Location = new System.Drawing.Point(9, 178);
            this.label_延时触发间隔.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_延时触发间隔.Name = "label_延时触发间隔";
            this.label_延时触发间隔.Size = new System.Drawing.Size(89, 12);
            this.label_延时触发间隔.TabIndex = 9;
            this.label_延时触发间隔.Text = "延时触发间隔：";
            // 
            // label_唤醒时间间隔
            // 
            this.label_唤醒时间间隔.AutoSize = true;
            this.label_唤醒时间间隔.Location = new System.Drawing.Point(9, 156);
            this.label_唤醒时间间隔.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_唤醒时间间隔.Name = "label_唤醒时间间隔";
            this.label_唤醒时间间隔.Size = new System.Drawing.Size(89, 12);
            this.label_唤醒时间间隔.TabIndex = 7;
            this.label_唤醒时间间隔.Text = "唤醒时间间隔：";
            // 
            // label_串口奇偶校验
            // 
            this.label_串口奇偶校验.AutoSize = true;
            this.label_串口奇偶校验.Location = new System.Drawing.Point(9, 133);
            this.label_串口奇偶校验.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_串口奇偶校验.Name = "label_串口奇偶校验";
            this.label_串口奇偶校验.Size = new System.Drawing.Size(89, 12);
            this.label_串口奇偶校验.TabIndex = 6;
            this.label_串口奇偶校验.Text = "串口奇偶校验：";
            // 
            // label_串口波特率
            // 
            this.label_串口波特率.AutoSize = true;
            this.label_串口波特率.Location = new System.Drawing.Point(9, 109);
            this.label_串口波特率.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_串口波特率.Name = "label_串口波特率";
            this.label_串口波特率.Size = new System.Drawing.Size(77, 12);
            this.label_串口波特率.TabIndex = 5;
            this.label_串口波特率.Text = "串口波特率：";
            // 
            // label_射频发射功率
            // 
            this.label_射频发射功率.AutoSize = true;
            this.label_射频发射功率.Location = new System.Drawing.Point(9, 85);
            this.label_射频发射功率.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_射频发射功率.Name = "label_射频发射功率";
            this.label_射频发射功率.Size = new System.Drawing.Size(89, 12);
            this.label_射频发射功率.TabIndex = 4;
            this.label_射频发射功率.Text = "射频发射功率：";
            // 
            // label_射频空中速率
            // 
            this.label_射频空中速率.AutoSize = true;
            this.label_射频空中速率.Location = new System.Drawing.Point(9, 59);
            this.label_射频空中速率.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_射频空中速率.Name = "label_射频空中速率";
            this.label_射频空中速率.Size = new System.Drawing.Size(89, 12);
            this.label_射频空中速率.TabIndex = 3;
            this.label_射频空中速率.Text = "射频空中速率：";
            // 
            // label_射频工作频率单位
            // 
            this.label_射频工作频率单位.AutoSize = true;
            this.label_射频工作频率单位.Location = new System.Drawing.Point(210, 31);
            this.label_射频工作频率单位.Name = "label_射频工作频率单位";
            this.label_射频工作频率单位.Size = new System.Drawing.Size(23, 12);
            this.label_射频工作频率单位.TabIndex = 2;
            this.label_射频工作频率单位.Text = "GHz";
            // 
            // textBox_射频工作频率
            // 
            this.textBox_射频工作频率.Location = new System.Drawing.Point(104, 28);
            this.textBox_射频工作频率.Name = "textBox_射频工作频率";
            this.textBox_射频工作频率.Size = new System.Drawing.Size(100, 21);
            this.textBox_射频工作频率.TabIndex = 1;
            this.textBox_射频工作频率.Text = "2.4";
            // 
            // label_射频工作频率
            // 
            this.label_射频工作频率.AutoSize = true;
            this.label_射频工作频率.Location = new System.Drawing.Point(9, 31);
            this.label_射频工作频率.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_射频工作频率.Name = "label_射频工作频率";
            this.label_射频工作频率.Size = new System.Drawing.Size(89, 12);
            this.label_射频工作频率.TabIndex = 0;
            this.label_射频工作频率.Text = "射频工作频率：";
            // 
            // tabPage_24L01Send
            // 
            this.tabPage_24L01Send.Controls.Add(this.groupBox1);
            this.tabPage_24L01Send.Location = new System.Drawing.Point(4, 22);
            this.tabPage_24L01Send.Name = "tabPage_24L01Send";
            this.tabPage_24L01Send.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_24L01Send.Size = new System.Drawing.Size(655, 444);
            this.tabPage_24L01Send.TabIndex = 2;
            this.tabPage_24L01Send.Text = "24L01发送模拟";
            this.tabPage_24L01Send.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_SendMode);
            this.groupBox1.Controls.Add(this.richTextBox_Send);
            this.groupBox1.Controls.Add(this.button_MouseDown);
            this.groupBox1.Controls.Add(this.button_MouseRight);
            this.groupBox1.Controls.Add(this.button_MouseRightKeyDown);
            this.groupBox1.Controls.Add(this.button_MouseMidKeyDown);
            this.groupBox1.Controls.Add(this.button_PageDown);
            this.groupBox1.Controls.Add(this.button_PageUp);
            this.groupBox1.Controls.Add(this.button_ButtonErase);
            this.groupBox1.Controls.Add(this.button_ButtonPaint);
            this.groupBox1.Controls.Add(this.button_FullPrint);
            this.groupBox1.Controls.Add(this.button_MouseLeftKeyDown);
            this.groupBox1.Controls.Add(this.button_MouseLeft);
            this.groupBox1.Controls.Add(this.button_MouseUp);
            this.groupBox1.Location = new System.Drawing.Point(8, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 415);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "24L01发送";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mouse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "MouseKey:";
            // 
            // button_SendMode
            // 
            this.button_SendMode.Location = new System.Drawing.Point(24, 35);
            this.button_SendMode.Name = "button_SendMode";
            this.button_SendMode.Size = new System.Drawing.Size(131, 30);
            this.button_SendMode.TabIndex = 30;
            this.button_SendMode.Text = "发送模式";
            this.button_SendMode.UseVisualStyleBackColor = true;
            this.button_SendMode.Click += new System.EventHandler(this.button_SendMode_Click);
            // 
            // richTextBox_Send
            // 
            this.richTextBox_Send.Location = new System.Drawing.Point(24, 95);
            this.richTextBox_Send.Name = "richTextBox_Send";
            this.richTextBox_Send.Size = new System.Drawing.Size(299, 271);
            this.richTextBox_Send.TabIndex = 0;
            this.richTextBox_Send.Text = "";
            // 
            // button_MouseDown
            // 
            this.button_MouseDown.Location = new System.Drawing.Point(475, 144);
            this.button_MouseDown.Name = "button_MouseDown";
            this.button_MouseDown.Size = new System.Drawing.Size(45, 40);
            this.button_MouseDown.TabIndex = 2;
            this.button_MouseDown.Text = "Down";
            this.button_MouseDown.UseVisualStyleBackColor = true;
            this.button_MouseDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Down);
            this.button_MouseDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseDown_UP);
            // 
            // button_MouseRight
            // 
            this.button_MouseRight.Location = new System.Drawing.Point(521, 95);
            this.button_MouseRight.Name = "button_MouseRight";
            this.button_MouseRight.Size = new System.Drawing.Size(45, 40);
            this.button_MouseRight.TabIndex = 2;
            this.button_MouseRight.Text = "Right";
            this.button_MouseRight.UseVisualStyleBackColor = true;
            this.button_MouseRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseRightDown);
            this.button_MouseRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseRight_Up);
            // 
            // button_MouseRightKeyDown
            // 
            this.button_MouseRightKeyDown.Location = new System.Drawing.Point(543, 190);
            this.button_MouseRightKeyDown.Name = "button_MouseRightKeyDown";
            this.button_MouseRightKeyDown.Size = new System.Drawing.Size(45, 40);
            this.button_MouseRightKeyDown.TabIndex = 2;
            this.button_MouseRightKeyDown.Text = "Right";
            this.button_MouseRightKeyDown.UseVisualStyleBackColor = true;
            this.button_MouseRightKeyDown.Click += new System.EventHandler(this.button_MouseRightKeyDown_Click);
            // 
            // button_MouseMidKeyDown
            // 
            this.button_MouseMidKeyDown.Location = new System.Drawing.Point(475, 190);
            this.button_MouseMidKeyDown.Name = "button_MouseMidKeyDown";
            this.button_MouseMidKeyDown.Size = new System.Drawing.Size(45, 40);
            this.button_MouseMidKeyDown.TabIndex = 2;
            this.button_MouseMidKeyDown.Text = "Mid";
            this.button_MouseMidKeyDown.UseVisualStyleBackColor = true;
            this.button_MouseMidKeyDown.Click += new System.EventHandler(this.button_MouseMidKeyDown_Click);
            // 
            // button_PageDown
            // 
            this.button_PageDown.Location = new System.Drawing.Point(508, 326);
            this.button_PageDown.Name = "button_PageDown";
            this.button_PageDown.Size = new System.Drawing.Size(67, 40);
            this.button_PageDown.TabIndex = 2;
            this.button_PageDown.Text = "PageDown";
            this.button_PageDown.UseVisualStyleBackColor = true;
            this.button_PageDown.Click += new System.EventHandler(this.button_PageDown_Click);
            // 
            // button_PageUp
            // 
            this.button_PageUp.Location = new System.Drawing.Point(423, 326);
            this.button_PageUp.Name = "button_PageUp";
            this.button_PageUp.Size = new System.Drawing.Size(62, 40);
            this.button_PageUp.TabIndex = 2;
            this.button_PageUp.Text = "PageUp";
            this.button_PageUp.UseVisualStyleBackColor = true;
            this.button_PageUp.Click += new System.EventHandler(this.button_PageUp_Click);
            // 
            // button_ButtonErase
            // 
            this.button_ButtonErase.Location = new System.Drawing.Point(543, 271);
            this.button_ButtonErase.Name = "button_ButtonErase";
            this.button_ButtonErase.Size = new System.Drawing.Size(68, 40);
            this.button_ButtonErase.TabIndex = 2;
            this.button_ButtonErase.Text = "Erase";
            this.button_ButtonErase.UseVisualStyleBackColor = true;
            this.button_ButtonErase.Click += new System.EventHandler(this.button_ButtonErase_Click);
            // 
            // button_ButtonPaint
            // 
            this.button_ButtonPaint.Location = new System.Drawing.Point(475, 271);
            this.button_ButtonPaint.Name = "button_ButtonPaint";
            this.button_ButtonPaint.Size = new System.Drawing.Size(45, 40);
            this.button_ButtonPaint.TabIndex = 2;
            this.button_ButtonPaint.Text = "Paint";
            this.button_ButtonPaint.UseVisualStyleBackColor = true;
            this.button_ButtonPaint.Click += new System.EventHandler(this.button_ButtonPaint_Click);
            // 
            // button_FullPrint
            // 
            this.button_FullPrint.Location = new System.Drawing.Point(385, 271);
            this.button_FullPrint.Name = "button_FullPrint";
            this.button_FullPrint.Size = new System.Drawing.Size(68, 40);
            this.button_FullPrint.TabIndex = 2;
            this.button_FullPrint.Text = "FullPrint";
            this.button_FullPrint.UseVisualStyleBackColor = true;
            this.button_FullPrint.Click += new System.EventHandler(this.button_FullPrint_Click);
            // 
            // button_MouseLeftKeyDown
            // 
            this.button_MouseLeftKeyDown.Location = new System.Drawing.Point(408, 190);
            this.button_MouseLeftKeyDown.Name = "button_MouseLeftKeyDown";
            this.button_MouseLeftKeyDown.Size = new System.Drawing.Size(45, 40);
            this.button_MouseLeftKeyDown.TabIndex = 2;
            this.button_MouseLeftKeyDown.Text = "Left";
            this.button_MouseLeftKeyDown.UseVisualStyleBackColor = true;
            this.button_MouseLeftKeyDown.Click += new System.EventHandler(this.button_MouseLeftKeyDown_Click);
            // 
            // button_MouseLeft
            // 
            this.button_MouseLeft.Location = new System.Drawing.Point(423, 95);
            this.button_MouseLeft.Name = "button_MouseLeft";
            this.button_MouseLeft.Size = new System.Drawing.Size(45, 40);
            this.button_MouseLeft.TabIndex = 2;
            this.button_MouseLeft.Text = "Left";
            this.button_MouseLeft.UseVisualStyleBackColor = true;
            this.button_MouseLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseLeftDown);
            this.button_MouseLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseLeft_UP);
            // 
            // button_MouseUp
            // 
            this.button_MouseUp.Location = new System.Drawing.Point(475, 49);
            this.button_MouseUp.Name = "button_MouseUp";
            this.button_MouseUp.Size = new System.Drawing.Size(45, 40);
            this.button_MouseUp.TabIndex = 2;
            this.button_MouseUp.Text = "Up";
            this.button_MouseUp.UseVisualStyleBackColor = true;
            this.button_MouseUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Down);
            this.button_MouseUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUP_UP);
            // 
            // tabPage_24L01Rev
            // 
            this.tabPage_24L01Rev.Controls.Add(this.groupBox2);
            this.tabPage_24L01Rev.Location = new System.Drawing.Point(4, 22);
            this.tabPage_24L01Rev.Name = "tabPage_24L01Rev";
            this.tabPage_24L01Rev.Size = new System.Drawing.Size(655, 444);
            this.tabPage_24L01Rev.TabIndex = 3;
            this.tabPage_24L01Rev.Text = "24L01接收模拟";
            this.tabPage_24L01Rev.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.label_Y);
            this.groupBox2.Controls.Add(this.label_X);
            this.groupBox2.Controls.Add(this.chart2);
            this.groupBox2.Controls.Add(this.button_RevStart);
            this.groupBox2.Controls.Add(this.button_RevMouseRight);
            this.groupBox2.Controls.Add(this.button_RevMouseMode);
            this.groupBox2.Controls.Add(this.button_RevPageDown);
            this.groupBox2.Controls.Add(this.button_RevPageUp);
            this.groupBox2.Controls.Add(this.button_Erase);
            this.groupBox2.Controls.Add(this.button_Paint);
            this.groupBox2.Controls.Add(this.button_RevFullPrint);
            this.groupBox2.Controls.Add(this.button_RevLeft);
            this.groupBox2.Controls.Add(this.button_24L01RevMode);
            this.groupBox2.Controls.Add(this.richTextBox_Rev);
            this.groupBox2.Location = new System.Drawing.Point(8, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 406);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接受";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(521, 235);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(41, 12);
            this.label_Y.TabIndex = 44;
            this.label_Y.Text = "label5";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(460, 235);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(41, 12);
            this.label_X.TabIndex = 44;
            this.label_X.Text = "label5";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(32, 20);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series_x";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series_y";
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(576, 183);
            this.chart2.TabIndex = 43;
            this.chart2.Text = "chart2";
            // 
            // button_RevStart
            // 
            this.button_RevStart.Location = new System.Drawing.Point(271, 227);
            this.button_RevStart.Name = "button_RevStart";
            this.button_RevStart.Size = new System.Drawing.Size(61, 29);
            this.button_RevStart.TabIndex = 42;
            this.button_RevStart.Text = "RevStart";
            this.button_RevStart.UseVisualStyleBackColor = true;
            this.button_RevStart.Click += new System.EventHandler(this.button_RevStart_Click);
            // 
            // button_RevMouseRight
            // 
            this.button_RevMouseRight.Location = new System.Drawing.Point(351, 338);
            this.button_RevMouseRight.Name = "button_RevMouseRight";
            this.button_RevMouseRight.Size = new System.Drawing.Size(45, 40);
            this.button_RevMouseRight.TabIndex = 34;
            this.button_RevMouseRight.Text = "Right";
            this.button_RevMouseRight.UseVisualStyleBackColor = true;
            // 
            // button_RevMouseMode
            // 
            this.button_RevMouseMode.Location = new System.Drawing.Point(287, 283);
            this.button_RevMouseMode.Name = "button_RevMouseMode";
            this.button_RevMouseMode.Size = new System.Drawing.Size(45, 40);
            this.button_RevMouseMode.TabIndex = 35;
            this.button_RevMouseMode.Text = "Mid";
            this.button_RevMouseMode.UseVisualStyleBackColor = true;
            // 
            // button_RevPageDown
            // 
            this.button_RevPageDown.Location = new System.Drawing.Point(505, 338);
            this.button_RevPageDown.Name = "button_RevPageDown";
            this.button_RevPageDown.Size = new System.Drawing.Size(67, 40);
            this.button_RevPageDown.TabIndex = 36;
            this.button_RevPageDown.Text = "PageDown";
            this.button_RevPageDown.UseVisualStyleBackColor = true;
            // 
            // button_RevPageUp
            // 
            this.button_RevPageUp.Location = new System.Drawing.Point(422, 338);
            this.button_RevPageUp.Name = "button_RevPageUp";
            this.button_RevPageUp.Size = new System.Drawing.Size(62, 40);
            this.button_RevPageUp.TabIndex = 37;
            this.button_RevPageUp.Text = "PageUp";
            this.button_RevPageUp.UseVisualStyleBackColor = true;
            // 
            // button_Erase
            // 
            this.button_Erase.Location = new System.Drawing.Point(523, 283);
            this.button_Erase.Name = "button_Erase";
            this.button_Erase.Size = new System.Drawing.Size(68, 40);
            this.button_Erase.TabIndex = 38;
            this.button_Erase.Text = "Erase";
            this.button_Erase.UseVisualStyleBackColor = true;
            // 
            // button_Paint
            // 
            this.button_Paint.Location = new System.Drawing.Point(472, 283);
            this.button_Paint.Name = "button_Paint";
            this.button_Paint.Size = new System.Drawing.Size(45, 40);
            this.button_Paint.TabIndex = 39;
            this.button_Paint.Text = "Paint";
            this.button_Paint.UseVisualStyleBackColor = true;
            // 
            // button_RevFullPrint
            // 
            this.button_RevFullPrint.Location = new System.Drawing.Point(388, 283);
            this.button_RevFullPrint.Name = "button_RevFullPrint";
            this.button_RevFullPrint.Size = new System.Drawing.Size(68, 40);
            this.button_RevFullPrint.TabIndex = 40;
            this.button_RevFullPrint.Text = "FullPrint";
            this.button_RevFullPrint.UseVisualStyleBackColor = true;
            // 
            // button_RevLeft
            // 
            this.button_RevLeft.Location = new System.Drawing.Point(287, 338);
            this.button_RevLeft.Name = "button_RevLeft";
            this.button_RevLeft.Size = new System.Drawing.Size(45, 40);
            this.button_RevLeft.TabIndex = 41;
            this.button_RevLeft.Text = "Left";
            this.button_RevLeft.UseVisualStyleBackColor = true;
            // 
            // button_24L01RevMode
            // 
            this.button_24L01RevMode.Location = new System.Drawing.Point(339, 226);
            this.button_24L01RevMode.Name = "button_24L01RevMode";
            this.button_24L01RevMode.Size = new System.Drawing.Size(95, 30);
            this.button_24L01RevMode.TabIndex = 31;
            this.button_24L01RevMode.Text = "接受模式";
            this.button_24L01RevMode.UseVisualStyleBackColor = true;
            this.button_24L01RevMode.Click += new System.EventHandler(this.button_24L01RevMode_Click);
            // 
            // richTextBox_Rev
            // 
            this.richTextBox_Rev.Location = new System.Drawing.Point(20, 241);
            this.richTextBox_Rev.Name = "richTextBox_Rev";
            this.richTextBox_Rev.Size = new System.Drawing.Size(207, 137);
            this.richTextBox_Rev.TabIndex = 0;
            this.richTextBox_Rev.Text = "";
            // 
            // tabPage_SiZhou
            // 
            this.tabPage_SiZhou.BackColor = System.Drawing.Color.Green;
            this.tabPage_SiZhou.Controls.Add(this.label_S_roll);
            this.tabPage_SiZhou.Controls.Add(this.label6);
            this.tabPage_SiZhou.Controls.Add(this.label_S_yaw);
            this.tabPage_SiZhou.Controls.Add(this.label4);
            this.tabPage_SiZhou.Controls.Add(this.label_S_Pitch);
            this.tabPage_SiZhou.Controls.Add(this.label3);
            this.tabPage_SiZhou.Controls.Add(this.chart1);
            this.tabPage_SiZhou.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SiZhou.Name = "tabPage_SiZhou";
            this.tabPage_SiZhou.Size = new System.Drawing.Size(655, 444);
            this.tabPage_SiZhou.TabIndex = 4;
            this.tabPage_SiZhou.Text = "tabPage_sizhou";
            // 
            // label_S_roll
            // 
            this.label_S_roll.AutoSize = true;
            this.label_S_roll.Location = new System.Drawing.Point(102, 380);
            this.label_S_roll.Name = "label_S_roll";
            this.label_S_roll.Size = new System.Drawing.Size(41, 12);
            this.label_S_roll.TabIndex = 2;
            this.label_S_roll.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Roll:";
            // 
            // label_S_yaw
            // 
            this.label_S_yaw.AutoSize = true;
            this.label_S_yaw.Location = new System.Drawing.Point(102, 342);
            this.label_S_yaw.Name = "label_S_yaw";
            this.label_S_yaw.Size = new System.Drawing.Size(41, 12);
            this.label_S_yaw.TabIndex = 2;
            this.label_S_yaw.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yaw:";
            // 
            // label_S_Pitch
            // 
            this.label_S_Pitch.AutoSize = true;
            this.label_S_Pitch.Location = new System.Drawing.Point(102, 306);
            this.label_S_Pitch.Name = "label_S_Pitch";
            this.label_S_Pitch.Size = new System.Drawing.Size(41, 12);
            this.label_S_Pitch.TabIndex = 2;
            this.label_S_Pitch.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pitch:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(19, 15);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Series_pitch";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Series_yaw";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "Series_roll";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(603, 259);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // saveFileDialog_保存
            // 
            this.saveFileDialog_保存.Filter = "文本文件(*.txt)|*.txt";
            // 
            // timer_文件定时发送
            // 
            this.timer_文件定时发送.Tick += new System.EventHandler(this.timer_文件定时发送_Tick);
            // 
            // openFileDialog_打开文件
            // 
            this.openFileDialog_打开文件.Filter = "文本文件(*.txt)|*.txt";
            // 
            // timer_字符串定时发送
            // 
            this.timer_字符串定时发送.Tick += new System.EventHandler(this.timer_字符串定时发送_Tick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SSCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(661, 473);
            this.Controls.Add(this.tabControl_UC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SSCOM";
            this.Text = "天恒调试助手";
            this.Load += new System.EventHandler(this.SSCOM_Load);
            this.tabControl_UC.ResumeLayout(false);
            this.tabPage_ComDebug.ResumeLayout(false);
            this.tabPage_ComDebug.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_串口配置工具.ResumeLayout(false);
            this.groupBox_param.ResumeLayout(false);
            this.groupBox_param.PerformLayout();
            this.panel_包长设定.ResumeLayout(false);
            this.panel_包长设定.PerformLayout();
            this.tabPage_24L01Send.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_24L01Rev.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage_SiZhou.ResumeLayout(false);
            this.tabPage_SiZhou.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_UC;
        private System.Windows.Forms.TabPage tabPage_ComDebug;
        private System.Windows.Forms.TabPage tabPage_串口配置工具;
        private System.Windows.Forms.Button button_ClearWindow;
        private System.Windows.Forms.Button button_SaveWindow;
        private System.Windows.Forms.Button button_SendFile;
        private System.Windows.Forms.TextBox textBox_文件地址;
        private System.Windows.Forms.Button button_OPENFILE;
        private System.Windows.Forms.RichTextBox richTextBox_RevWindow;
        private System.Windows.Forms.ComboBox comboBox_ComPort;
        private System.Windows.Forms.Label label_串口号;
        private System.Windows.Forms.CheckBox checkBox_IsHex;
        private System.Windows.Forms.Button button_帮助;
        private System.Windows.Forms.RadioButton radioButton_打开串口;
        private System.Windows.Forms.Button button_OpenSerial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_RTS;
        private System.Windows.Forms.CheckBox checkBox_DTR;
        private System.Windows.Forms.ComboBox comboBox_流控制;
        private System.Windows.Forms.ComboBox comboBox_校验位;
        private System.Windows.Forms.Label label_流控制;
        private System.Windows.Forms.Label label_校验位;
        private System.Windows.Forms.ComboBox comboBox_停止位;
        private System.Windows.Forms.Label label_停止位;
        private System.Windows.Forms.ComboBox comboBox_数据位;
        private System.Windows.Forms.ComboBox comboBox_波特率;
        private System.Windows.Forms.Label label_数据位;
        private System.Windows.Forms.Label label_波特率;
        private System.Windows.Forms.TextBox textBox_发送窗口;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label_字符串;
        private System.Windows.Forms.CheckBox checkBox_Hex发送;
        private System.Windows.Forms.Label label_速度单位;
        private System.Windows.Forms.TextBox textBox_速率;
        private System.Windows.Forms.CheckBox checkBox_定时发送;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_发送的数据量;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_接收的数据量;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_其他串口信息;
        private System.Windows.Forms.GroupBox groupBox_param;
        private System.Windows.Forms.ComboBox comboBox_射频空中速率;
        private System.Windows.Forms.Label label_包完整模式;
        private System.Windows.Forms.Label label_包长设定;
        private System.Windows.Forms.Label label_纠错编码使能;
        private System.Windows.Forms.Label label_延时触发间隔;
        private System.Windows.Forms.Label label_唤醒时间间隔;
        private System.Windows.Forms.Label label_串口奇偶校验;
        private System.Windows.Forms.Label label_串口波特率;
        private System.Windows.Forms.Label label_射频发射功率;
        private System.Windows.Forms.Label label_射频空中速率;
        private System.Windows.Forms.Label label_射频工作频率单位;
        private System.Windows.Forms.TextBox textBox_射频工作频率;
        private System.Windows.Forms.Label label_射频工作频率;
        private System.Windows.Forms.ComboBox comboBox_射频发射功率;
        private System.Windows.Forms.ComboBox comboBox_串口波特率;
        private System.Windows.Forms.Label label_射频发射功率单位;
        private System.Windows.Forms.TextBox textBox_延时触发间隔;
        private System.Windows.Forms.ComboBox comboBox_串口奇偶校验;
        private System.Windows.Forms.CheckBox checkBox_纠错编码使能;
        private System.Windows.Forms.Panel panel_包长设定;
        private System.Windows.Forms.RadioButton radioButton_包长设定_64;
        private System.Windows.Forms.RadioButton radioButton_包长设定_32;
        private System.Windows.Forms.RadioButton radioButton_包长设定_16;
        private System.Windows.Forms.RadioButton radioButton_包长设定_8;
        private System.Windows.Forms.RadioButton radioButton_包长设定_4;
        private System.Windows.Forms.RadioButton radioButton_包长设定_2;
        private System.Windows.Forms.Button button_RevMode;
        private System.Windows.Forms.CheckBox checkBox_包完整模式;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_保存;
        private System.Windows.Forms.Timer timer_文件定时发送;
        private System.Windows.Forms.OpenFileDialog openFileDialog_打开文件;
        private System.Windows.Forms.Timer timer_字符串定时发送;
        private System.Windows.Forms.TabPage tabPage_24L01Send;
        private System.Windows.Forms.RichTextBox richTextBox_Send;
        private System.Windows.Forms.Button button_MouseUp;
        private System.Windows.Forms.TabPage tabPage_24L01Rev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_SendMode;
        private System.Windows.Forms.Button button_MouseDown;
        private System.Windows.Forms.Button button_MouseRight;
        private System.Windows.Forms.Button button_MouseLeft;
        private System.Windows.Forms.TextBox textBox_SendAddr;
        private System.Windows.Forms.TextBox textBox_RevAddress;
        private System.Windows.Forms.Label label_目标地址;
        private System.Windows.Forms.Label label_本机地址;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_MouseRightKeyDown;
        private System.Windows.Forms.Button button_MouseMidKeyDown;
        private System.Windows.Forms.Button button_PageDown;
        private System.Windows.Forms.Button button_PageUp;
        private System.Windows.Forms.Button button_ButtonErase;
        private System.Windows.Forms.Button button_ButtonPaint;
        private System.Windows.Forms.Button button_FullPrint;
        private System.Windows.Forms.Button button_MouseLeftKeyDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox_Rev;
        private System.Windows.Forms.Button button_24L01RevMode;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_RevMouseRight;
        private System.Windows.Forms.Button button_RevMouseMode;
        private System.Windows.Forms.Button button_RevPageDown;
        private System.Windows.Forms.Button button_RevPageUp;
        private System.Windows.Forms.Button button_Erase;
        private System.Windows.Forms.Button button_Paint;
        private System.Windows.Forms.Button button_RevFullPrint;
        private System.Windows.Forms.Button button_RevLeft;
        private System.Windows.Forms.Button button_RevStart;
        private System.Windows.Forms.TabPage tabPage_SiZhou;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_S_roll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_S_yaw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_S_Pitch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_X;

    }
}


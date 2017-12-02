package com.example.zachary.smartopenandroid;

import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.TextView;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketTimeoutException;

public class MainActivity extends AppCompatActivity {
    private Button button_close_monitor;
    private Button button_stop_turnoff;
    private TextView text_message;
    public final int STOPTURNOFF = 0;
    public final int WINLOCK =1;

    class MyThread extends Thread {

        public String txt1;
        private int signal;


        public MyThread(String str,int tmp) {
            txt1 = str;
            signal = tmp;
        }

        @Override
        public void run() {
            //定义消息
            Message msg = new Message();
            msg.what = 0x11;
            Bundle bundle = new Bundle();
            bundle.clear();
            try {
                //连接服务器 并设置连接超时为5秒
                Socket socket = new Socket();
                socket.connect(new InetSocketAddress("192.168.199.176", 50007), 5000);
                //获取输入输出流
                OutputStream ou = socket.getOutputStream();
                //BufferedReader bff = new BufferedReader(new InputStreamReader(
                //        socket.getInputStream()));
                //读取发来服务器信息
                String line = null;
                String buffer="";
                //while ((line = bff.readLine()) != null) {
                //    buffer = line + buffer;
                //}

                //向服务器发送信息
                if (signal==WINLOCK){
                    ou.write("winlock".getBytes());
                }else if(signal==STOPTURNOFF){
                    ou.write("stoplock".getBytes());
                }
                ou.flush();
                bundle.putString("msg", buffer.toString()+txt1);
                msg.setData(bundle);
                //发送消息 修改UI线程中的组件
                myHandler.sendMessage(msg);
                //关闭各种输入输出流
                //bff.close();
                ou.close();
                socket.close();
            } catch (SocketTimeoutException aa) {
                //连接超时 在UI界面显示消息
                bundle.putString("msg", "服务器连接失败！请检查网络是否打开");
                msg.setData(bundle);
                //发送消息 修改UI线程中的组件
                myHandler.sendMessage(msg);
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }

    public Handler myHandler = new Handler() {
        @Override
        public void handleMessage(Message msg) {
            if (msg.what == 0x11) {
                Bundle bundle = msg.getData();
                text_message.append("server:"+bundle.getString("msg")+"\n");
            }
        }

    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        text_message = (TextView)findViewById(R.id.text_msg);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });
        button_close_monitor=(Button)findViewById(R.id.button_close_monitor);
        button_close_monitor.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                new MyThread("send win lock", WINLOCK).start();
            }
        });
        button_stop_turnoff=(Button)findViewById(R.id.button_stop_turnoff_monitor);
        button_stop_turnoff.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                new MyThread("send stop lock",STOPTURNOFF).start();
            }
        });

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}

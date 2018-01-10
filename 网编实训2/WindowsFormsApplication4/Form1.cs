using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
         
          private volatile bool isExit;
          private int port = 8888;
          private UdpClient myUdpClient;

        public Form1()
        {
            isExit = false;
            port = 8888;
            myUdpClient = new UdpClient(port);
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(ReceiveData);
            t.IsBackground = true;
            t.Start();

        }
       private void ReceiveData()
       {
               IPEndPoint iep = null;
              while (!isExit)
            {
                try
                {
                    byte[] bytes = myUdpClient.Receive(ref iep);
                    string message = Encoding.Unicode.GetString(bytes);
                    MessageBox.Show("收到来自" + iep.Address + "的信息：" + message);
                }
                catch
                {
                    MessageBox.Show("停止接收信息！");
                    break;
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            IPAddress remoteIP;
         string message = textBoxMessage.Text; ;
        try
        {
        remoteIP = IPAddress.Parse(textBoxIP.Text);
         }
    catch
   {
        MessageBox.Show("请输入正确的IP地址！");
        return;
    }
    if (message == string.Empty)
    {
        MessageBox.Show("请输入需要发送的信息！");
        return;
    }
   SendData(remoteIP, message);

    }
  private void SendData(IPAddress ip, string message)
{
    try
    {
        IPEndPoint iep = new IPEndPoint(ip, port);
        byte[] bytes = Encoding.Unicode.GetBytes(message);
        myUdpClient.Send(bytes, bytes.Length, iep);
    }
    catch(Exception ex)
    {
        MessageBox.Show(ex.Message + "发送信息失败！");
    }
}

       

        private void 呼叫对方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Show();
        }

        private void 结束程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           isExit = true;
         myUdpClient.Close();
         Application.Exit();

        }
            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (!isExit)
                {
                    e.Cancel = true;
                    this.Hide();
                }

            }

       


    }
}

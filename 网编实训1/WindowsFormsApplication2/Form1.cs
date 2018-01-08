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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void numericUpDownStart1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownEnd1.Value = numericUpDownStart1.Value;
        }

        private void numericUpDownStart2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownEnd2.Value = numericUpDownStart2.Value;
        }

        private void numericUpDownStart3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownEnd3.Value = numericUpDownStart3.Value;
        }

        private void numericUpDownStart4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownEnd4.Value > numericUpDownStart4.Value)
            {
                MessageBox.Show("IP地址区间不正确！");
            }
        }

        private void numericUpDownEnd4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownStart4.Value > numericUpDownEnd4.Value)
            {
                MessageBox.Show("IP地址区间不正确！");
            }
        }

        public void AddResult(string message)
        {
            listBoxStatus.Items.Add(message);
        }
        public delegate void AddResultDelegate(string message);
        private void Scan(string subIP, int start, int end)
        {
            int ipCount = end - start + 1;
            for (int i = 0; i < ipCount; i++)
            {
                string ip = string.Format("{0}.{1}", subIP, start + i);
                try
                {
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip);
                    if (reply.Status == IPStatus.Success)
                    {
                        AddResult("IP地址:" + ip + "状态:扫描成功!");
                    }
                    else
                    {
                        AddResult("IP地址:" + ip + "状态:扫描失败!");
                    }
                }
                catch
                {
                    AddResult("IP地址:" + ip + "状态:扫描失败!");
                }
            }
        }

        private void ScanWithMultiThreads(string subIP, int start, int end)
        {
            int ipCount = end - start + 1;
            for (int i = 0; i < ipCount; i++)
            {
                string ip = string.Format("{0}.{1}", subIP, start + i);
                Thread t = new Thread(CheckComputer);
                t.IsBackground = true;
                t.Start(ip);
            }
        }
        private void CheckComputer(Object obj)
        {
            string ip = obj as string;
            AddResultDelegate d = new AddResultDelegate(AddResult);
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip);
                if (reply.Status == IPStatus.Success)
                {
                    listBoxStatus.Invoke(d, "IP地址:" + ip + "状态:扫描成功!");
                }
                else
                {
                    listBoxStatus.Invoke(d, "IP地址:" + ip + "状态:扫描失败!");
                }
            }
            catch
            {
                listBoxStatus.Invoke(d, "IP地址:" + ip + "状态:扫描失败!");
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            {
                this.Cursor = Cursors.WaitCursor;
                listBoxStatus.Items.Clear();
                string subIP = string.Format("{0}.{1}.{2}"
                    , numericUpDownStart1.Value
                    , numericUpDownStart2.Value
                    , numericUpDownStart3.Value);
                int start = (int)numericUpDownStart4.Value;
                int end = (int)numericUpDownEnd4.Value;
                if (end < start)
                {
                    MessageBox.Show("IP地址区间不正确!");
                }
                if (radioButtonYes.Checked)
                {
                    ScanWithMultiThreads(subIP, start, end);
                }
                else
                {
                    Scan(subIP, start, end);
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
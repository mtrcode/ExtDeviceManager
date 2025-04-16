using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace ExtDeviceManager
{
    public partial class Main : Form
    {
        List<Device> devices = new List<Device>();
        string status = "";
        public Main()
        {
            InitializeComponent();
        }

        private List<Device> GetListOfDevices()
        {
            List<Device> temp = new List<Device>();
            try
            {
                // ������ � WMI ��� ��������� ���������� �� ����������� PnP
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");

                foreach (ManagementObject device in searcher.Get())
                {
                    temp.Add(new Device(device["Name"]?.ToString() ?? "����������� ����������",
                        device["DeviceID"]?.ToString() ?? "��� ID",
                        device["Status"]?.ToString() ?? "����������"));
                }
                status = "";
            }
            catch (Exception ex)
            {
                status = "������ ��� ��������� ������ ���������: " + ex.Message;
            }
            return temp;
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var device in devices)
            {
                listBox1.Items.Add(device.Name + " - " +
                    device.Status + " - " + device.DeviceId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            devices = GetListOfDevices();
            UpdateListBox();
            label4.Text = "����������: " + devices.Count.ToString();
            /*var duplicates = devices
    .GroupBy(d => d)
    .Where(g => g.Count() > 1)
    .SelectMany(g => g)
    .ToList();
            string message = "";
            if (duplicates.Count > 0)
            {
                message = "���������� ��������� ���������:";
                foreach (var device in duplicates)
                {
                    message += "\n" + device.Name + " - " +
                        device.Status + " - " + device.DeviceId;
                }
            }
            else
            {
                message = "��������� �� ����������";
            }
            MessageBox.Show(message, "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void testAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width == 834 ? 336 : 834, 570);
        }

        private string GetTime()
        {
            DateTime now = DateTime.Now;
            return now.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "������ ������������")
            {
                button2.Text = "��������� ������������";
                timer1.Interval = Convert.ToInt32(numericUpDown1.Value);
                richTextBox1.Clear();
                richTextBox1.Text = GetTime() + " : ������ ������������";
                timer1.Enabled = true;
            }
            else
            {
                button2.Text = "������ ������������";
                richTextBox1.Text += "\n" + GetTime() + " : ��������� ������������";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Device> temp = GetListOfDevices();
            if (status != "")
                richTextBox1.Text += "\n" + GetTime() + " : " + status;
            else
            {
                List<Device> newD = new List<Device>();
                List<Device> remD = new List<Device>();
                if (newDevices_checkBox.Checked)
                {
                    foreach (var device in temp)
                        if (!devices.Contains(device))
                            newD.Add(device);

                    if (newD.Count > 0)
                    {
                        richTextBox1.Text += "\n" + GetTime() + " : ���������� ����� ���������� (" + newD.Count + "):";
                        int c = 1;
                        foreach (var device in newD)
                        {
                            richTextBox1.Text += "\n" + " +" + c + device.Name + " - " +
                                device.Status + " - " + device.DeviceId;
                        }
                    }
                }
                if (removeDevice_checkBox.Checked)
                {
                    foreach (var device in devices)
                        if (!temp.Contains(device))
                            remD.Add(device);
                    if (remD.Count > 0)
                    {
                        richTextBox1.Text += "\n" + GetTime() + " : ������� ���������� (" + remD.Count + "):";
                        int c = 1;
                        foreach (var device in remD)
                        {
                            richTextBox1.Text += "\n" + " -" + c + device.Name + " - " +
                                device.Status + " - " + device.DeviceId;
                        }
                    }
                }
                devices.Clear();
                foreach (var device in temp)
                    devices.Add(device);
                temp.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            MessageBox.Show("��� ���������� � ����� ������", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }
    }
}
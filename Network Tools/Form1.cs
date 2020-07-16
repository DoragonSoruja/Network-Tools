using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WhoIsButton_Click(object sender, EventArgs e)
        {
            WhoIsGroupBox.Visible = true;
            WhoIsGroupBox.BringToFront();
            portScannerGroupBox.Visible = false;
        }

        private void PortScannerButton_Click(object sender, EventArgs e)
        {
            WhoIsGroupBox.Visible = false;
            portScannerGroupBox.Visible = true;
            portScannerGroupBox.BringToFront();
        }

        ///////////////////////
        // WhoIs Methods
        ///////////////////////
        public static void LookUp(string database, string website, RichTextBox resultLabel)
        {
            try
            {
                TcpClient client = new TcpClient(database, 43);
                Stream site = client.GetStream();
                byte[] domain = Encoding.ASCII.GetBytes(website + "\n");
                site.Write(domain, 0, website.Length + 1);
                StreamReader reader = new StreamReader(client.GetStream(), Encoding.ASCII);
                resultLabel.Text = reader.ReadToEnd();
            }
            catch (Exception)
            {
                resultLabel.Clear();
                MessageBox.Show("An Error has occurred! Either the domain doesn't exist or is denying access.");
            }
        }

        private void WhoIsSearchButton_Click(object sender, EventArgs e)
        {
            WhoIsResultBox.Clear();
            string database = "whois.iana.org";

            TcpClient client = new TcpClient(database, 43);
            Stream site = client.GetStream();
            byte[] domain = Encoding.ASCII.GetBytes(addressBox.Text + "\n");
            site.Write(domain, 0, addressBox.Text.Length + 1);
            StreamReader reader = new StreamReader(client.GetStream(), Encoding.ASCII);

            bool startWriting = false;
            database = "";
            int counter = 0;

            foreach (char x in reader.ReadToEnd())
            {
                if (startWriting == true && counter == 2)
                {
                    if (x == '\n')
                    {
                        break;
                    }
                    else
                    {
                        database += x;
                    }
                }
                if (x == ':')
                {
                    startWriting = true;
                    counter++;
                }
            }

            try
            {
                LookUp(database.Trim(), addressBox.Text, WhoIsResultBox);
            }
            catch (Exception)
            {
                MessageBox.Show("This program doesn't support that TLD");
            }

            if (WhoIsResultBox.Text.Contains("Registrar WHOIS Server"))
            {
                database = "";
                int colon = 0;
                foreach (char x in WhoIsResultBox.Text)
                {
                    if (colon == 3)
                    {
                        if (x == '\n')
                            break;
                        database += x;
                    }

                    if (x == ':')
                        colon++;
                }
                WhoIsResultBox.Clear();
                LookUp(database.Trim(), addressBox.Text, WhoIsResultBox);
            }
        }

        private void WhoIsAddressBox_Enter(object sender, EventArgs e)
        {
            if (addressBox.Text == "Ex: google.com")
            {
                addressBox.Text = "";
                addressBox.ForeColor = Color.Black;
            }
        }

        private void WhoIsAddressBox_Leave(object sender, EventArgs e)
        {
            if (addressBox.Text == "")
            {
                addressBox.Text = "Ex: google.com";
                addressBox.ForeColor = Color.Silver;
            }
        }

        ///////////////////////
        // Port Scanner Methods
        ///////////////////////
        private void portScan(object sender, EventArgs eventArgs)
        {
            scanProgress.Value = 0;
            scanProgress.Visible = true;
            Cursor = Cursors.WaitCursor;
            portList.Items.Clear();

            if (inputIP.Text.Trim() == "" || inputIP.Text == "Ex: 192.168.1.1")
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Enter in a valid IP address.");
                return;
            }

            if (port1.Text.Trim() == "")
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Enter a port number.");
                return;
            }

            int firstPort = int.Parse(port1.Text);

            try
            {
                TcpClient client = new TcpClient();
                if (singlePorting.Checked)
                {
                    client.Connect(inputIP.Text.ToString(), firstPort);
                    portStatus(firstPort, true);
                }
                else
                {
                    int progress = 100 / (int.Parse(port2.Text) - firstPort);
                    for (int x = firstPort; x <= int.Parse(port2.Text); x++)
                    {
                        TcpClient secondClient = new TcpClient();
                        var connect = secondClient.BeginConnect(inputIP.Text.ToString(), x, null, null);

                        if (connect.AsyncWaitHandle.WaitOne(100))
                        {
                            portStatus(x, true);
                        }
                        else
                        {
                            portStatus(x, false);
                        }
                        scanProgress.Value += progress;
                    }
                }
            }
            catch (Exception)
            {
                if (singlePorting.Checked) { portStatus(firstPort, false); }
            }

            scanProgress.Value = 100;
            Cursor = Cursors.Default;
            //scanProgress.Visible = false;
        }

        private void singlePortCheck(object sender, EventArgs e)
        {
            if (singlePorting.Checked)
            {
                label3.Visible = false;
                port2.Visible = false;
            }
            else
            {
                label3.Visible = true;
                port2.Visible = true;
            }
        }

        private void portStatus(int portNum, bool opened)
        {
            if (opened)
            {
                portList.Items.Add(new ListViewItem(new string[] { portNum.ToString(), "Open" }));
            }
            else
            {
                portList.Items.Add(new ListViewItem(new string[] { portNum.ToString(), "Closed" }));
            }
        }

        private void PorScannerInputIP_Enter(object sender, EventArgs e)
        {
            if (inputIP.Text == "Ex: 192.168.1.1")
            {
                inputIP.Text = "";
                inputIP.ForeColor = Color.Black;
            }
        }

        private void PortScannerInputIP_Leave(object sender, EventArgs e)
        {
            if (inputIP.Text == "")
            {
                inputIP.Text = "Ex: 192.168.1.1";
                inputIP.ForeColor = Color.Silver;
            }
        }
    }
}

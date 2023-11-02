using System.Net;
using System.Net.Sockets;
using SimpleTCP;

namespace Client
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client = new SimpleTcpClient();

        public Form1()
        {
            InitializeComponent();
            textBox_ip.Text = "10.30.1.53";
            textBox_port.Text = "5000";
            button_odpojit.Enabled = false;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object? sender, SimpleTCP.Message e)
        {
            string msg = e.MessageString.Remove(e.MessageString.Length - 1);
            richTextBox_msgs.Text += $"{msg}";
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (Pripoj())
            {
                button_connect.Enabled = false;
                button_odpojit.Enabled = true;
            }
            else
            {
                throw new Exception("Nepodaøilo se pøipojit");
            }
        }

        private bool Pripoj()
        {
            client.Connect(textBox_ip.Text, Int32.Parse(textBox_port.Text));
            return true;
        }

        private void button_odpojit_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            button_connect.Enabled = true;
            button_odpojit.Enabled = false;

        }

        private void richTextBox_msg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SendMsg();
            }
        }

        private void SendMsg()
        {
            client.WriteLineAndGetReply(richTextBox_msg.Text, TimeSpan.FromSeconds(1));
            richTextBox_msg.Clear();
        }
    }
}
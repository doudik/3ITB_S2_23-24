using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            newClient:
            if (tcpClient != null)
            {
                tcpClient.Connect(IPAddress.Parse(textBox_ip.Text), Int32.Parse(textBox_port.Text));
            }
            else {
                tcpClient = new TcpClient();
                goto newClient;
            }
        }

        private void button_odpojit_Click(object sender, EventArgs e)
        {
            tcpClient.Close();
        }
    }
}
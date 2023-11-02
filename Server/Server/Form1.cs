namespace Server
{
    using SimpleTCP;
    using SimpleTCP.Server;
    using System.Net;
    using System.Net.Sockets;

    public partial class Form1 : Form
    {
        SimpleTcpServer server;

        public Form1()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            //Vypnuté tlaèítko pøi zapnutí formu
            server = new SimpleTcpServer();
            button_stop.Enabled = false;
            textBox_ip.Text = "10.30.1.53";
            textBox_port.Text = "5000";
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
            server.DataReceived += Server_DataReceived;
        }


        private void Server_DataReceived(object? sender, Message e)
        {
            string msg = e.MessageString.Remove(e.MessageString.Length - 1);
            richTextBox_chat.Text += $"{e.TcpClient.Client.RemoteEndPoint.ToString()}: {msg}";
            server.BroadcastLine($"{e.TcpClient.Client.RemoteEndPoint.ToString()}: {msg}");
        }

        private void Server_ClientDisconnected(object? sender, TcpClient e)
        {
            foreach (var item in listBox1.Items)
            {
                if (item == e.Client.RemoteEndPoint.ToString())
                {
                    listBox1.Items.Remove(item);
                    listBox1.Refresh();
                    break;
                }
            }
        }

        private void Server_ClientConnected(object? sender, System.Net.Sockets.TcpClient e)
        {

            listBox1.Items.Add(e.Client.RemoteEndPoint.ToString());
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (server != null)
            {

                try
                {
                    IPAddress ip = IPAddress.Parse(textBox_ip.Text);
                    server.Start(ip, getPort());
                    button_start.Enabled = false;
                    button_stop.Enabled = true;
                    richTextBox_log.Text += $"\nServer {ip}:{getPort()} byl spuštìn";
                }
                catch (Exception)
                {
                    MessageBox.Show($"Neplatná IP adresa èi port ");
                }
            }
        }

        private int getPort()
        {
            try
            {
                return Int32.Parse(textBox_port.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Chybný port!");
                return -1;
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_start.Enabled = true;
            button_stop.Enabled = false;
            server.Stop();
            richTextBox_log.Text += "\n Zastavuji server..";
        }
    }
}
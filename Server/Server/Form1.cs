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
            textBox_ip.Text = "10.20.10.163";
            textBox_port.Text = "5000";
            server.ClientConnected += Server_ClientConnected;
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
                    label_log.Text += $"\nServer {ip}:{getPort()} byl spuštìn";
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
            label_log.Text += "\n Zastavuji server..";
        }
    }
}
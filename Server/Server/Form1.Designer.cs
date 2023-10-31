namespace Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_stop = new Button();
            button_start = new Button();
            listBox1 = new ListBox();
            textBox_ip = new TextBox();
            label_ip = new Label();
            label_connectedClients = new Label();
            label_port = new Label();
            textBox_port = new TextBox();
            label_log = new Label();
            SuspendLayout();
            // 
            // button_stop
            // 
            button_stop.Location = new Point(12, 409);
            button_stop.Name = "button_stop";
            button_stop.Size = new Size(94, 29);
            button_stop.TabIndex = 0;
            button_stop.Text = "Stop";
            button_stop.UseVisualStyleBackColor = true;
            button_stop.Click += button_stop_Click;
            // 
            // button_start
            // 
            button_start.Location = new Point(138, 409);
            button_start.Name = "button_start";
            button_start.Size = new Size(94, 29);
            button_start.TabIndex = 1;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 244);
            listBox1.TabIndex = 2;
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(49, 24);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(194, 27);
            textBox_ip.TabIndex = 3;
            // 
            // label_ip
            // 
            label_ip.AutoSize = true;
            label_ip.Location = new Point(8, 31);
            label_ip.Name = "label_ip";
            label_ip.Size = new Size(24, 20);
            label_ip.TabIndex = 4;
            label_ip.Text = "IP:";
            // 
            // label_connectedClients
            // 
            label_connectedClients.AutoSize = true;
            label_connectedClients.Location = new Point(61, 131);
            label_connectedClients.Name = "label_connectedClients";
            label_connectedClients.Size = new Size(112, 20);
            label_connectedClients.TabIndex = 5;
            label_connectedClients.Text = "Připojení klienti";
            label_connectedClients.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_port
            // 
            label_port.AutoSize = true;
            label_port.Location = new Point(8, 64);
            label_port.Name = "label_port";
            label_port.Size = new Size(38, 20);
            label_port.TabIndex = 7;
            label_port.Text = "Port:";
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(49, 61);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(194, 27);
            textBox_port.TabIndex = 6;
            // 
            // label_log
            // 
            label_log.AutoSize = true;
            label_log.BackColor = SystemColors.ButtonHighlight;
            label_log.Location = new Point(269, 141);
            label_log.MinimumSize = new Size(250, 300);
            label_log.Name = "label_log";
            label_log.Size = new Size(250, 300);
            label_log.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(label_log);
            Controls.Add(label_port);
            Controls.Add(textBox_port);
            Controls.Add(label_connectedClients);
            Controls.Add(label_ip);
            Controls.Add(textBox_ip);
            Controls.Add(listBox1);
            Controls.Add(button_start);
            Controls.Add(button_stop);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_stop;
        private Button button_start;
        private ListBox listBox1;
        private TextBox textBox_ip;
        private Label label_ip;
        private Label label_connectedClients;
        private Label label_port;
        private TextBox textBox_port;
        private Label label_log;
    }
}
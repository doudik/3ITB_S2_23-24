namespace Client
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
            textBox_ip = new TextBox();
            label_ip = new Label();
            label_port = new Label();
            textBox_port = new TextBox();
            button_odpojit = new Button();
            button_connect = new Button();
            richTextBox_msgs = new RichTextBox();
            richTextBox_msg = new RichTextBox();
            SuspendLayout();
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(114, 102);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(191, 27);
            textBox_ip.TabIndex = 0;
            // 
            // label_ip
            // 
            label_ip.AutoSize = true;
            label_ip.Location = new Point(20, 105);
            label_ip.Name = "label_ip";
            label_ip.Size = new Size(24, 20);
            label_ip.TabIndex = 1;
            label_ip.Text = "IP:";
            // 
            // label_port
            // 
            label_port.AutoSize = true;
            label_port.Location = new Point(20, 148);
            label_port.Name = "label_port";
            label_port.Size = new Size(38, 20);
            label_port.TabIndex = 3;
            label_port.Text = "Port:";
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(114, 145);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(191, 27);
            textBox_port.TabIndex = 2;
            // 
            // button_odpojit
            // 
            button_odpojit.Location = new Point(20, 204);
            button_odpojit.Name = "button_odpojit";
            button_odpojit.Size = new Size(111, 29);
            button_odpojit.TabIndex = 4;
            button_odpojit.Text = "Odpojit se";
            button_odpojit.UseVisualStyleBackColor = true;
            button_odpojit.Click += button_odpojit_Click;
            // 
            // button_connect
            // 
            button_connect.Location = new Point(189, 204);
            button_connect.Name = "button_connect";
            button_connect.Size = new Size(116, 29);
            button_connect.TabIndex = 5;
            button_connect.Text = "Připojit se";
            button_connect.UseVisualStyleBackColor = true;
            button_connect.Click += button_connect_Click;
            // 
            // richTextBox_msgs
            // 
            richTextBox_msgs.Location = new Point(329, 12);
            richTextBox_msgs.Name = "richTextBox_msgs";
            richTextBox_msgs.Size = new Size(322, 263);
            richTextBox_msgs.TabIndex = 6;
            richTextBox_msgs.Text = "";
            // 
            // richTextBox_msg
            // 
            richTextBox_msg.Location = new Point(329, 292);
            richTextBox_msg.Name = "richTextBox_msg";
            richTextBox_msg.Size = new Size(322, 50);
            richTextBox_msg.TabIndex = 7;
            richTextBox_msg.Text = "";
            richTextBox_msg.KeyPress += richTextBox_msg_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 354);
            Controls.Add(richTextBox_msg);
            Controls.Add(richTextBox_msgs);
            Controls.Add(button_connect);
            Controls.Add(button_odpojit);
            Controls.Add(label_port);
            Controls.Add(textBox_port);
            Controls.Add(label_ip);
            Controls.Add(textBox_ip);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ip;
        private Label label_ip;
        private Label label_port;
        private TextBox textBox_port;
        private Button button_odpojit;
        private Button button_connect;
        private RichTextBox richTextBox_msgs;
        private RichTextBox richTextBox_msg;
    }
}
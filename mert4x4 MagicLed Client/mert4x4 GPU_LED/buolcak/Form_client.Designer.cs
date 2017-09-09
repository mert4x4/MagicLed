using System;
using System.Windows.Forms;

namespace buolcak
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_status = new System.Windows.Forms.Label();
            this.label_IpAdress = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_IpAdress = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_gpu = new System.Windows.Forms.CheckBox();
            this.checkBox_cpu = new System.Windows.Forms.CheckBox();
            this.checkBox_sendToServer = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_SendToLogitech = new System.Windows.Forms.CheckBox();
            this.label_spotify = new System.Windows.Forms.Label();
            this.checkBox_SpotifyLights = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPU Core :0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(9, 7);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(106, 13);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Waiting to connect...";
            // 
            // label_IpAdress
            // 
            this.label_IpAdress.AutoSize = true;
            this.label_IpAdress.Location = new System.Drawing.Point(10, 250);
            this.label_IpAdress.Name = "label_IpAdress";
            this.label_IpAdress.Size = new System.Drawing.Size(54, 13);
            this.label_IpAdress.TabIndex = 2;
            this.label_IpAdress.Text = "IpAdress :";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(32, 284);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(32, 13);
            this.label_port.TabIndex = 3;
            this.label_port.Text = "Port :";
            // 
            // textBox_IpAdress
            // 
            this.textBox_IpAdress.Location = new System.Drawing.Point(70, 247);
            this.textBox_IpAdress.Name = "textBox_IpAdress";
            this.textBox_IpAdress.Size = new System.Drawing.Size(93, 20);
            this.textBox_IpAdress.TabIndex = 4;
            this.textBox_IpAdress.Text = "192.168.0.12";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(70, 281);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(93, 20);
            this.textBox_port.TabIndex = 5;
            this.textBox_port.Text = "80";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(14, 37);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(74, 53);
            this.button_connect.TabIndex = 6;
            this.button_connect.Text = "CONNECT";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(252, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "mert4x4 GPU_LED client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "RAM Usage: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sending Values(GPU-CPU) : ";
            // 
            // checkBox_gpu
            // 
            this.checkBox_gpu.AutoSize = true;
            this.checkBox_gpu.Checked = true;
            this.checkBox_gpu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_gpu.Location = new System.Drawing.Point(141, 37);
            this.checkBox_gpu.Name = "checkBox_gpu";
            this.checkBox_gpu.Size = new System.Drawing.Size(49, 17);
            this.checkBox_gpu.TabIndex = 10;
            this.checkBox_gpu.Text = "GPU";
            this.checkBox_gpu.UseVisualStyleBackColor = true;
            // 
            // checkBox_cpu
            // 
            this.checkBox_cpu.AutoSize = true;
            this.checkBox_cpu.Location = new System.Drawing.Point(196, 37);
            this.checkBox_cpu.Name = "checkBox_cpu";
            this.checkBox_cpu.Size = new System.Drawing.Size(48, 17);
            this.checkBox_cpu.TabIndex = 11;
            this.checkBox_cpu.Text = "CPU";
            this.checkBox_cpu.UseVisualStyleBackColor = true;
            // 
            // checkBox_sendToServer
            // 
            this.checkBox_sendToServer.AutoSize = true;
            this.checkBox_sendToServer.Location = new System.Drawing.Point(250, 37);
            this.checkBox_sendToServer.Name = "checkBox_sendToServer";
            this.checkBox_sendToServer.Size = new System.Drawing.Size(56, 17);
            this.checkBox_sendToServer.TabIndex = 12;
            this.checkBox_sendToServer.Text = "SEND";
            this.checkBox_sendToServer.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "mert4x4\'s GPU-CPU LED";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 200;
            this.trackBar1.Location = new System.Drawing.Point(236, 222);
            this.trackBar1.Maximum = 1500;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(134, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Timer_interval: 1000";
            // 
            // checkBox_SendToLogitech
            // 
            this.checkBox_SendToLogitech.AutoSize = true;
            this.checkBox_SendToLogitech.Location = new System.Drawing.Point(14, 222);
            this.checkBox_SendToLogitech.Name = "checkBox_SendToLogitech";
            this.checkBox_SendToLogitech.Size = new System.Drawing.Size(105, 17);
            this.checkBox_SendToLogitech.TabIndex = 15;
            this.checkBox_SendToLogitech.Text = "SendToLogitech";
            this.checkBox_SendToLogitech.UseVisualStyleBackColor = true;
            // 
            // label_spotify
            // 
            this.label_spotify.AutoSize = true;
            this.label_spotify.Location = new System.Drawing.Point(105, 200);
            this.label_spotify.Name = "label_spotify";
            this.label_spotify.Size = new System.Drawing.Size(29, 13);
            this.label_spotify.TabIndex = 16;
            this.label_spotify.Text = "false";
            // 
            // checkBox_SpotifyLights
            // 
            this.checkBox_SpotifyLights.AutoSize = true;
            this.checkBox_SpotifyLights.Location = new System.Drawing.Point(14, 199);
            this.checkBox_SpotifyLights.Name = "checkBox_SpotifyLights";
            this.checkBox_SpotifyLights.Size = new System.Drawing.Size(92, 17);
            this.checkBox_SpotifyLights.TabIndex = 17;
            this.checkBox_SpotifyLights.Text = "SpotifyLights :";
            this.checkBox_SpotifyLights.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(376, 314);
            this.Controls.Add(this.checkBox_SpotifyLights);
            this.Controls.Add(this.label_spotify);
            this.Controls.Add(this.checkBox_SendToLogitech);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox_sendToServer);
            this.Controls.Add(this.checkBox_cpu);
            this.Controls.Add(this.checkBox_gpu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_IpAdress);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_IpAdress);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.Text = "Mert4x4-MagicLed";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_IpAdress;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_IpAdress;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_gpu;
        private System.Windows.Forms.CheckBox checkBox_cpu;
        private System.Windows.Forms.CheckBox checkBox_sendToServer;
        private NotifyIcon notifyIcon1;
        private TrackBar trackBar1;
        private Label label5;
        private CheckBox checkBox_SendToLogitech;
        private Label label_spotify;
        private CheckBox checkBox_SpotifyLights;
        private System.IO.Ports.SerialPort serialPort1;
    }
}


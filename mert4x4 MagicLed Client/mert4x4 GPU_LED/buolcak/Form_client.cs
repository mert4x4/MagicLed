using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using System.Net.Sockets;
using LedCSharp;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace buolcak
{
    public partial class Form_main : Form
    {
        bool flag = false;
        string GPU_temp;
        string CPU_temp;

        bool show = false;

        string Spotify1;
        string Spotify2;
        bool Spotify_changeState = false;
        public Form_main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;

            Spotify1 = GetSpotifyTrackInfo(true);
            Spotify2 = GetSpotifyTrackInfo(true);
        }
        public string GetSpotifyTrackInfo(bool getsong)
        {
            var proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null)
            {
                return "Spotify is not running!";
            }

            if (string.Equals(proc.MainWindowTitle, "Spotify", StringComparison.InvariantCultureIgnoreCase))
            {
                return "Paused";
            }
            string[] GottenArray = proc.MainWindowTitle.Split('-');

            if (getsong == true)
            {
                return GottenArray[1];
            }
            else
            {
                return GottenArray[0];
            }
        }

        private void SendToLogitechMouse(byte temperature)
        {
            try {
                if (temperature >= 0 && temperature <= 40)
                    LogitechGSDK.LogiLedSetLighting(0, 0, 100); //blue

                if (temperature >= 41 && temperature <= 49)
                    LogitechGSDK.LogiLedSetLighting(0, 100, 100); //aqua

                if (temperature >= 50 && temperature <= 59)
                    LogitechGSDK.LogiLedSetLighting(0, 100, 0);     //green

                if (temperature >= 60 && temperature <= 65)
                    LogitechGSDK.LogiLedSetLighting(100, 100, 0); //yellow

                if (temperature >= 66 && temperature <= 71)
                    LogitechGSDK.LogiLedSetLighting(100, 0, 0); //red

                if (temperature >= 72 && temperature <= 255)
                    LogitechGSDK.LogiLedSetLighting(100, 0, 100);   //purple
            }
            catch
            {
                MessageBox.Show("LogitechLedEnginesWrapper.dll does not exist");
            }
            
        }
        void Send(string text)
        {
            try
            {
                String IpAdress = Convert.ToString(textBox_IpAdress.Text);
                int port = int.Parse(textBox_port.Text);

                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                s.Connect(IpAdress, port);
                Byte[] buffer = Encoding.ASCII.GetBytes(text);
                s.Send(buffer);
                s.Close();
                label_status.Text = "CONNECTED TO SERVER!";
                label_status.ForeColor = System.Drawing.Color.LimeGreen;
                notifyIcon1.Text = ("GPU : " + GPU_temp + "    CPU: " + CPU_temp + "  sending to server!");
            }
            catch
            {
                label_status.Text = "COULD NOT CONNECT TO SERVER...";
                label_status.ForeColor = System.Drawing.Color.OrangeRed;
                notifyIcon1.Text = ("GPU : " + GPU_temp + "    CPU: " + CPU_temp + "  can't send to server!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox_SpotifyLights.Checked == true)
            {
                Spotify1 = GetSpotifyTrackInfo(true);

                if (Spotify1 != Spotify2)
                {
                    Spotify_changeState = true;
                }
                else
                {
                    Spotify_changeState = false;
                }

                Spotify2 = GetSpotifyTrackInfo(true);
                label_spotify.Text = Convert.ToString(Spotify_changeState);
            }

            if (flag == true)
            {      
                Computer c = new Computer()
                {
                    GPUEnabled = true,
                    RAMEnabled = true,
                };
                c.Open();
                foreach (var Hardware in c.Hardware)
                {
                    if (Hardware.HardwareType == HardwareType.GpuNvidia)
                    {
                        Hardware.Update();
                        foreach (var sensor in Hardware.Sensors)
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                if (checkBox_gpu.Checked == true)
                                {
                                    GPU_temp = Convert.ToString(sensor.Value);
                                    label1.Text = (Convert.ToString(sensor.Name + " :" + sensor.Value.GetValueOrDefault()));
                                    if (Spotify_changeState == true)
                                    {
                                        GPU_temp = "201";
                                    }
                                }
                                else
                                {
                                    GPU_temp = "0";
                                    label1.Text = (Convert.ToString(sensor.Name + " :" + sensor.Value.GetValueOrDefault()));
                                    if (Spotify_changeState == true)
                                    {
                                        GPU_temp = "201";
                                    }
                                }
                            }                      
                    }
                    if (Hardware.HardwareType == HardwareType.RAM)
                    {
                        Hardware.Update();
                        foreach (var sensorCPU in Hardware.Sensors)
                            if (sensorCPU.SensorType == SensorType.Load)
                            {
                                if (checkBox_cpu.Checked == true)
                                {
                                    string ramtemp = Convert.ToString(sensorCPU.Value);
                                    string[] mert = ramtemp.Split(',');

                                    CPU_temp = mert[0];
                                    label3.Text = (Convert.ToString(sensorCPU.Name + " :" + sensorCPU.Value.GetValueOrDefault()));
                                }
                                else
                                {
                                    CPU_temp = "0";
                                    label3.Text = (Convert.ToString(sensorCPU.Name + " :" + sensorCPU.Value.GetValueOrDefault()));
                                }
                            }
                    }
                }

                if (flag)
                {

                    if (checkBox_sendToServer.Checked == true)
                    {
                            label4.Text = ("Sending Values(GPU-CPU): " + GPU_temp + " " + CPU_temp);
                            Send(GPU_temp + " " + CPU_temp);
                    }
                    else
                    {
                            label4.Text = ("Sending Values(GPU-CPU): ");
                            notifyIcon1.Text = ("GPU : " + GPU_temp + "    CPU: " + CPU_temp);
                    }
                    if (checkBox_SendToLogitech.Checked == true)
                    {
                        try
                        {
                            LogitechGSDK.LogiLedInit();
                            SendToLogitechMouse(Convert.ToByte(GPU_temp));
                        }

                        catch
                        {
                            MessageBox.Show("LogitechLedEnginesWrapper.dll does not exist");
                        }

                    }
                    else
                    {
                        try
                        {
                            LogitechGSDK.LogiLedShutdown();
                        }

                        catch
                        {
                            MessageBox.Show("LogitechLedEnginesWrapper.dll does not exist");
                        }
                    }
                }
            }           
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (show == true)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                show = false;
            }
            else if(show == false)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;                          
                show = true;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label5.Text = Convert.ToString("Timer_interval :" + trackBar1.Value);
        }
    }
}

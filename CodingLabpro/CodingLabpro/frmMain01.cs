using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivi.Visa.Interop;
using Ivi.Visa.FormattedIO;
using Ivi.Visa;
using System.IO;
using System.IO.Ports;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using System.Runtime.InteropServices;
using NPOI.SS.Formula.Eval;
using CodingLabpro.CommandDevice;
using System.Windows.Forms.DataVisualization.Charting;


namespace CodingLabpro
{
    public partial class frmMain01 : Form
    {
        Ivi.Visa.Interop.FormattedIO488 MyDMM;
        Ivi.Visa.Interop.FormattedIO488 MyMMC;
        SerialPort mySerialPort = new SerialPort();

        private DateTime r = DateTime.Now;
        private bool isRunning = false;
        private bool StatusPort;
        private int Clickcount = 0;


        public frmMain01()
        {
            InitializeComponent();
            this.Text = "Aglient 34401A And MMC-2 Axis Controller";
            this.SetStyle(
                        ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            //Control Panel 
            BtnDiconnect.Enabled = false;
            BtnConnect.Enabled = true;
            timer1.Enabled = false;
          

            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            MyDMM = new Ivi.Visa.Interop.FormattedIO488();
            MyMMC = new Ivi.Visa.Interop.FormattedIO488();
          

            //Port GPIB
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();

           


            //Find Device
            FindDevices finder = new FindDevices();
            finder.OnDeviceFound += (device) =>
            {
                Cblistaddress.Items.Add(device);
                Cblistaddress2.Items.Add(device);
            };
            finder.FDevice(); // Find devices from Port GPIB

            finder.OnDeviceFound1 += (device1) => { Cblistaddress3.Items.Add(device1); };
            finder.RSdevice(); // Find devices form Port RS232


            //chart Data DC Measura
            Chartmeasure();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Tick += new EventHandler();
            timer1.Interval = 1000;
        }

        public void Chartmeasure()
        {
            chart1.Series["Series1"].Points.AddXY(10, 2);
            chart1.Series["Series1"].ChartType = SeriesChartType.Line;
        
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 10;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 10;

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Timer";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Voltage";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleForeColor = Color.White;
            chart1.ChartAreas["ChartArea1"].AxisY.TitleForeColor = Color.White;
            chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Cascadia Mono", 10, FontStyle.Regular);
            chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Cascadia Mono", 10, FontStyle.Regular);


            //chart1.ChartAreas["ChartArea1"].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            //chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "mm:ss";





        }

        public void ChartUpdateValue()
        {
           
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // วาดพื้นหลังแบบ Gradient
            Rectangle rect = this.ClientRectangle;
            using (var brush = new LinearGradientBrush(rect,
                                                       Color.FromArgb(81, 34, 90), // สีบน
                                                       Color.FromArgb(43, 50, 87),  // สีล่าง
                                                       LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        public class COMException : System.Runtime.InteropServices.ExternalException
        {

        }

        private void frmMain01_SizeChanged(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                labelName.Font = new Font(labelName.Font.FontFamily, 12);
                Cblistaddress.Size = new Size(280, 29);
                Cblistaddress2.Size = new Size(280, 29);
                Cblistaddress3.Size = new Size(280, 29);

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                labelName.Font = new Font(labelName.Font.FontFamily, 18);
                Cblistaddress.Size = new Size(380, 29);
                Cblistaddress2.Size = new Size(380, 29);
                Cblistaddress3.Size = new Size(380, 29);

            }

        }

        public void Statusbar()
        {
            if (StatusPort == true)
            {
                StatusPort1.BackColor = Color.LightGreen;
                StatusPort2.BackColor = Color.LightGreen;
                StatusPort3.BackColor = Color.LightGreen;

                StatusPort1.Text = "CONNECT";
                StatusPort2.Text = "CONNECT";
                StatusPort3.Text = "CONNECT";

                BtnConnect.Enabled = false;
                BtnDiconnect.Enabled = true;

            }else if (StatusPort == false)
            {

                StatusPort1.BackColor = Color.Red;
                StatusPort2.BackColor = Color.Red;
                StatusPort3.BackColor = Color.Red;

                StatusPort1.Text = "DiCONNECT";
                StatusPort2.Text = "DiCONNECT";
                StatusPort3.Text = "DiCONNECT";

                BtnConnect.BackColor = Color.Transparent;
                BtnConnect.Text = "CONNECT";
                BtnConnect.ForeColor = Color.White;

                BtnConnect.Enabled = true;
                BtnDiconnect.Enabled = false;
            }
         
        }

    
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //CONNECT DMM
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();

            //CONNECT MMC
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            // ตรวจสอบการเลือกพอร์ตการเชื่อมว่าครบไหม ทั้ง 3 อุปกรณ์
            if ( Cblistaddress3.SelectedIndex == -1)
            {
                MessageBox.Show("you Should Select Port Device");
                BtnConnect.BackColor = Color.Orange;
                BtnConnect.Text = "Warning";
                BtnConnect.ForeColor = Color.White;

            }
            else
            {
                try
                {
                    //CONNECT driver DMM Port GP - IB
                    string addr = Cblistaddress.SelectedItem.ToString();
                    MyDMM.IO = (IMessage)mgr1.Open(addr, AccessMode.NO_LOCK, 2000, null);
                    MyDMM.IO.Timeout = 2000;
                    string command = "*IDN?";
                    MyDMM.WriteString(command);
                    string Aread = MyDMM.ReadString();
                    MyDMM.WriteString(Aread);
                    textread.AppendText(Aread + Environment.NewLine);
                    MyDMM.WriteString("*CLS");

                    //CONNECT driver MMC Port GP-IB
                    string MMCaddr = Cblistaddress2.SelectedItem.ToString();
                    MyMMC.IO = (IMessage)mgr2.Open(MMCaddr);
                    string MSG = "H:W";
                    MyMMC.WriteString(MSG);

                    //Port RS232 Setting
                    mySerialPort.PortName = "COM7";
                    mySerialPort.BaudRate = 9600; // ตั้งค่า Baud Rate
                    mySerialPort.Parity = Parity.None; // ตั้งค่า Parity
                    mySerialPort.StopBits = StopBits.One; // ตั้งค่า Stop Bits
                    mySerialPort.DataBits = 8; // ตั้งค่าจำนวน Data Bits
                    mySerialPort.Handshake = Handshake.None; // ตั้งค่า Handshake


                    //CONNET driver MMC Port RS-232
                    mySerialPort.Open();
                    mySerialPort.WriteLine("H:X");

                    //Show is connect DMM 
                    MessageBox.Show("Device is connect", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                    BtnConnect.Text = "Remote";
                    BtnConnect.BackColor = Color.LightGreen;
                    string rectify1 = "Remote Agilent HP34401A and MMC Step motor! By Port GPIB";
                    textread.AppendText(r.ToString("r") + " <Notification!> " + rectify1 + Environment.NewLine);

                    //return value bool statusPort
                    StatusPort = true;

                    //MainStatusBar
                    Statusbar();
                   
                }
                catch (Exception ex)
                {
                    BtnConnect.BackColor = Color.Red;
                    BtnConnect.Text = "Unconnect";
                    BtnConnect.ForeColor = Color.White;
                    string incorrectness1 = "Cannot Find driver Agilent Muitimeter and MMC Step motor!";
                    MessageBox.Show("Device session is not connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textread.AppendText(">>" + r.ToString("r") + " <Notification!> " + incorrectness1 + Environment.NewLine +
                                        ex.Message + Environment.NewLine);

                }

            }

        }

        private void BtnDiconnect_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            try
            {   if (mySerialPort.IsOpen)
                {
                    mySerialPort.Close();
                }

                MyDMM.IO.Close();
                MyMMC.IO.Close();

                StatusPort = false;

                Task.Delay(3000).Wait();
                Statusbar();

            }
            catch (VisaException ex)
            {
                textread.AppendText(ex.Message);
            }

            

            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Clickcount++;

                switch (Clickcount % 2)
                {
                    case 1:
                        if (Clickcount % 2 == 1 && !isRunning)
                        {
                            isRunning = true;
                            BtnStart.BackColor = Color.LightGreen;
                            BtnStart.ForeColor = Color.White;
                            BtnStart.Text = "run Measurement";

                            timer1.Enabled = true;                   
                            timer1.Start();

     

                        }
                        break;

                    case 0:
                        if (Clickcount % 2 == 0 && isRunning)
                        {
                            isRunning = false;
                            BtnStart.BackColor = Color.Pink;
                            BtnStart.ForeColor = Color.White;
                            BtnStart.Text = "Stop Measurement";
                            //MyDMM.IO.Clear();

                            timer1.Stop();
                            timer1.Enabled = false;
                        }
                        break;

                }
            }
            catch (Exception ex) 
            { 
                textread.AppendText(r.ToString("r") + "<ERROR>" + ex.Message + Environment.NewLine);
            }
        }

        private void Btn500Step_Click(object sender, EventArgs e)
        {
            MyMMC.WriteString("M:XP500");
            MyMMC.WriteString("G:");
        }

        private void Btnread_motor_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn1000Step_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("M:XP1000");
            mySerialPort.WriteLine("G:");

            
        }
    }
}
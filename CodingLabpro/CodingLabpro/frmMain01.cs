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
using System.Runtime.InteropServices;
using NPOI.SS.Formula.Eval;
using CodingLabpro.CommandDevice;
using System.Windows.Forms.DataVisualization.Charting;
using CodingLabpro.Models;
using System.Security.Cryptography.X509Certificates;
using CodingLabpro.frmChild;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NPOI.POIFS.Crypt.Dsig;
using System.Threading;
using System.Diagnostics;



namespace CodingLabpro
{
    public partial class FrmMain01 : Form
    {
        public Ivi.Visa.Interop.FormattedIO488 MyDMM;
        public Ivi.Visa.Interop.FormattedIO488 MyMMC;
        public SerialPort MySerialPort = new SerialPort();
        private readonly Stopwatch watch = new Stopwatch();
        private TimeSpan ctimeSpan;
        public DateTime r = DateTime.Now;
        public AxisControl frmChild1;
        private string result_time;
        public static string Aread;
        public static bool isConnect;
        public event EventHandler ActiveComboBox;
    
        public List<barMenu> barButton;
     
  
        public FrmMain01()
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
      

            //BarMenuButton
            barButton = new List<barMenu>() { barMenu1 };
            ClickBar(barButton);

            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            MyDMM = new Ivi.Visa.Interop.FormattedIO488();
            MyMMC = new Ivi.Visa.Interop.FormattedIO488();

            //Port GPIB
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();

            //SetUp FormChild in UserControl
            frmChild1 = new AxisControl(MyMMC, MySerialPort, MyDMM);

            //Stopwatch
            Stoptimer1.Enabled = true;
            Stoptimer1.Interval = 100;
            Stoptimer1.Tick += Stoptimer1_Tick;
            frmChild1.OnRunClicked += FrmChild1_OnRunClicked; ;
            frmChild1.OnCancelClicked += FrmChild1_OnCancelClicked;


            //First show Panel frmChild
            AddUserControl(frmChild1);
          

            if (this.FormChildpanel.Controls.Contains(frmChild1))
            {
                ActivateMenu1(barMenu1);
                Console.WriteLine("UserControl is add Panel Control ");
            }
            else
            {
                Console.WriteLine("UserControl is not add Panel Control");
            }

           
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

        #region Stopwatch Control
        public string GetTimeString(TimeSpan elapsed)
        {
            result_time = string.Empty;
            ctimeSpan = elapsed;


            result_time = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                ctimeSpan.Hours,
                ctimeSpan.Minutes,
                ctimeSpan.Seconds,
                ctimeSpan.Milliseconds);

            return result_time;

        }

        private void Stoptimer1_Tick(object sender, EventArgs e)
        {
            LBtimer.Text = GetTimeString(watch.Elapsed);
        }

        private void FrmChild1_OnRunClicked()
        {
            watch.Restart();
        }

        private void FrmChild1_OnCancelClicked()
        {
            watch.Stop();
        }

        #endregion

        private void UpdatelabelMeasurement()
        {
            if (GlobalMeasurementSettings.Instance.SourceMode == "DC" && GlobalMeasurementSettings.Instance.MeasureMode == "Voltage")
            {
                LBunitmeasurement.Text = "VDC";
            }
            else if(GlobalMeasurementSettings.Instance.SourceMode == "DC" && GlobalMeasurementSettings.Instance.MeasureMode == "Current")
            {
                LBunitmeasurement.Text = "ADC";
            }
            else if (GlobalMeasurementSettings.Instance.SourceMode == "AC" && GlobalMeasurementSettings.Instance.MeasureMode == "Voltage")
            {
                LBunitmeasurement.Text = "VAC";
            }
            else if (GlobalMeasurementSettings.Instance.SourceMode == "AC" && GlobalMeasurementSettings.Instance.MeasureMode == "Current")
            {
                LBunitmeasurement.Text = "AAC";
            }
            else
            {
                LBunitmeasurement.Text = "Mode";
            }

        }

        public void ShowMessage(string type, string message)
        {
            Form MessageNotify = new MessageBox_Notify(type, message);
            MessageNotify.Show();
        }

        //----------------------------------------------Button bar UI------------------------------------------------------------//

        #region barMenu Control
        //barMenu event Click tabcontrol
        public void ClickBar(List<barMenu> _barmenu)
        {
            foreach (var menu1 in _barmenu)
            {
                menu1.Bar_Click += Menu1_Bar_Click;
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            FormChildpanel.Controls.Clear();
            FormChildpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Menu1_Bar_Click(object sender, EventArgs e)
        {
            barMenu _barButton = (barMenu)sender;

            switch (_barButton.Name)
            {
                case "barMenu1":
                    ActivateMenu1(barMenu1);
                    AddUserControl(frmChild1);
                    break;

            }
        }

        private void ActivateMenu1(barMenu _active, params barMenu[] _inactive)
        {
            _active.BarColor = Color.Purple;

            foreach (barMenu inactive in _inactive)
            {
                inactive.BarColor = Color.White;
            }

        }
        #endregion

        

        //----------------------------------------------FrmMain event UI------------------------------------------------------------//
        private void FrmMain01_Load(object sender, EventArgs e)
        {
            Datetimenow.Start();
            ActiveComboBox += ComboBoxEnabled;
            GlobalMeasurementSettings.Instance.SettingsChanged += Instance_SettingsChanged;
 
        }

        private void Instance_SettingsChanged(object sender, EventArgs e)
        {
            UpdatelabelMeasurement();
     
        }

        private void DataTimeNow_Tick(object sender, EventArgs e)
        {
            LBdatetime.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss tt");
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
        
      
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            // วาดพื้นหลังแบบ Gradient
            Rectangle rect = this.ClientRectangle;
            using (var brush = new LinearGradientBrush(rect,
                                                       Color.FromArgb(81, 34, 90), // สีบน
                                                       Color.FromArgb(43, 50, 87),  // สีล่าง
                                                       LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

        }

        public class COMException : System.Runtime.InteropServices.ExternalException
        {

        }

        private void FrmMain01_SizeChanged(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                labelName.Font = new Font(labelName.Font.FontFamily, 8);
                Cblistaddress.Size = new Size(290, 29);
                Cblistaddress2.Size = new Size(290, 29);
                Cblistaddress3.Size = new Size(263, 29);

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // คอลัมน์แรกกว้าง 100%
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // คอลัมน์ที่สองปรับอัตโนมัติ
            }

        }

        public void ComboBoxEnabled(Object sender, EventArgs e)
        {
            if (!isConnect)
            {
                BtnConnect.Enabled = false;
                BtnDiconnect.Enabled = true;

                Cblistaddress.Enabled = false;
                Cblistaddress2.Enabled = false;
                Cblistaddress3.Enabled = false;

                if(Cblistaddress.SelectedIndex >= 0)
                {
                    StatusPort1.BackColor = Color.LightGreen;
                    StatusPort1.Text = "CONNECT";

                }

                if (Cblistaddress2.SelectedIndex >= 0)
                {
                    StatusPort2.BackColor = Color.LightGreen;
                    StatusPort2.Text = "CONNECT";

                }

                if (Cblistaddress3.SelectedIndex >= 0)
                {
                    StatusPort3.BackColor = Color.LightGreen;
                    StatusPort3.Text = "CONNECT";

                }

            }
            else  
            {
                BtnConnect.Enabled = true;
                BtnDiconnect.Enabled = false;

                Cblistaddress.Enabled = true; 
                Cblistaddress2.Enabled = true;
                Cblistaddress3.Enabled= true;

                
            }
        }
        
        public static bool CheckPort(params System.Windows.Forms.ComboBox[] comboBoxes)
        {

            foreach (var CBox in comboBoxes)
            {
                if (CBox != null && CBox.SelectedItem != null)
                {
                    Debug.WriteLine("false");
                    return false;
                }
            }
            Debug.WriteLine("true");
            return true;
            
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

            //ตรวจสอบว่ามีการเลือกไอเทมใน ComboBox ทั้ง 3 ช่องไหม
            if (CheckPort(Cblistaddress,Cblistaddress2,Cblistaddress3))
            {
                //MessageBox.Show("you Should Select Port Device");
                BtnConnect.BackColor = Color.Orange;
                BtnConnect.Text = "Warning";
                BtnConnect.ForeColor = Color.White;

                ShowMessage("WARNING","you Should Port Device");

            }
            else
            {
                try
                {
                    if (Cblistaddress.SelectedIndex >= 0)
                    {
                        //CONNECT driver DMM Port GP - IB
                        string addr = Cblistaddress.SelectedItem.ToString();
                        MyDMM.IO = (IMessage)mgr1.Open(addr, AccessMode.NO_LOCK, 2000, null);
                        MyDMM.IO.Timeout = 2000;
                        string command = "*IDN?";
                        MyDMM.WriteString(command);

                        Aread = MyDMM.ReadString(); 
                        //MyDMM.WriteString("*CLS");
                    }

                    if (Cblistaddress2.SelectedIndex >= 0)
                    {
                        //CONNECT driver MMC Port GP-IB
                        string MMCaddr = Cblistaddress2.SelectedItem.ToString();
                        MyMMC.IO = (IMessage)mgr2.Open(MMCaddr);
                        MyMMC.IO.Timeout = 5000;
                        string MSG = "H:W";
                        MyMMC.WriteString(MSG);

                    }

                    if (Cblistaddress3.SelectedIndex >= 0)
                    {
                        //Port RS232 Setting
                        MySerialPort.PortName = Cblistaddress3.SelectedItem.ToString();
                        MySerialPort.BaudRate = 9600; // ตั้งค่า Baud Rate
                        MySerialPort.Parity = Parity.None; // ตั้งค่า Parity
                        MySerialPort.StopBits = StopBits.One; // ตั้งค่า Stop Bits
                        MySerialPort.DataBits = 8; // ตั้งค่าจำนวน Data Bits
                        MySerialPort.Handshake = Handshake.None; // ตั้งค่า Handshake


                        ////CONNET driver MMC Port RS-232
                        MySerialPort.Open();
                        MySerialPort.WriteLine("H:X");

                    }

                    List<string> listDevice = new List<string>{Cblistaddress.Text, Cblistaddress2.Text, Cblistaddress3.Text };
                    ShowMessage("OK", r.ToString("r") + $"\nPort Driver Connected\n{Aread}" + $"{string.Join("\n",listDevice)}");

                    ActiveComboBox?.Invoke(this, EventArgs.Empty);
                    isConnect = true;
                    BtnConnect.Text = "Remote";
                    BtnConnect.BackColor = Color.LightGreen;
                }
                catch (Exception ex)
                {
                    isConnect = false;
                    BtnConnect.BackColor = Color.Red;
                    BtnConnect.Text = "Unconnect";
                    BtnConnect.ForeColor = Color.White;
                   
                    ShowMessage("ERROR", r.ToString("r") + "\nCannot Find driver Agilent Muitimeter and MMC Step motor!" + Environment.NewLine + ex.Message);
                  
                }

            }
                
        }
            
        private void BtnDiconnect_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (Cblistaddress.SelectedIndex >= 0)
                {
                    MyDMM.IO.Close();
                    StatusPort1.BackColor = Color.Red;
                    StatusPort1.Text = "DiCONNECT";
                }

                if (Cblistaddress2.SelectedIndex >= 0)
                {
                    MyMMC.IO.Close();
                    StatusPort2.BackColor = Color.Red;
                    StatusPort2.Text = "DiCONNECT";
                }

                if (Cblistaddress3.SelectedIndex >= 0)
                {
                    if (MySerialPort.IsOpen)
                    {
                        MySerialPort.Close();
                    }

                    StatusPort3.BackColor = Color.Red;
                    StatusPort3.Text = "DiCONNECT";
                }

                Task.Delay(5000).Wait();

                ActiveComboBox?.Invoke(this, EventArgs.Empty);
                isConnect = false;
                BtnConnect.BackColor = Color.Transparent;
                BtnConnect.Text = "CONNECT";
                BtnConnect.ForeColor = Color.Black;

                

            }
            catch (VisaException ex)
            {
                ShowMessage("ERROR", r.ToString("r") + "\nCannot DiConnect Devices" + Environment.NewLine + ex.Message);
            }

            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        
    }
}
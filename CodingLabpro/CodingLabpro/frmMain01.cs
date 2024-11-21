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

namespace CodingLabpro
{
    public partial class frmMain01 : Form
    {
        Ivi.Visa.Interop.FormattedIO488 MyDMM;
        Ivi.Visa.Interop.FormattedIO488 MyMMC;
        private DateTime r = DateTime.Now;


        public frmMain01()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //ลดกระพริบ
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            MyDMM = new Ivi.Visa.Interop.FormattedIO488();
            MyMMC = new Ivi.Visa.Interop.FormattedIO488();

            //Port GPIB
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();

            //Port Rs-232
            SerialPort serialPort = new SerialPort();


        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (LinearGradientBrush lgb = new LinearGradientBrush(rect, Color.FromArgb(81, 34, 100), Color.FromArgb(43, 50, 84), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(lgb, rect);


            }
        }


        private void frmMain01_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void frmMain01_SizeChanged(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                labelName.Font = new Font(labelName.Font.FontFamily, 12);
                Cblistaddress.Size = new Size(300, 29);
                Cblistaddress2.Size = new Size(300, 29);
                Cblistaddress3.Size = new Size(300, 29);

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                labelName.Font = new Font(labelName.Font.FontFamily, 18);
                Cblistaddress.Size = new Size(400, 29);
                Cblistaddress2.Size = new Size(400, 29);
                Cblistaddress3.Size = new Size(400, 29);

            }

            this.Invalidate(); // refresh background gradinet color
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
            if (Cblistaddress.SelectedIndex <= 0 && Cblistaddress2.SelectedIndex <= 0 && Cblistaddress3.SelectedIndex <= 0)
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
                    //CONNECT driver DMM Port GP-IB
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

                    //CONNET driver MMC Port RS-232
                    string MMCaddr2 = Cblistaddress3.SelectedItem.ToString();
                    serialPort1.PortName = MMCaddr2;

                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                    }

                    // ส่งข้อมูลผ่านพอร์ต
                    serialPort1.WriteLine("P:4P0"); // กำหนดตัวกำหนด CR+LF
                    serialPort1.WriteLine("P:5P2"); // ตั้งค่า baud rate เป็น 4800
                    serialPort1.WriteLine("P:7P2"); // ตั้งค่า stop bits เป็น 2 บิต
                    serialPort1.WriteLine("H:W");

                    //Show is connect DMM 
                    MessageBox.Show("Device is connect", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnConnect.Text = "Remote";
                    BtnConnect.BackColor = Color.LightGreen;
                    string rectify1 = "Remote Agilent HP34401A and MMC Step motor! By Port GPIB";
                    textread.AppendText(r.ToString("r") + " <Notification!> " + rectify1 + Environment.NewLine);
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
    }
}
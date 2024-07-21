using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keysight.Visa;
using Ivi.Visa.Interop;
using Ivi.Visa.FormattedIO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices.ComTypes;



namespace CodingLabpro
{
    public partial class frmMain : Form
    {
        Ivi.Visa.Interop.FormattedIO488 MyDMM;
        Ivi.Visa.Interop.FormattedIO488 MyMMC;
        string addr = $"GPIB2::26::INSTR";
        string MMCaddr = $"GPIB2::7:24::INSTR";

        public object BERT { get; private set; }

        public frmMain()
        {
            InitializeComponent();
            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            MyDMM = new Ivi.Visa.Interop.FormattedIO488();
            MyMMC = new Ivi.Visa.Interop.FormattedIO488();

            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();



            //txtMMC2Address.Text = Properties.Settings.Default.MMC2Address;
        }


        public class COMException : System.Runtime.InteropServices.ExternalException
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CONNECT DMM
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();

            //CONNECT MMC
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();


            if (MyMMC != null && MyDMM != null)
            {
                //Connect driver DMM
                string addr = "GPIB2::26::INSTR";
                MyDMM.IO = (IMessage)mgr1.Open(addr);
                string command = "*IDN?";
                MyDMM.WriteString(command);
                string Aread = MyDMM.ReadString();
                MyDMM.WriteString(Aread);
                MyDMM.WriteString("*CLS");
                //Task.Delay(20000);

                ////MyDMM.WriteString("SYSTem:BEEPer");
                //Task.Delay(100);
                //MyDMM.WriteString("SYST:BEEP");
                //MyDMM.WriteString("*CLS");
                
                //MyDMM.WriteString("DISP:TEXT 'HELLO'");  //errorr
                //Task.Delay(6000).Wait();
                //MyDMM.WriteString("*RST");


                //Connect driver MMC
                string MMCaddr = "GPIB2::7::INSTR";
                MyMMC.IO = (IMessage)mgr2.Open(MMCaddr);
                string MSG = "H:W";
                MyMMC.WriteString(MSG);

                // Read response
                //string response = MyDMM.ReadString();
                //txtResponse.Text = response;

                //Show is connect DMM 
                MessageBox.Show("Device is connect", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connect.Text = "Remote";
                Connect.BackColor = Color.LightGreen;
                string rectify1 = "Remote Agilent HP34401A and MMC Step motor!";
                DateTime r = DateTime.Now; // notification Time Cilck Button here!!
                txtread.AppendText(r.ToString("r") + " <Notification!> " + rectify1 + Environment.NewLine);

            }
            else 
            {
                Connect.BackColor = Color.Red;
                Connect.Text = "Unconnect";
                Connect.ForeColor = Color.White;
                MessageBox.Show("Device session is not connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string incorrectness1 = "Cannot Find driver Agilent Muitimeter and MMC Step motor!";
                DateTime r = DateTime.Now; // notification Time Cilck Button here!!
                txtread.AppendText(r.ToString("r") + " <Notification!> " + incorrectness1 + Environment.NewLine);
            }

        }

        private void BtnMovestep_Click(object sender, EventArgs e)
        {
            string MSG1 = "M:XP10";
            MyMMC.WriteString(MSG1);
            string MStep = "G:";
            MyMMC.WriteString(MStep);

        }

        private void Btn_movestep500_Click(object sender, EventArgs e)
        {
            string MSG2 = "M:XP500";
            MyMMC.WriteString(MSG2);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_movestep1000_Click(object sender, EventArgs e)
        {
            string MSG3 = "M:XP1000";
            MyMMC.WriteString(MSG3);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_ResetXY_Click(object sender, EventArgs e)
        {
            string RSG = "H:W";
            MyMMC.WriteString(RSG);
  
        }
        private void Btn_stepY10_Click(object sender, EventArgs e)
        {
            string MSGY1 = "M:YP10";
            MyMMC.WriteString(MSGY1);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_stepY500_Click(object sender, EventArgs e)
        {
            string MSGY2 = "M:YP500";
            MyMMC.WriteString(MSGY2);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_stepY1000_Click(object sender, EventArgs e)
        {
            string MSGY3 = "M:YP1000";
            MyMMC.WriteString(MSGY3);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_Cleardmm_Click(object sender, EventArgs e)
        {
            string command2 = "*RST";
            MyDMM.WriteString(command2);
            DateTime r = DateTime.Now; // notification Time Cilck Button here!!
            txtread.AppendText(r.ToString("r") + " <Notification!> " + command2 + Environment.NewLine);

        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            MyDMM.WriteString("SYSTem:ERRor?");
            string response1 = MyDMM.ReadString();
            //string response1 = "Hello World";
            DateTime r = DateTime.Now;
            txtread.AppendText(r.ToString("r") + " <ERROR!!!> " + response1 + Environment.NewLine);
        }

        private void BtnDiconnect_Click(object sender, EventArgs e)
        {
            MyDMM.IO.Close();
            MyMMC.IO.Close();
            Task.Delay(3000).Wait();
            MessageBox.Show("Device session is diconnect", "Diconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnDiconnect.BackColor = Color.LightBlue;
            BtnDiconnect.ForeColor = Color.White;
            Connect.BackColor = Color.Red;
            Connect.Text = "Unconnect";
            Connect.ForeColor = Color.White;
            
            string rectify2 = "Diconnect Agilent HP34401A and MMC Step motor!";
            DateTime r = DateTime.Now; // notification Time Cilck Button here!!
            txtread.AppendText(r.ToString("r") + " <Notification!> " + rectify2 + Environment.NewLine);

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
        }

        private void Btn_SetAC_Click(object sender, EventArgs e)
        {
            MyDMM.WriteString("MEAS:VOLT:AC? 1,1E-6");
        }

        private void Btn_SetDC_Click(object sender, EventArgs e)
        {
            //MyDMM.WriteString("CONF:VOLT:DC 10,0.001");

            try
            {
                MyDMM.WriteString("MEAS:VOLT:DC? 1,1E-6");
                string dataDC = MyDMM.ReadString();
                txtread.AppendText(dataDC + Environment.NewLine);
            }
            catch (Exception ex) 
            {
                do
                {
                    DateTime r = DateTime.Now;
                    txtread.AppendText(r.ToString("r") + " <ERROR!!!> " + ex.Message + Environment.NewLine);
                    Task.Delay(2000).Wait();
                }
                while (true);
            
            }
           
        }
    }
}

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


            try
            {
                
                //Connect driver DMM
                string addr = "GPIB2::26::INSTR";
                MyDMM.IO = (IMessage)mgr1.Open(addr);
                string command = "*IDN?";
                MyDMM.WriteString(command);
                string Aread = MyDMM.ReadString();
                MyDMM.WriteString(Aread);
                txtread.AppendText(Aread +Environment.NewLine);
                MyDMM.WriteString("*CLS");
               

                //Connect driver MMC
                string MMCaddr = "GPIB2::7::INSTR";
                MyMMC.IO = (IMessage)mgr2.Open(MMCaddr);
                string MSG = "H:W";
                MyMMC.WriteString(MSG);

                //Show is connect DMM 
                MessageBox.Show("Device is connect", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connect.Text = "Remote";
                Connect.BackColor = Color.LightGreen;
                string rectify1 = "Remote Agilent HP34401A and MMC Step motor!";
                DateTime r = DateTime.Now; // notification Time Cilck Button here!!
                txtread.AppendText(r.ToString("r") + " <Notification!> " + rectify1 + Environment.NewLine);

            }
            catch
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
            MyMMC.WriteString("Q:");
            
            
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
            try
            {
                MyDMM.IO.Close();
                MyMMC.IO.Close();
            }
            catch (Exception ex) 
            {
                txtread.AppendText(ex.Message +Environment.NewLine);
            }
            
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


        private void Btn_SetAC_Click(object sender, EventArgs e)
        {
            MyDMM.WriteString("MEAS:VOLT:AC? 1,1E-6");
        }

        private int Clickcount = 0;

        private void Btn_SetDC_Click(object sender, EventArgs e)
        {

            try
            {

                Clickcount++;

                switch (Clickcount % 2)
                {
                    case 1:
                        //MyDMM.WriteString("MEAS:VOLT:DC? 1,1E-6");
                        //string dataDC = MyDMM.ReadString();
                        //txtread.AppendText(dataDC + Environment.NewLine);
                        Btn_SetDC.BackColor = Color.LightGreen;
                        Btn_SetDC.ForeColor = Color.Black;
                        Btn_SetDC.Text = "Runing";
                        break;
                    case 0:
                        Btn_SetDC.BackColor = Color.Pink;
                        Btn_SetDC.ForeColor = Color.Black;
                        Btn_SetDC.Text = "Stop";
                        break;
                }
                Btn_SetDC.Invalidate();
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

   
        private void Btnmotorloop_Click(object sender, EventArgs e)
        {
            string Sloop = txtinput.Text;
            MessageBox.Show("จำนวนรอบที่วน มอเตอร์ X = " + Sloop);
            txtinput.Clear();

            int numberOfLoops;

            if (int.TryParse(Sloop, out numberOfLoops))
            {
                for (int i = 1; i < numberOfLoops; i++)
                {
                    // Your motor control logic here

                    //MyMMC.WriteString("M:XP100");
                    //Task.Delay(1000);
                    //MyMMC.WriteString("G:");
                    txtread.AppendText(i.ToString() + " " + Environment.NewLine);
                    
                }
            }


        }
    }
}

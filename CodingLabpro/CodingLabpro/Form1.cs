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



namespace CodingLabpro
{
    public partial class Form1 : Form
    {
        Ivi.Visa.Interop.FormattedIO488 MyDMM;
        Ivi.Visa.Interop.FormattedIO488 MyMMC;
        string addr = $"GPIB0::26::INSTR";
        string MMCaddr = $"GPIB0::7::INSTR";

        public Form1()
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
                string addr = "GPIB0::26::INSTR";
                MyDMM.IO = (IMessage)mgr1.Open(addr);
                string command = "*IDN?";
                MyDMM.WriteString(command);

                //Connect driver MMC
                string MMCaddr = "GPIB0::7::INSTR";
                MyMMC.IO = (IMessage)mgr2.Open(MMCaddr);
                string MSG = "H:W";
                MyMMC.WriteString(MSG);

                // Read response
                string response = MyDMM.ReadString();
                //txtResponse.Text = response;

                //Show is connect DMM 
                MessageBox.Show("Device is connect", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Device session is not connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button2_Click_Click(object sender, EventArgs e)
        {
            MyDMM.IO.Close();
            MyMMC.IO.Close();
            MessageBox.Show("Device session is diconnect", "Diconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        }

        private void Btn_SetDc_Click(object sender, EventArgs e)
        {
            //MyDMM.WriteString("CONF:VOLT:DC 10,0.001");
            MyDMM.WriteString("MEAS:VOLT:DC? 1,1E-6");
        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            MyDMM.WriteString("SYSTem:ERRor?");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

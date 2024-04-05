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
    }
}

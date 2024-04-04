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
        public Form1()
        {
            InitializeComponent();
            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            MyDMM = new Ivi.Visa.Interop.FormattedIO488();

            string addr = "GPIB0::26::INSTR";
            MyDMM.IO = (Ivi.Visa.Interop.IMessage)rm.Open(addr);
            //txtMMC2Address.Text = Properties.Settings.Default.MMC2Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CONNECT DMM
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
            
          
            //MyDMM.IO = mgr1.Open(addr);
            //MyDMM.IO.Timeout = 7000;

            if (MyDMM != null)
            {
                MyDMM.IO = (IMessage)mgr1.Open(addr, AccessMode.NO_LOCK, 2000, null);
                string command = "*IDN?";
                MyDMM.WriteString(command);

                // Read response
                string response = MyDMM.ReadString();
                //txtResponse.Text = response;

                //Show is connect DMM
                MessageBox.Show("Device is connect", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Device session is not connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

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

            txtDMMAddress.Text = "GPIB0::26::INSTR";
            //txtMMC2Address.Text = Properties.Settings.Default.MMC2Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CONNECT DMM
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
          
            DMM.IO() = mgr1.Open(DMMAddress);
            DMM.IO.Timeout = 7000;

            if (MyDMM != null)
            {
                MyDMM.IO = mgr1.Open(txtDMMAddress.Text);
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

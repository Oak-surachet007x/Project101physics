using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivi.Visa.Interop;
using Keysight.Visa;



namespace CodingLabpro
{
    public partial class Form1 : Form
    {
        private FormattedIO488 _deviceSession;

        public Form1()
        {
            InitializeComponent();
            //Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            //Ivi.Visa.Interop.FormattedIO488 myDMM = new Ivi.Visa.Interop.FormattedIO488();

            txtDMMAddress.Text = "GPIB0::26::INSTR";
            //txtMMC2Address.Text = Properties.Settings.Default.MMC2Address;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_deviceSession != null)
            {
                string command = "*IDN?";
                _deviceSession.WriteString(command);

                // Read response
                string response = _deviceSession.ReadString();
                txtResponse.Text = response;

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

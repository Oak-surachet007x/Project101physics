using System;
using System.Windows.Forms;


namespace CodingLabpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            Ivi.Visa.Interop.FormattedIO488 MyDMM = new Ivi.Visa.Interop.FormattedIO488();

            string addr = "GPIB0::26::INSTR";
            MyDMM.IO = (Ivi.Visa.Interop.IMessage)rm.Open(addr);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingLabpro.frmChild
{
    public partial class DMMmeasure : UserControl
    {
        private readonly Ivi.Visa.Interop.FormattedIO488 myDMM;

        public DMMmeasure(Ivi.Visa.Interop.FormattedIO488 myDMM)
        {
            InitializeComponent();
            this.myDMM = myDMM;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FrmMain01.Aread);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodingLabpro.CommandDevice;

namespace CodingLabpro
{
    public partial class FrmSelectionModel : Form
    {
        public FrmSelectionModel()
        {
            InitializeComponent();
        }

        public string ResultSelectedModel { get; private set; }
        private void Btn_ApplyModel_Click(object sender, EventArgs e)
        {
            if(RB_ChuoseikiModel.Checked)
            {
                this.ResultSelectedModel = "Chuoseiki";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(RB_VextaModel.Checked)
            {
                this.ResultSelectedModel = "Vexta";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a model before applying.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void FrmSelectionModel_Load(object sender, EventArgs e)
        {
            
        }
    }
}

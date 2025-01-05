using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingLabpro.Models
{
    public partial class ucMenu : UserControl
    {
        string menuTile = "";
        Image icon;
        Color _borderColor  = Color.Transparent;

        public event EventHandler Text_Clicked;

        public string textlabel
        {
            get
            {
                return menuTile;
            }
            set
            {
                menuTile = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }

            set
            { 
                _borderColor = value;
                this.Invalidate();
            }
        }
        public Image Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                this.Invalidate();
            }
        }
        public ucMenu()
        {
            InitializeComponent();
        }

        private void ucMenu_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = menuTile;
            pictureBox1.Image = icon;
            borderPanel.BackColor = _borderColor;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Text_Clicked?.Invoke(this, e);
        }

       
    }
}

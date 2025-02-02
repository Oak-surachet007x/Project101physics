using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodingLabpro.Models
{
    public partial class ucMenu : UserControl
    {
        string menuTile = "No label";
        Image icon;
        Color _borderColor = Color.Transparent;

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
                pictureBox1.Image = icon;
                this.Invalidate();
            }
        }
        public ucMenu()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.UpdateStyles();
            InitializeComponent();
        }

        private void ucMenu_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = menuTile;
        
            borderPanel.BackColor = _borderColor;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Text_Clicked?.Invoke(this, e);
        }
    }
}

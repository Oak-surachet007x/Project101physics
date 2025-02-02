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
    public partial class barMenu : UserControl
    {
        string barTile = "No Text";
        Color _barColor = Color.Transparent;

        public event EventHandler Bar_Click;
        public string textbar
        {
            get
            { return barTile; }
            set
            {
                barTile = value;
                this.Invalidate();
            }
        }

        public Color BarColor
        {
            get { return _barColor; }
            set
            {
                _barColor = value;
                this.Invalidate();
            }
        }

        public barMenu()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.UpdateStyles();
            InitializeComponent();
        }
      

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            
            Font myfont = new Font("Cascadia Mono" , 10, FontStyle.Regular);
            Brush brush = new System.Drawing.SolidBrush(Color.White);
          
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(barTile, myfont, brush, 0, 0);


        }

        private void barMenu_Paint(object sender, PaintEventArgs e)
        {
            panelbar.BackColor = _barColor;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            Bar_Click?.Invoke(this, e);
        }

       
    }
}

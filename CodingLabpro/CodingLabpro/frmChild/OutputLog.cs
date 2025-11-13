using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingLabpro.frmChild
{
    public partial class OutputLog : Form
    {
        public OutputLog()
        {
            InitializeComponent();
            this.SetStyle(
                       ControlStyles.OptimizedDoubleBuffer |
                       ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            // วาดพื้นหลังแบบ Gradient
            Rectangle rect = this.ClientRectangle;
            using (var brush = new LinearGradientBrush(rect,
                                                       Color.FromArgb(81, 34, 90), // สีบน
                                                       Color.FromArgb(43, 50, 87),  // สีล่าง
                                                       LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

        }
    }
}

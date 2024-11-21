using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingLabpro.Models
{
    [ToolboxItem (true)]
    public partial class GradientPanel : Panel
    {
   
        private Color colorTop;
        private Color colorBottom;

        public Color ColorTop
        {
            get { return colorTop; }
            set { colorTop = value; Invalidate(); }
        }

        public Color ColorBottom
        {
            get { return colorBottom; }
            set { colorBottom = value; Invalidate(); }
        }

        public GradientPanel()
        {
            // เรียก Invalidate เมื่อขนาดคอนโทรลเปลี่ยน
            this.Resize += (s, e) => Invalidate();
        }
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, colorTop, colorBottom, 90F))
            {
                pevent.Graphics.FillRectangle(lgb, this.ClientRectangle);
            }

            base.OnPaint(pevent);
        }

    }
}

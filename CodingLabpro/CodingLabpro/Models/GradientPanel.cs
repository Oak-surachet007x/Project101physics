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
    [ToolboxItem(true)] // เปิดใช้งานสำหรับ Toolbox
    public partial class GradientPanel : Panel
    {
        // กำหนดค่าสีเริ่มต้น
        private Color colorTop = Color.LightBlue;
        private Color colorBottom = Color.DarkBlue;

        [Category("Gradient Colors"), Description("The top color of the gradient.")]
        public Color ColorTop
        {
            get => colorTop;
            set
            {
                colorTop = value;
                Invalidate(); // บังคับให้วาดใหม่
            }
        }

        [Category("Gradient Colors"), Description("The bottom color of the gradient.")]
        public Color ColorBottom
        {
            get => colorBottom;
            set
            {
                colorBottom = value;
                Invalidate(); // บังคับให้วาดใหม่
            }
        }

        public GradientPanel()
        {
            // เปิดใช้งานการวาดที่ลดปัญหากระพริบ
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            // กำหนดค่าพื้นฐานเพื่อให้แสดงใน Designer ได้
            this.Size = new Size(200, 100); // ขนาดเริ่มต้น
            this.BackColor = Color.Transparent; // ให้พื้นหลังโปร่งใส
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // ตรวจสอบ Design Mode
            if (this.Width <= 0 || this.Height <= 0 || colorTop == Color.Empty || colorBottom == Color.Empty)
                return;

            // ใช้ LinearGradientBrush เพื่อสร้าง Gradient
            using (var brush = new LinearGradientBrush(this.ClientRectangle, colorTop, colorBottom, LinearGradientMode.Vertical))
            {
                pevent.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}

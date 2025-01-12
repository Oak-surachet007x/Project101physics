using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConponentOdj
{
    public class RoundPanel :Panel
    {
        private int borderRadius = 30;
        private float borderangle = 90F;
        private Color topColor = Color.White;
        private Color bottomColor = Color.White;

        public RoundPanel()
        {
            this.BackColor = Color.White;
            this.Size = new Size(350, 200);
            this.SetStyle(ControlStyles.ResizeRedraw, true); // ให้วาดใหม่เมื่อปรับขนาด
            this.Refresh();
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }

        }
        public float BorderAngle
        {
            get => borderangle;
            set { borderangle = value; this.Invalidate(); }
        }

        public Color TopColor
        {
            get => topColor;
            set { topColor = value; this.Invalidate(); }
        }


        public Color BottomColor
        {
            get => bottomColor;
            set { bottomColor = value; this.Invalidate(); }
        }

        private GraphicsPath GetGraphicsPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.StartFigure();
            graphics.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphics.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphics.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphics.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphics.CloseFigure();

            return graphics;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.BorderAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, this.ClientRectangle);

            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetGraphicsPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);

                }
            }
            else this.Region = new Region(rectangleF);

        }
    }
}

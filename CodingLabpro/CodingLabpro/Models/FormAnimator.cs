using MathNet.Numerics.LinearAlgebra.Factorization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingLabpro.Models
{
    public class FormAnimator
    {
        private Timer animationTimer;
        private Form form;
        private double opacityIncrement;
        private int targetTopPosition;
        private int slideSpeed;
        private Timer fadeInTimer;
        public FormAnimator(Form form)
        {
            this.form = form;
            animationTimer = new Timer();
            animationTimer.Interval = 20; // Control the animation speed
        }

        public void FadeIn(double speed = 0.05)
        {
            form.Opacity = 0;
            opacityIncrement = speed;
            animationTimer.Tick += FadeInTick;
            animationTimer.Start();
        }

        private void FadeInTick(object sender, EventArgs e)
        {
            if (form.Opacity < 1)
            {
                form.Opacity += opacityIncrement;
            }
            else
            {
                animationTimer.Stop();
                animationTimer.Tick -= FadeInTick;
            }
        }

        public void SlideIn(int startTop, int endTop, int speed = 10)
        {
            form.Top = startTop;
            targetTopPosition = endTop;
            slideSpeed = speed;
            animationTimer.Tick += SlideInTick;
            animationTimer.Start();
        }

        private void SlideInTick(object sender, EventArgs e)
        {
            if (form.Top < targetTopPosition)
            {
                form.Top += slideSpeed;
            }
            else
            {
                animationTimer.Stop();
                animationTimer.Tick -= SlideInTick;
            }
        }

        public void ZoomOut(Size endSize, int speed = 10)
        {
            animationTimer.Tick += (sender, e) =>
            {
                // Gradually decrease the form's width and height
                if (form.Width > endSize.Width && form.Height > endSize.Height)
                {
                    form.Width -= speed;
                    form.Height -= speed;

                    // Keep the form centered during the zoom-out effect
                    form.Left += speed / 2;
                    form.Top += speed / 2;
                }
                else
                {
                    // Stop the timer and reset size to final dimensions
                    form.Width = endSize.Width;
                    form.Height = endSize.Height;
                    animationTimer.Stop();
                }
            };

            animationTimer.Start();
        }
     
        //Method to animate a zoom-in effect on a form
        public void AnimatedZoomIn(Form form, int targetWidth, int targetHeight, int duration = 500)
        {
            int initialWidth = form.Width;
            int initialHeight = form.Height;
            int steps = 20; // Number of animation steps
            int interval = duration / steps; // Interval for each step

            // Calculate the size increment per step
            int widthStep = (targetWidth - initialWidth) / steps;
            int heightStep = (targetHeight - initialHeight) / steps;

            // Set up a timer for the animation
            Timer zoomTimer = new Timer
            {
                Interval = interval
            };

            zoomTimer.Tick += (s, e) =>
            {
                // Increment the form's size
                if (form.Width < targetWidth && form.Height < targetHeight)
                {
                    form.Width += widthStep;
                    form.Height += heightStep;
                    form.Left -= widthStep / 2; // Centering the zoom
                    form.Top -= heightStep / 2;
                }
                else
                {
                    // Stop the timer when target size is reached
                    form.Width = targetWidth;
                    form.Height = targetHeight;
                    zoomTimer.Stop();
                    zoomTimer.Dispose();
                }
            };

            // Start the animation
            zoomTimer.Start();
        }

    }
}

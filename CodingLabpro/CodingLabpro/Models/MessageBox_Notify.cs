using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingLabpro.Models
{
    public partial class MessageBox_Notify : Form
    {
        private int TargetX;
        private int TargetY;
        private int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        public MessageBox_Notify(string Type, string message)
        {
            InitializeComponent();
            labelType.Text = Type;
            IbMessage.Text = message;

            switch (Type)
            {
                case "OK":
                    MessageBorder.BackColor = Color.FromArgb(22, 196, 127);
                    picIcon.Image = Properties.Resources.sync_saved_locally_100dp_16C47F_FILL1_wght400_GRAD0_opsz48;
                    break;

                case "ERROR":
                    MessageBorder.BackColor = Color.Red;
                    picIcon.Image = Properties.Resources.error_16dp_FF0000_FILL1_wght400_GRAD0_opsz48;
                    break;

                case "INFO":
                    MessageBorder.BackColor = Color.Blue;
                    picIcon.Image = Properties.Resources.info_16dp_0000F5_FILL0_wght400_GRAD0_opsz48;
                    break;

                case "WARNING":
                    MessageBorder.BackColor = Color.FromArgb(255, 127, 0);
                    picIcon.Image = Properties.Resources.warning_16dp_FF7F00_FILL1_wght400_GRAD0_opsz48;
                    break;
            }
          
        }

        private void LineBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MessageBox_Notify_Load(object sender, EventArgs e)
        {
            Position();
        }

        private async void Messagetimer_Tick(object sender, EventArgs e)
        {
            if (this.Left > TargetX)
            {
                this.Left -= 10; // ขยับขึ้นทีละ 10 พิกเซล
                
            }
            else
            {
                Messagetimer.Stop();
                await Task.Delay(4000);
                HideTimer.Start();
            }
        }

        public void Position()
        {
            TargetX = ScreenWidth - this.Width - 10; // จุดที่ต้องการให้เลื่อนขึ้นไป
            TargetY = ScreenHeight - this.Height - 850;

            this.Location = new Point(ScreenWidth, TargetY); // เริ่มจากล่างสุด
            Messagetimer.Start();
        }


        private void HideTimer_Tick(object sender, EventArgs e)
        {
            if (this.Left < ScreenWidth)
            {
                this.Left += 100; // ขยับไปทางขวาทีละ 10 พิกเซล

            }
            else 
            {
                HideTimer.Stop();
                this.Close();
            }
            
        }

        private void MessageBox_Notify_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("FormMessage is closed");
        }
    }
}

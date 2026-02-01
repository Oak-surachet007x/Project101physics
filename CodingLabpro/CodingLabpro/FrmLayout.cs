using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodingLabpro.CommandDevice;
using CodingLabpro.frmChild;
using CodingLabpro.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CodingLabpro
{
    public partial class FrmLayout : Form
    {
        public List<ucMenu> menuButton;
        public class DwmApi
        {
            // ค่า DWM_WINDOW_ATTRIBUTE 
            public const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20; // เปิดใช้งาน Dark Mode
            public const int DWMWA_WINDOW_CORNER_PREFERENCE = 33; // ตั้งค่ามุมหน้าต่าง
            public const int DWMWA_CAPTION_COLOR = 34; // เปลี่ยนสี Title Bar

            // การประกาศ DwmSetWindowAttribute
            [DllImport("dwmapi.dll")]
            public static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref uint pvAttribute, int cbAttribute);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            uint isDarkMode = 1; // เปิดใช้งาน (0 = ปิด)
            int result = DwmApi.DwmSetWindowAttribute(this.Handle, DwmApi.DWMWA_USE_IMMERSIVE_DARK_MODE, ref isDarkMode, sizeof(int));


            if (result != 0)
            {
                MessageBox.Show($"DwmSetWindowAttribute failed with error code {result}");
            }
        }

        public FrmLayout()
        {
            InitializeComponent();
            this.Text = "Aglient 34401A And MMC-2 Axis Controller";
            LBversion.Text = "Version \n1.0.3"; //แสดงผลเวอร์ชันโปรแกรม

            this.SetStyle(
                        ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            //เริ่มต้นเพิ่มฟอร์มลูก ค่าเริ่มต้น
            AddFormControl(new FrmMain01());
            //ตรวจสอบการเพิ่มฟอร์มลูกลงในแพเนล
            if (this.FormLayoutpanel.Controls.OfType<FrmMain01>().Any())
            {
                ActivateMenu(ucMenu1);
                Console.WriteLine("FormControl is add Panel Control ");
            }
            else
            {
                Console.WriteLine("FormControl is not add Panel Control");
            }

            //MenuButton
            menuButton = new List<ucMenu>() { ucMenu1 };
            ClickMenu(menuButton);
        }

        #region ucMenu Control
        //ucMenu event Click
        public void ClickMenu(List<ucMenu> _menu)
        {
            foreach (var menu in _menu)
            {
                menu.Text_Clicked += Menu_textClick;
            }
        }
        //เมธอดเพิ่มฟอร์มลูกลงในแพเนล
        private void AddFormControl(Form FormControl)
        {
            FormControl.TopLevel = false;
            FormControl.FormBorderStyle = FormBorderStyle.None;
            FormControl.Dock = DockStyle.Fill;
            FormLayoutpanel.Controls.Clear();
            FormLayoutpanel.Controls.Add(FormControl);
            FormControl.BringToFront();
            FormControl.Show();
        }

        private void Menu_textClick(object sender, EventArgs e)
        {
            ucMenu _menuButton = (ucMenu)sender;

            switch (_menuButton.Name)
            {
                case "ucMenu1":
                    ActivateMenu(ucMenu1);
                    AddFormControl(new FrmMain01());
                    break;
            }
        }
        private void ActivateMenu(ucMenu _active, params ucMenu[] _inactive)
        {

            _active.BorderColor = Color.FromArgb(140, 26, 246);

            foreach (ucMenu inactive in _inactive)
            {
                inactive.BorderColor = Color.Transparent;
            }


        }


        #endregion

       

        private void FrmLayout_Load(object sender, EventArgs e)
        {
           
        }
       
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keysight.Visa;
using Ivi.Visa.Interop;
using Ivi.Visa.FormattedIO;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using Ivi.Visa;
using System.IO;
using System.IO.Ports;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Diagnostics;



namespace CodingLabpro
{
    public partial class frmMain : Form
    {
        Ivi.Visa.Interop.FormattedIO488 MyDMM;
        Ivi.Visa.Interop.FormattedIO488 MyMMC;
        string addr = $"GPIB0::26::INSTR";
        string MMCaddr = $"GPIB0::7::INSTR";

        private DataTable dt = new DataTable();
        public frmMain()
        {
            InitializeComponent();
            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            MyDMM = new Ivi.Visa.Interop.FormattedIO488();
            MyMMC = new Ivi.Visa.Interop.FormattedIO488();
            
            //Port GPIB
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();

            // Port RS-232
            SerialPort serialPort = new SerialPort();

            //Data table
            dt.Columns.Add("Time"); //<<-- ข้อมูลช่วงของคอลัมล์ ค่าชื่อ
            dt.Columns.Add("DCvolt");


        }



        public class COMException : System.Runtime.InteropServices.ExternalException
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //CONNECT DMM
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();

            //CONNECT MMC
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            if (!Ptgpib.Checked && !Ptrs232.Checked)
            {
                Connect.BackColor = Color.Orange;
                Connect.Text = "Warning";
                Connect.ForeColor = Color.White;     
                
                DateTime r = DateTime.Now; // notification Time Cilck Button here!!
                txtread.AppendText(r.ToString("r") + " <Notification!> " + "กรุณาเลือกพอร์ตเชื่อมต่อก่อนดำเนินการ" + Environment.NewLine);
            }
            else
            {
                if (Ptgpib.Checked)
                {
                    try
                    {
                        //Connect driver DMM
                        string addr = "GPIB0::26::INSTR";
                        MyDMM.IO = (IMessage)mgr1.Open(addr, AccessMode.NO_LOCK, 2000, null);
                        MyDMM.IO.Timeout = 2000;
                        string command = "*IDN?";
                        MyDMM.WriteString(command);
                        string Aread = MyDMM.ReadString();
                        MyDMM.WriteString(Aread);
                        txtread.AppendText(Aread + Environment.NewLine);
                        MyDMM.WriteString("*CLS");


                        //Connect driver MMC
                        string MMCaddr = "GPIB0::7::INSTR";
                        MyMMC.IO = (IMessage)mgr2.Open(MMCaddr);
                        string MSG = "H:W";
                        MyMMC.WriteString(MSG);


                        //Show is connect DMM 
                        MessageBox.Show("Device is connect", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Connect.Text = "Remote";
                        Connect.BackColor = Color.LightGreen;
                        string rectify1 = "Remote Agilent HP34401A and MMC Step motor! By Port GPIB";
                        DateTime r = DateTime.Now; // notification Time Cilck Button here!!
                        txtread.AppendText(r.ToString("r") + " <Notification!> " + rectify1 + Environment.NewLine);

                    }
                    catch
                    {
                        Connect.BackColor = Color.Red;
                        Connect.Text = "Unconnect";
                        Connect.ForeColor = Color.White;
                        MessageBox.Show("Device session is not connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string incorrectness1 = "Cannot Find driver Agilent Muitimeter and MMC Step motor!";
                        DateTime r = DateTime.Now; // notification Time Cilck Button here!!
                        txtread.AppendText(r.ToString("r") + " <Notification!> " + incorrectness1 + Environment.NewLine);
                    }
                }

               
                if (Ptrs232.Checked)
                {
                    try
                    {
                        //section Rs232 for Agilent 34401A
                        //string VISA_ADDRESS = "ASRL5::INSTR";

                        //MyDMM.IO = (mgr1.Open(VISA_ADDRESS) as IMessage);
                        //MyDMM.IO.Timeout = 2000;

                        //MyDMM.WriteString("SYSTem:REMote");

                        //MyDMM.WriteString("Read?");
                        //string Bread = MyDMM.ReadString();
                        ////txtread.AppendText(Bread + Environment.NewLine);
                        

                        //section MMC-2 axis z
                        try
                        {
                            serialPort.PortName = "COM5";
                            // เปิดพอร์ต
                            serialPort.Open();

                            // ส่งข้อมูลผ่านพอร์ต
                            serialPort.WriteLine("P:4P0"); // กำหนดตัวกำหนด CR+LF
                            serialPort.WriteLine("P:5P2"); // ตั้งค่า baud rate เป็น 4800
                            serialPort.WriteLine("P:7P2"); // ตั้งค่า stop bits เป็น 2 บิต
                            serialPort.WriteLine("H:W");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }

                        //Show Rs-232 is connect completed
                        MessageBox.Show("Device is connect", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Connect.Text = "Remote";
                        Connect.BackColor = Color.LightGreen;
                        string rectify3 = "Remote Agilent HP34401A and MMC Step motor! By Port RS-232";
                        DateTime r = DateTime.Now; // notification Time Cilck Button here
                        txtread.AppendText(r.ToString("r") + " <Notification!> " + rectify3 + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }   
            }

            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }


        private void BtnDiconnect_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

                if (Ptrs232.Checked)
                {
                    serialPort.Close();
                }

                if (Ptgpib.Checked)
                {
                    MyDMM.IO.Close();
                    MyMMC.IO.Close();
                }

                Task.Delay(3000).Wait();
                MessageBox.Show("Device session is diconnect", "Diconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnDiconnect.BackColor = Color.LightBlue;
                BtnDiconnect.ForeColor = Color.White;
                Connect.BackColor = Color.Red;
                Connect.Text = "Unconnect";
                Connect.ForeColor = Color.White;
                string rectify2 = "Diconnect Agilent HP34401A and MMC Step motor!";
                DateTime r = DateTime.Now; // notification Time Cilck Button here!!
                txtread.AppendText(r.ToString("r") + " <Notification!> " + rectify2 + Environment.NewLine);
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                txtread.AppendText(ex.Message + Environment.NewLine);
            }
        
        }


        private void BtnMovestep_Click(object sender, EventArgs e)
        {
            string MSG1 = "M:XP10";
            MyMMC.WriteString(MSG1);
            string MStep = "G:";
            MyMMC.WriteString(MStep);

        }

        private void Btn_movestep500_Click(object sender, EventArgs e)
        {
            string MSG2 = "M:XP500";
            MyMMC.WriteString(MSG2);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_movestep1000_Click(object sender, EventArgs e)
        {
            if (Ptrs232.Checked)
            {
             
                serialPort.WriteLine("M:XP1000");
                serialPort.WriteLine("G:");
                txtread.AppendText("--> Motor step go 1000 step RS-232" + Environment.NewLine);
            }

            if (Ptgpib.Checked)
            {
                string MSG3 = "M:XP1000";
                MyMMC.WriteString(MSG3);
                string MStep = "G:";
                MyMMC.WriteString(MStep);
                txtread.AppendText("--> Motor step go 1000 step GPIB" + Environment.NewLine);
            }
            
        }

        private void Btn_ResetXY_Click(object sender, EventArgs e)
        {
            if (Ptrs232.Checked)
            {
                serialPort.WriteLine("H:W");
            }

            if (Ptgpib.Checked)
            {
                string RSG = "H:W";
                MyMMC.WriteString(RSG);
            }
            
        }
        private void Btn_stepY10_Click(object sender, EventArgs e)
        {
            string MSGY1 = "M:YP10";
            MyMMC.WriteString(MSGY1);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_stepY500_Click(object sender, EventArgs e)
        {
            string MSGY2 = "M:YP500";
            MyMMC.WriteString(MSGY2);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_stepY1000_Click(object sender, EventArgs e)
        {
            string MSGY3 = "M:YP1000";
            MyMMC.WriteString(MSGY3);
            string MStep = "G:";
            MyMMC.WriteString(MStep);
        }

        private void Btn_Cleardmm_Click(object sender, EventArgs e)
        {
            string command2 = "*RST";
            MyDMM.WriteString(command2);
            DateTime r = DateTime.Now; // notification Time Cilck Button here!!
            txtread.AppendText(r.ToString("r") + " <Notification!> " + command2 + Environment.NewLine);

        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            MyDMM.WriteString("SYSTem:ERRor?");
            string response1 = MyDMM.ReadString();
            DateTime r = DateTime.Now;
            txtread.AppendText(r.ToString("r") + " <ERROR!!!> " + response1 + Environment.NewLine);
        }


        private int Click1count = 0;
        private void Btn_SetAC_Click(object sender, EventArgs e)
        {
            try
            {

                Click1count++;

                switch (Click1count % 2)
                {
                    case 1:
                        if (Click1count % 2 == 1 && !isRunning)
                        {
                            isRunning = true;
                            Btn_SetAC.BackColor = Color.LightGreen;
                            Btn_SetAC.ForeColor = Color.Black;
                            Btn_SetAC.Text = "Runing";
                            Task.Run(() =>
                            {
                                try
                                {
                                    while (isRunning)
                                    {
                                        MyDMM.WriteString("MEAS:VOLT:AC? 1,1E-6");
                                        string dataAC = MyDMM.ReadString();
                                        Invoke(new Action(() => txtread.AppendText(dataAC + Environment.NewLine)));
                                        Task.Delay(500).Wait();

                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    Invoke(new Action(() => txtread.AppendText(ex.Message + Environment.NewLine)));
                                }

                            });
                        }

                        break;

                    case 0:
                        if (Click1count % 2 == 0 && isRunning)
                        {
                            isRunning = false;
                            Btn_SetAC.BackColor = Color.Pink;
                            Btn_SetAC.ForeColor = Color.Black;
                            Btn_SetAC.Text = "Stop";
                            MyDMM.IO.Clear();
                        }

                        break;
                }
            }

            catch (Exception ex)
            {
                DateTime r = DateTime.Now;
                txtread.AppendText(r.ToString("r") + " <ERROR!!!> " + ex.Message + Environment.NewLine);

            }
        }

        private bool isRunning = false;
        private int Clickcount = 0;
        private DateTime startTime;
        private string DataDC;

        private void Btn_SetDC_Click(object sender, EventArgs e)
        {

            try
            {

                Clickcount++;

                switch (Clickcount % 2)
                {
                    case 1:      
                        if (Clickcount %2 == 1 && !isRunning) 
                        {
                            isRunning = true;
                            Btn_SetDC.BackColor = Color.LightGreen;
                            Btn_SetDC.ForeColor = Color.Black;
                            Btn_SetDC.Text = "Runing";
                         
                            timer1.Enabled = true;
                            startTime = DateTime.Now;   
                            timer1.Start();

                            Task.Run(() =>
                            {
                            try
                            {
                                while (isRunning)
                                {
                                        MyDMM.WriteString("MEAS:VOLT:DC? ");
                                        string dataDC = MyDMM.ReadString();
                                        Invoke(new Action(() => txtread.AppendText(dataDC + Environment.NewLine)));
                                        Task.Delay(500).Wait();
                                    }
                                }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                Invoke(new Action(() => txtread.AppendText(ex.Message + Environment.NewLine)));
                            }
                                
                            });
                        }

                        break;
                       
                    case 0:
                        if (Clickcount %2 == 0 && isRunning) 
                        {
                            isRunning = false;
                            Btn_SetDC.BackColor = Color.Pink;
                            Btn_SetDC.ForeColor = Color.Black;
                            Btn_SetDC.Text = "Stop";
                            //MyDMM.IO.Clear();
                            
                            timer1.Stop();
                            timer1.Enabled = false;
                        }
                        
                        break;
                }
            }

            catch (Exception ex)
            {
                DateTime r = DateTime.Now;
                txtread.AppendText(r.ToString("r") + " <ERROR!!!> " + ex.Message + Environment.NewLine);
                
            }  
        }

        
        private void Btnenter_Click(object sender, EventArgs e)
        {
        

            if (!optAxis_x.Checked && !optAxis_y.Checked)
            {
                txtread.AppendText("กรุณาเลือกแกนก่อนดำเนินการ" + Environment.NewLine);
                Btnenter.BackColor = Color.Red;
                Btnenter.ForeColor = Color.White;
            }
            else
            {
                Btnenter.BackColor = Color.CadetBlue;
                string Sloop = txt_IPloop.Text;
                

                try
                {
                    if (optAxis_x.Checked)
                    {
                        txtread.AppendText("คุณกำลังเลือกแกน X" + Environment.NewLine);
                        int num1 = int.Parse(Sloop);
                        string str = "";
                        string MStep = "G:";
                        MyMMC.WriteString("M:XP50");

                        for (int i = 1; i <= num1; i++)
                        {
                            str = str + i.ToString() + Environment.NewLine;///

                            MyMMC.WriteString(MStep);
                            Thread.Sleep(100); // หน่วงเวลาให้มอเตอร์ทำงาน
                        }
                        txtread.AppendText(str + "ผลลัพธ์วน");

                        Thread.Sleep(700);

                    }

                    if (optAxis_y.Checked)
                    {
                        txtread.AppendText("คุณกำลังเลือกแกน Y" + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"issues = {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Sloop == "")
                {
                    txtread.AppendText("จำนวนรอบที่หมุนมอเตอร์ = 0 " + Environment.NewLine);
                }
                else
                {
                    txtread.AppendText("จำนวนรอบที่หมุนมอเตอร์ = " + Sloop + Environment.NewLine);
                }

                
                txt_IPloop.Clear();

            }


        }


        //int cnt = 0;
        private TimeSpan span;
        //private int saveCount = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtread.Text = (cnt++).ToString();
            span = DateTime.Now - startTime;
            txtread.Text = span.ToString(@"mm\:ss");

            DataRow rowi = dt.NewRow();

            //give data in Table 
            rowi["DCvolt"] = DataDC; //ตัวอย่างการบันทึกข้อมูล
            rowi["Time"] = span.ToString(@"mm\:ss");
            dt.Rows.Add(rowi);

            //saveCount++; //เพิ่มตัวนับทุกครั้งที่บันทึกข้อมูล

        }


        private void BtnExcel_Click(object sender, EventArgs e)
        {
            // Excel export data
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("sheetData");

            //create Row name
            var rowIndex = 0;
            var row = sheet.CreateRow(rowIndex);
            row.CreateCell(0).SetCellValue("Timer");
            row.CreateCell(1).SetCellValue("DCvoltage");
            row.CreateCell(2).SetCellValue("ACvoltage");
            rowIndex++;

          

            foreach (DataRow dr in dt.Rows)
            {
                row = sheet.CreateRow(rowIndex);
                row.CreateCell(0).SetCellValue(dr["Time"].ToString());
                row.CreateCell(1).SetCellValue(double.Parse(dr["DCvolt"].ToString()));
                rowIndex++;
            }

            //timer save file
            DateTime r = DateTime.Now;
            string timestamp = r.ToString("yyyyMMdd_HHmmss");
            //เรียกไฟล์มาเก็บ โฟลเดอร์นี้
            string localPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(localPath, $"outfile_{timestamp}.xlsx");

            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(stream);
            }
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

        }

    } 

}


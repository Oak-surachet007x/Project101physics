using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CodingLabpro.CommandDevice;
using CodingLabpro.frmChild;
using CodingLabpro.Models;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;
using Ivi.Visa.Interop;
using MathNet.Numerics.RootFinding;
using NPOI.HSSF.UserModel;
using NPOI.POIFS.Crypt.Dsig;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.Streaming.Values;
using NPOI.XSSF.UserModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace CodingLabpro
{
    public partial class FrmMain01 : Form
    {
        public Ivi.Visa.Interop.FormattedIO488 MyDMM;
        public Ivi.Visa.Interop.FormattedIO488 MyMMC;
        public SerialPort MySerialPort = new SerialPort();
        private readonly Stopwatch watch = new Stopwatch();
        private TimeSpan ctimeSpan;
        public DateTime r = DateTime.Now;
        public AxisControl frmChild1;
        private string result_time;
        public static string Aread;
        public static bool isConnect;
        public event EventHandler ActiveComboBox;
        public List<barMenu> barButton;
        private int Rows, Columns;
        private int IndexPostionX, IndexPostionY;

        //เมธอดเรียกคลาสสร้างตารางข้อมูล
        private IDataTableBuilder builder;
        private CalculateCellsDataTable cellsDataTable;


        public FrmMain01()
        {
            InitializeComponent();
            InitiallizeGridColumn();

            this.SetStyle(
                        ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            //Control Panel 
            BtnDiconnect.Enabled = false;
            BtnConnect.Enabled = true;
      

            //BarMenuButton
            barButton = new List<barMenu>() { barMenu1 };
            ClickBar(barButton);

            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            MyDMM = new Ivi.Visa.Interop.FormattedIO488();
            MyMMC = new Ivi.Visa.Interop.FormattedIO488();

            //Port GPIB
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();

            //SetUp FormChild in UserControl
            frmChild1 = new AxisControl(MyMMC, MySerialPort, MyDMM);

            //Stopwatch
            Stoptimer1.Enabled = true;
            Stoptimer1.Interval = 100;
            Stoptimer1.Tick += Stoptimer1_Tick;
            frmChild1.OnRunClicked += FrmChild1_OnRunClicked; 
            frmChild1.OnCancelClicked += FrmChild1_OnCancelClicked;
            frmChild1.OnMeasurement += Received_Data_measurement;
            frmChild1.OnMeasurementWithDisplay += Received_Data_Display_measurement;


            //First show Panel frmChild
            AddUserControl(frmChild1);
          

            if (this.FormChildpanel.Controls.Contains(frmChild1))
            {
                ActivateMenu1(barMenu1);
                Console.WriteLine("UserControl is add Panel Control ");
            }
            else
            {
                Console.WriteLine("UserControl is not add Panel Control");
            }

           
            //Find Device
            FindDevices finder = new FindDevices();
            finder.OnDeviceFound += (device) =>
            {
                Cblistaddress.Items.Add(device);
                Cblistaddress2.Items.Add(device);
            };
            finder.FDevice(); // Find devices from Port GPIB

            finder.OnDeviceFound1 += (device1) => { Cblistaddress3.Items.Add(device1); }; // Add devices to ComboBox for RS232
            finder.RSdevice(); // Find devices form Port RS232


            //Update Label Measurement
            ToolBtnError.Text = "Check Error\nDMM";
            ToolBtnClear.Text = "Clear Error\nDMM";


        }

        


        #region Stopwatch Control
        public string GetTimeString(TimeSpan elapsed)
        {
            result_time = string.Empty;
            ctimeSpan = elapsed;


            result_time = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                ctimeSpan.Hours,
                ctimeSpan.Minutes,
                ctimeSpan.Seconds,
                ctimeSpan.Milliseconds);

            return result_time;

        }

        private void Stoptimer1_Tick(object sender, EventArgs e)
        {
            LBtimer.Text = GetTimeString(watch.Elapsed);
        }

        private void FrmChild1_OnRunClicked()
        {
            ////Initialize DataGridview Measurement
            Rows = GlobalMeasurementSettings.Instance.CountOfRows;
            Columns = GlobalMeasurementSettings.Instance.CountOfColumns;

            //สร้าง DataTable สำหรับการวัด จากคลาส CalculateCellsDataTable
            builder = new CalculateCellsDataTable(Rows, Columns); //สร้างอินสแตนซ์ของ CalculateCellsDataTable
            dataTable_measurement = builder.BuildTable(); // สร้าง DataTable โดยใช้เมธอด BuildTable
            cellsDataTable = (CalculateCellsDataTable)builder; // <-- Assign the instance here
            cellsDataTable.DebugReport();

            //สร้าง DataTable และเชื่อมโยงกับ DataGridView
            Main_datagrid.Tables.Add(dataTable_measurement);
            BindingSource_DataMeasure.DataSource = dataTable_measurement;
            DgvMeasurement.DataSource = BindingSource_DataMeasure;

            //Reset Index Position
            IndexPostionX = 0;
            IndexPostionY = 0;

            //Start Stopwatch
            watch.Restart();

            //label timer color change
            LBtimer.BackColor = Color.Transparent;
            
        }

        private void FrmChild1_OnCancelClicked()
        {
            //Stop Stopwatch
            watch.Stop();

            //label timer color change
            LBtimer.BackColor = Color.Red;
        }

        #endregion

        private void UpdatelabelTypeMeasurement()
        {
            if (GlobalMeasurementSettings.Instance.SourceMode == "DC" && GlobalMeasurementSettings.Instance.MeasureMode == "Voltage")
            {
                LBunitmeasurement.Text = "VDC";
                
            }
            else if(GlobalMeasurementSettings.Instance.SourceMode == "DC" && GlobalMeasurementSettings.Instance.MeasureMode == "Current")
            {
                LBunitmeasurement.Text = "ADC";
            }
            else if (GlobalMeasurementSettings.Instance.SourceMode == "AC" && GlobalMeasurementSettings.Instance.MeasureMode == "Voltage")
            {
                LBunitmeasurement.Text = "VAC";
            }
            else if (GlobalMeasurementSettings.Instance.SourceMode == "AC" && GlobalMeasurementSettings.Instance.MeasureMode == "Current")
            {
                LBunitmeasurement.Text = "AAC";
            }
            else if (GlobalMeasurementSettings.Instance.MeasureMode == "Frequency")
            {
                LBunitmeasurement.Text = "Hz";
            }
            else
            {
                LBunitmeasurement.Text = "Mode";
            }

        }

        public void ShowMessage(string type, string message)
        {
            Form MessageNotify = new MessageBox_Notify(type, message);
            MessageNotify.Show();
        }

        //----------------------------------------------Button bar UI------------------------------------------------------------//

        #region barMenu Control
        //barMenu event Click tabcontrol
        public void ClickBar(List<barMenu> _barmenu)
        {
            foreach (var menu1 in _barmenu)
            {
                menu1.Bar_Click += Menu1_Bar_Click;
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            FormChildpanel.Controls.Clear();
            FormChildpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Menu1_Bar_Click(object sender, EventArgs e)
        {
            barMenu _barButton = (barMenu)sender;

            switch (_barButton.Name)
            {
                case "barMenu1":
                    ActivateMenu1(barMenu1);
                    AddUserControl(frmChild1);
                    break;

            }
        }

        private void ActivateMenu1(barMenu _active, params barMenu[] _inactive)
        {
            _active.BarColor = Color.Purple;

            foreach (barMenu inactive in _inactive)
            {
                inactive.BarColor = Color.White;
            }

        }
        #endregion

        

        //----------------------------------------------FrmMain event UI------------------------------------------------------------//
        private void FrmMain01_Load(object sender, EventArgs e)
        {
            Datetimenow.Start();
            ActiveComboBox += ComboBoxEnabled;
            GlobalMeasurementSettings.Instance.SettingsChanged += Instance_SettingsChanged;

        }

        private void Instance_SettingsChanged(object sender, EventArgs e)
        {
            UpdatelabelTypeMeasurement();
            
        }

        private void DataTimeNow_Tick(object sender, EventArgs e)
        {
            LBdatetime.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss tt");
        }

        #region Datagridview Measurement Control Result //จัดการตารางข้อมูล

        //เก็บชุดข้อมูลหลักของ DataGridView
        private readonly DataSet main_datagrid = new DataSet();
        private DataTable dataTable_measurement = new DataTable();
        public DataSet Main_datagrid => main_datagrid;

        //เมธอดตั้งค่าคอลัมน์ของ DataGridView
        public void InitiallizeGridColumn()
        {

            //ตั้งค่ารูปแบบของ DataGridView
            DgvMeasurement.DefaultCellStyle.ForeColor = Color.Black;
            DgvMeasurement.DefaultCellStyle.BackColor = Color.White;
            DgvMeasurement.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            DgvMeasurement.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            DgvMeasurement.DefaultCellStyle.Format = "E5"; // รูปแบบวิทยาศาสตร์ (Scientific Notation
            DgvMeasurement.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            DgvMeasurement.ColumnHeadersHeight = 50; // Set the desired height in pixels
            DgvMeasurement.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvMeasurement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        
        }

        //เมธอดแสดงหมายเลขแถวใน DataGridView
        // Source - https://stackoverflow.com/a
        // Posted by Gabriel Perez, modified by community. See post 'Timeline' for change history
        // Retrieved 2026-01-28, License - CC BY-SA 3.0
        private void DgvMeasurement_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView; // Cast sender to DataGridView
            var rowIdx = (e.RowIndex + 1).ToString(); // Get the row number (1-based index)

            var centerFormat = new StringFormat() // สร้างรูปแบบการจัดตำแหน่งข้อความ
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
      
        //เมธอดรับค่าข้อมูลการวัดและอัปเดตตาราง
        public void Received_Data_measurement(double Data_measure)
        {
            cellsDataTable.UpdateCell(IndexPostionY, IndexPostionX, Data_measure);

            IndexPostionX++;

            if (IndexPostionX >= Columns)
            {
                IndexPostionX = 0;
                IndexPostionY++;
            }

        }

        private void Received_Data_Display_measurement(double Data_Display)
        {
            LBvaluemeasurement.Text = Data_Display.ToString() + GlobalMeasurementSettings.Instance.UnitPrefix;
        }

      


        #endregion

        #region Export DataGridview to file Data Control

        private IWorkbook workbook { get; set; }

        //เมธอดการสร้างชีทและส่วนหัวของตาราง
        private ISheet createSheetAndHeader(DataTable dt, string sheetName, ICellStyle customStyle)
        {
            ISheet sheeti = this.workbook.CreateSheet(sheetName);
            //--- add 1 header row
            int currentRow = 0;
            IRow rowSheet = sheeti.CreateRow(currentRow);
            for (int c = 0; c < dt.Columns.Count; c++)
            {
                var cellc = rowSheet.CreateCell(c);
                cellc.SetCellValue(dt.Columns[c].ColumnName);
                cellc.CellStyle = customStyle;
                
            }
            return sheeti;
        }

        //เมธอดการตั้งค่า Excel และบันทึกไฟล์
        protected void DataExcelConfigure(string filePath, DataTable dt)
        {
            //Create Excel
            this.workbook = new XSSFWorkbook();

            // Create the style object
            ICellStyle customStyle = this.workbook.CreateCellStyle();
            // Define a thin border for the top and bottom of the cell
            customStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            customStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            customStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            // Create a font object and make it bold
            var customFont = this.workbook.CreateFont();
            customFont.IsBold = true;
            customFont.FontName = "Microsoft Sans Serif";
            customFont.FontHeightInPoints = 10;
            // Assign the font to the style
            customStyle.SetFont(customFont);

            // Create sheet and add header
            int sheetCount = 1;
            string sheetName = "Sheet" + sheetCount++;
            ISheet sheeti = createSheetAndHeader(dt, sheetName, customStyle);

            // Add data rows
            IDataFormat dataFormat = workbook.CreateDataFormat();
            ICellStyle sciStyle = this.workbook.CreateCellStyle();
            sciStyle.DataFormat = dataFormat.GetFormat("0.00000E+00");

            for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
            {
                IRow dataRow = sheeti.CreateRow(rowIndex + 1);
                for (int columnIndex = 0; columnIndex < dt.Columns.Count; columnIndex++)
                {

                    var cell = dataRow.CreateCell(columnIndex);
                    object value = dt.Rows[rowIndex][columnIndex]; // สร้างตัวแปรชนิด object เพื่อเก็บค่า 

                    if (value != DBNull.Value)
                    {
                        if (double.TryParse(value.ToString(), out double numericValue))
                        {
                            cell.SetCellValue(numericValue);
                            cell.CellStyle = sciStyle;
                        }
                    }
                    else
                    {
                        cell.SetCellValue(string.Empty); // กรณีค่าเป็น DBNull ให้ใส่ค่าว่าง
                    }

                    //Auto Size Column
                    sheeti.AutoSizeColumn(columnIndex);

                }

                // รายงานความคืบหน้า
                int progressPercentage = (int)((rowIndex + 1) / (double)dt.Rows.Count * 100);
                backgroundWorker.ReportProgress(progressPercentage);
            }

           
            //Add file data and export excel
            string filename = filePath;
            using (var fileData = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                this.workbook.Write(fileData);
            }
        }

        //เมธอดปุ่ม Export ข้อมูลไปยัง Excel
        private void ToolBtnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog1.Title = "Save a File";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.OverwritePrompt = true; // Warns if the file already exists
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            saveFileDialog1.FileName = $"MeasurementData_{timestamp}.xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileSavePath = saveFileDialog1.FileName;
                LBExportFile.Text = $"Preparing to save : {fileSavePath}"; // อัปเดตข้อความสถานะ กำลังเตรียมบันทึกไฟล์
                LBStatusLoading.Visible = true; // แสดงป้ายสถานะการโหลด

                if (!backgroundWorker.IsBusy)
                {
                    // เริ่ม BackgroundWorker พร้อมส่งข้อมูลที่จำเป็น
                    backgroundWorker.RunWorkerAsync(new { FilePath = fileSavePath, DataTable = dataTable_measurement });
                }
            }
        }

        // BackgroundWorker: อัปเดตความคืบหน้า (ถ้ามี)
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LBStatusLoading.Text = $"Progress: {e.ProgressPercentage}%";
        }

        // BackgroundWorker: ทำงานในเธรดเบื้องหลัง
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            dynamic args = e.Argument;
            string filePath = args.FilePath;
            DataTable dataTable = args.DataTable;

            // เรียกใช้เมธอด DataExcelConfigure ในเธรดเบื้องหลัง
            DataExcelConfigure(filePath, dataTable);
        }

        // BackgroundWorker: อัปเดต UI เมื่อเสร็จสิ้น
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // แสดงข้อความเมื่อเกิดข้อผิดพลาด
                ShowMessage("ERROR", $"Failed to export Excel file: {e.Error.Message}");
            }
            else
            {
                // แสดงข้อความเมื่อสำเร็จ
                ShowMessage("OK", "Excel file exported successfully!");
                LBStatusLoading.Visible = false; // ซ่อนป้ายสถานะการโหลด
                LBExportFile.Text = "Export completed."; // อัปเดตข้อความสถานะ
            }
        }

        //เมธอดปุ่ม Export ข้อมูลไปยัง CSV
        private void ToolBtnExport_csv_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files|*.csv";
            saveFileDialog1.Title = "Save a File";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.OverwritePrompt = true; // Warns if the file already exists
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            saveFileDialog1.FileName = $"MeasurementData_{timestamp}.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileSavePath = saveFileDialog1.FileName;
                LBExportFile.Text = $"Saving to : {fileSavePath}"; // อัปเดตข้อความสถานะ กำลังบันทึกไฟล์
                try
                {
                    using (StreamWriter writer = new StreamWriter(fileSavePath))
                    {
                        // เขียนส่วนหัวของคอลัมน์
                        for (int i = 0; i < dataTable_measurement.Columns.Count; i++)
                        {
                            writer.Write(dataTable_measurement.Columns[i].ColumnName);
                            if (i < dataTable_measurement.Columns.Count - 1)
                                writer.Write(","); // คั่นด้วยเครื่องหมายจุลภาค
                        }
                        writer.WriteLine();
                        // เขียนข้อมูลแต่ละแถว
                        foreach (DataRow row in dataTable_measurement.Rows)
                        {
                            for (int i = 0; i < dataTable_measurement.Columns.Count; i++)
                            {
                                writer.Write(row[i].ToString());
                                if (i < dataTable_measurement.Columns.Count - 1)
                                    writer.Write(","); // คั่นด้วยเครื่องหมายจุลภาค
                            }
                            writer.WriteLine();
                        }
                    }
                    ShowMessage("OK", "CSV file exported successfully!");
                    LBExportFile.Text = "Export completed."; // อัปเดตข้อความสถานะ
                }
                catch (Exception ex)
                {
                    ShowMessage("ERROR", $"Failed to export CSV file: {ex.Message}");
                }
            }

        }

        #endregion

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

        public class COMException : System.Runtime.InteropServices.ExternalException
        {

        }

        private void FrmMain01_SizeChanged(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                labelName.Font = new Font(labelName.Font.FontFamily, 8);
                Cblistaddress.Size = new Size(290, 29);
                Cblistaddress2.Size = new Size(290, 29);
                Cblistaddress3.Size = new Size(263, 29);

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // คอลัมน์แรกกว้าง 100%
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // คอลัมน์ที่สองปรับอัตโนมัติ
            }

        }

        public void ComboBoxEnabled(Object sender, EventArgs e)
        {
            if (!isConnect)
            {
                BtnConnect.Enabled = false;
                BtnDiconnect.Enabled = true;

                Cblistaddress.Enabled = false;
                Cblistaddress2.Enabled = false;
                Cblistaddress3.Enabled = false;

                if(Cblistaddress.SelectedIndex >= 0)
                {
                    StatusPort1.BackColor = Color.LightGreen;
                    StatusPort1.Text = "CONNECT";

                }

                if (Cblistaddress2.SelectedIndex >= 0)
                {
                    StatusPort2.BackColor = Color.LightGreen;
                    StatusPort2.Text = "CONNECT";

                }

                if (Cblistaddress3.SelectedIndex >= 0)
                {
                    StatusPort3.BackColor = Color.LightGreen;
                    StatusPort3.Text = "CONNECT";

                }

            }
            else  
            {
                BtnConnect.Enabled = true;
                BtnDiconnect.Enabled = false;

                Cblistaddress.Enabled = true; 
                Cblistaddress2.Enabled = true;
                Cblistaddress3.Enabled= true;

                
            }
        }
        
        public static bool CheckPort(params System.Windows.Forms.ComboBox[] comboBoxes)
        {

            foreach (var CBox in comboBoxes)
            {
                if (CBox != null && CBox.SelectedItem != null)
                {
                    Debug.WriteLine("[ComboBox]: false");
                    return false;
                }
            }
            Debug.WriteLine("[ComboBox]: true");
            return true;
            
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //CONNECT DMM
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();

            //CONNECT MMC
            Ivi.Visa.Interop.ResourceManager mgr2;
            mgr2 = new Ivi.Visa.Interop.ResourceManager();

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            //ตรวจสอบว่ามีการเลือกไอเทมใน ComboBox ทั้ง 3 ช่องไหม
            if (CheckPort(Cblistaddress,Cblistaddress2,Cblistaddress3))
            {
                //MessageBox.Show("you Should Select Port Device");
                BtnConnect.BackColor = Color.Orange;
                BtnConnect.Text = "Warning";
                BtnConnect.ForeColor = Color.White;

                ShowMessage("WARNING","you Should Port Device");

            }
            else
            {
                try
                {
                    if (Cblistaddress.SelectedIndex >= 0)
                    {
                        //CONNECT driver DMM Port GP - IB
                        string addr = Cblistaddress.SelectedItem.ToString();
                        MyDMM.IO = (IMessage)mgr1.Open(addr, AccessMode.NO_LOCK, 2000, null);
                        MyDMM.IO.Timeout = 10000;
                        string command = "*IDN?";
                        MyDMM.WriteString(command);

                        Aread = MyDMM.ReadString(); 
                        //MyDMM.WriteString("*CLS");
                    }

                    if (Cblistaddress2.SelectedIndex >= 0)
                    {
                        //CONNECT driver MMC Port GP-IB
                        string MMCaddr = Cblistaddress2.SelectedItem.ToString();
                        MyMMC.IO = (IMessage)mgr2.Open(MMCaddr);
                        MyMMC.IO.Timeout = 5000;
                        string MSG = "H:W";
                        MyMMC.WriteString(MSG);

                    }

                    if (Cblistaddress3.SelectedIndex >= 0)
                    {
                        //Port RS232 Setting
                        MySerialPort.PortName = Cblistaddress3.SelectedItem.ToString();
                        MySerialPort.BaudRate = 9600; // ตั้งค่า Baud Rate
                        MySerialPort.Parity = Parity.None; // ตั้งค่า Parity
                        MySerialPort.StopBits = StopBits.One; // ตั้งค่า Stop Bits
                        MySerialPort.DataBits = 8; // ตั้งค่าจำนวน Data Bits
                        MySerialPort.Handshake = Handshake.None; // ตั้งค่า Handshake


                        ////CONNET driver MMC Port RS-232
                        MySerialPort.Open();
                        MySerialPort.WriteLine("H:X");

                    }

                    List<string> listDevice = new List<string>{Cblistaddress.Text, Cblistaddress2.Text, Cblistaddress3.Text };
                    ShowMessage("OK", r.ToString("r") + $"\nPort Driver Connected\n{Aread}" + $"{string.Join("\n",listDevice)}");

                    ActiveComboBox?.Invoke(this, EventArgs.Empty);
                    isConnect = true;
                    BtnConnect.Text = "Remote";
                    BtnConnect.BackColor = Color.LightGreen;
                }
                catch (Exception ex)
                {
                    isConnect = false;
                    BtnConnect.BackColor = Color.Red;
                    BtnConnect.Text = "Unconnect";
                    BtnConnect.ForeColor = Color.White;
                   
                    ShowMessage("ERROR", r.ToString("r") + "\nCannot Find driver Agilent Muitimeter and MMC Step motor!" + Environment.NewLine + ex.Message);
                  
                }

            }
                
        }

        private void BtnDiconnect_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (Cblistaddress.SelectedIndex >= 0)
                {
                    MyDMM.IO.Close();
                    StatusPort1.BackColor = Color.Red;
                    StatusPort1.Text = "DiCONNECT";
                }

                if (Cblistaddress2.SelectedIndex >= 0)
                {
                    MyMMC.IO.Close();
                    StatusPort2.BackColor = Color.Red;
                    StatusPort2.Text = "DiCONNECT";
                }

                if (Cblistaddress3.SelectedIndex >= 0)
                {
                    if (MySerialPort.IsOpen)
                    {
                        MySerialPort.Close();
                    }

                    StatusPort3.BackColor = Color.Red;
                    StatusPort3.Text = "DiCONNECT";
                }

                Task.Delay(5000).Wait();

                ActiveComboBox?.Invoke(this, EventArgs.Empty);
                isConnect = false;
                BtnConnect.BackColor = Color.Transparent;
                BtnConnect.Text = "CONNECT";
                BtnConnect.ForeColor = Color.Black;

                

            }
            catch (VisaException ex)
            {
                ShowMessage("ERROR", r.ToString("r") + "\nCannot DiConnect Devices" + Environment.NewLine + ex.Message);
            }

            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        private void ToolBtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                MyDMM.WriteString("*CLS");  //Clear Error
                ShowMessage("OK", "Clear Error DMM Successfully");
            }
            catch (Exception ex) 
            {
                ShowMessage("ERROR", $"Please Connect Device Agilent Multimeter \n {ex.Message}");
            }

        }

        private void ToolBtnError_Click(object sender, EventArgs e)
        {
            try
            {
                MyDMM.WriteString("SYST:ERR?");  //Read Error
                string ErrorDmm = MyDMM.ReadString();
                ShowMessage("ERROR", ErrorDmm);

            }
            catch (Exception ex)
            {
                ShowMessage("ERROR", $"Please Connect Device Agilent Multimeter \n {ex.Message}");

            }
               
        }
    }
}
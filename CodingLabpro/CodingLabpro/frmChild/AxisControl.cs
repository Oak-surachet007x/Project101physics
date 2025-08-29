using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodingLabpro.CommandDevice;
using CodingLabpro.Models;
using Ivi.Visa;
using NPOI.POIFS.Crypt.Dsig;
using NPOI.Util;

namespace CodingLabpro.frmChild
{
    public partial class AxisControl : UserControl
    {
        private readonly Ivi.Visa.Interop.FormattedIO488 myMMC;
        private readonly SerialPort mySerialPort;
        private readonly Ivi.Visa.Interop.FormattedIO488 myDMM;
        private string StepMotor_Selected;
        private string ValueProcessX;
        private string ValueProcessY;
        private string ValueNegativeX;
        private int ValueTimer;
        private int LoopAreaX;
        private int LoopAreaY;
        public event Action OnRunClicked;
        public event Action OnCancelClicked;


        public AxisControl(Ivi.Visa.Interop.FormattedIO488 myMMC, SerialPort mySerialPort, Ivi.Visa.Interop.FormattedIO488 myDMM)
        {
            InitializeComponent();
            //send value interface from frmMain01
            this.myMMC = myMMC;
            this.mySerialPort = mySerialPort;
            this.myDMM = myDMM;
            //Setup Value
            CblStepMotor.Items.AddRange(new string[] { "100", "200", "300", "400", "500", "1000" });
            unitXComboBox.Items.AddRange(new string[] { "cm", "mm", "μm" });
            unitYComboBox.Items.AddRange(new string[] { "cm", "mm", "μm" });
            delaySteppingComboBox.Items.AddRange(new string[] {"1000", "2000", "3000" });
            CBtrigger.Items.AddRange(new string[] {"IMMediate", "BUS", "EXTernal"});

            RB_resolution4digits.Text = "4\u00BD digits";
            RB_resolution6digits.Text = "6\u00BD digits";

            
          


        }

        #region SettingMeasurement Agilent
        private void UIControlDisabled(bool EnabledItem)
        {
     
            RB_resolution4digits.Enabled = !EnabledItem;
            RB_resolution6digits.Enabled = !EnabledItem;
            RB_resolutionCustom.Enabled = !EnabledItem;
            RB_resolutionAuto.Enabled = !EnabledItem;
            RB_autorange.Enabled = !EnabledItem;
            RB_Customrange.Enabled = !EnabledItem;
            RB_autoON.Enabled = !EnabledItem;
            RB_autoOFF.Enabled = !EnabledItem;
            RB_autoOnce.Enabled = !EnabledItem;
    
        }
        private void AxisControl_Load(object sender, EventArgs e)
        {
            InputValue_area.DataSource = new CalculateArea_Bind();
            ButtonPortEnabled();
            UIControlDisabled(true);
            CBrange.Enabled = false;
            Numeric_Range.Enabled = false;
            Numeric_Resolution.Enabled = false;
            Range_Control_Measurement();

        }

        private void RB_rs232_CheckedChanged(object sender, EventArgs e)
        {
            ButtonPortEnabled();
        }

        private void RB_gpib_CheckedChanged(object sender, EventArgs e)
        {
            ButtonPortEnabled();
        }

        private string ValueStepping()
        {
            if (CblStepMotor.SelectedItem != null)
            {
                StepMotor_Selected = CblStepMotor.SelectedItem.ToString();
                return StepMotor_Selected;
            }
            else
            {
                return "null";
            }
            
        }

        private void CBtrigger_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.TriggerMode = CBtrigger.SelectedItem.ToString();

            switch (GlobalMeasurementSettings.Instance.TriggerMode)
            {
                case "IMMediate":
                    GlobalMeasurementSettings.Instance.TriggerMode = "IMMediate";
                    Debug.WriteLine(GlobalMeasurementSettings.Instance.TriggerMode);
                    break;
                case "BUS":
                    GlobalMeasurementSettings.Instance.TriggerMode = "BUS";
                    Debug.WriteLine(GlobalMeasurementSettings.Instance.TriggerMode);
                    break;
                case "EXTernal":
                    GlobalMeasurementSettings.Instance.TriggerMode = "EXTernal";
                    Debug.WriteLine(GlobalMeasurementSettings.Instance.TriggerMode);
                    break;
                default:
                    CBtrigger.SelectedIndex = -1;
                    GlobalMeasurementSettings.Instance.TriggerMode = "";
                    Debug.WriteLine("Not Found Trigger Measurement");
                    break;


            }
        }
        private void RBvoltage_CheckedChanged(object sender, EventArgs e)
        {
            Range_Control_Measurement();
            UIControlDisabled(false);
            GlobalMeasurementSettings.Instance.MeasureMode = "Voltage";
   
            
        }

        private void RBcurrent_CheckedChanged(object sender, EventArgs e)
        {
            Range_Control_Measurement();
            UIControlDisabled(false);
            GlobalMeasurementSettings.Instance.MeasureMode = "Current";
        }

        private void RBsource_DC_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.SourceMode = "DC";
        }
        private void RBsource_AC_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.SourceMode = "AC";
        }

        private void RB_autoOFF_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.AutozeroMode = "OFF";
        }

        private void RB_autoON_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.AutozeroMode = "ON";
        }
        private void RB_autoOnce_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.AutozeroMode = "ONCE";
        }
        private void RB_autorange_CheckedChanged(object sender, EventArgs e)
        {
            Range_Control_Measurement();
        }
        private void RB_Customrange_CheckedChanged(object sender, EventArgs e)
        {
            Range_Control_Measurement();
        }
        private void RB_resolutionAuto_CheckedChanged(object sender, EventArgs e)
        {
            Numeric_Resolution.Enabled = false;
        }
        private void RB_resolutionCustom_CheckedChanged(object sender, EventArgs e)
        {
            Numeric_Resolution.Enabled = true;
        }
        private void Range_Control_Measurement()
        {
            if (RB_autorange.Checked)
            {
                CBrange.Enabled = false;
                Numeric_Range.Enabled = false;
            }
            else if (RB_Customrange.Checked)
            {
                CBrange.Enabled = true;
                Numeric_Range.Enabled = true;
                RangeUnitMeasurement();
            }
    
        }

        private void RangeUnitMeasurement()
        {
            if (RBvoltage.Checked)
            {
                CBrange.Items.Clear();
                CBrange.Text = "";
                CBrange.Items.AddRange(new string[] { "V", "mV" });
            }
            else if (RBcurrent.Checked)
            {
                CBrange.Items.Clear();
                CBrange.Text = "";
                CBrange.Items.AddRange(new string[] { "A", "mA" });
            }
        }

        private string Range_Indicator(double value)
        {
            if (RB_autorange.Checked)
            {

            }
            else if (RB_Customrange.Checked)
            {
                if (RBvoltage.Checked)
                {
                    switch (CBrange.SelectedItem.ToString())
                    {
                        case "V":
                            return "";
                          
                        case "mV":
                            return "0.001";
                    }
                }
                else if (RBcurrent.Checked)
                {

                }
            }
            return "";
        }

        private void SetupMeasurementCommand()
        {
            string Range_result = Range_Indicator(0.001);

            if (GlobalMeasurementSettings.Instance.MeasureMode == "Voltage" && GlobalMeasurementSettings.Instance.SourceMode == "DC")
            {
               if(GlobalMeasurementSettings.Instance.TriggerMode == "BUS")
               {
                    myDMM.WriteString($"CONF:VOLT:DC , 0.003");
                    myDMM.WriteString("TRIGger:SOURce BUS");
                    if(GlobalMeasurementSettings.Instance.AutozeroMode == "ON")
                    {
                        myDMM.WriteString("ZERO:AUTO ON");
                    }
                    else if(GlobalMeasurementSettings.Instance.AutozeroMode == "OFF")
                    {
                        myDMM.WriteString("ZERO:AUTO OFF");
                    }
                    else if(GlobalMeasurementSettings.Instance.AutozeroMode == "ONCE")
                    {
                        myDMM.WriteString("ZERO:AUTO ONCE");
                    }
                    else
                    {
                        throw new InvalidOperationException("Unknown AutozeroMode: " + GlobalMeasurementSettings.Instance.AutozeroMode);
                    }
                    myDMM.WriteString("INIT");
                    myDMM.WriteString("*TRG"); //if Select Trigger_Source == BUS will accept command IEEE-488
                    myDMM.WriteString("FETC?");

               }
               else if(GlobalMeasurementSettings.Instance.TriggerMode == "EXTernal")
               {
                    myDMM.WriteString("CON:VOLT:DC 10, 0.003");
                    myDMM.WriteString("TRIGger:SOURce EXTernal");
                    myDMM.WriteString("READ?");
               }
               else if(GlobalMeasurementSettings.Instance.TriggerMode == "IMMediate")
               {

               }


            }

        }

        private void ShowValidatorError(Control parent, EntityValidator entityclass)
        {
            if (parent is null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            foreach (Control control in this.Controls)
            {
                string propName = control.DataBindings["Text"]?.BindingMemberInfo.BindingField;
                if (!string.IsNullOrEmpty(propName))
                {
                    string error = entityclass[propName]; // Trigger IDataErrorInfo
                    errorProvider1.SetError(control, error);
                }

            }
        }

        #endregion

        public void ShowMessage(string type, string message)
        {
            Form MessageNotify = new MessageBox_Notify(type, message);
            MessageNotify.Show();
        }

        private void MMC_Write(string command)
        {
            try
            {
                if (RB_gpib.Checked)
                {
                    myMMC.WriteString(command);
                    myMMC.WriteString("G:");
                    Debug.WriteLine("Status== GPIB");
                }else if (RB_rs232.Checked)
                {
                    mySerialPort.WriteLine(command);
                    mySerialPort.WriteLine("G:");
                    Debug.WriteLine("Status== Rs232");
                }
         
            }
            catch (Exception Ex){
                ShowMessage("ERROR", "Can't Drive SteppingMotor\n " + Ex.Message);
            }
        }

        private void ButtonPortEnabled()
        {
            if (RB_rs232.Checked)
            {
                Btn_YUp.BackColor = Color.Red;
                Btn_YDown.BackColor = Color.Red;
                Btn_YUp.Enabled = false;
                Btn_YDown.Enabled = false;
            

            }
            else if (RB_gpib.Checked)
            {
                Btn_YUp.BackColor = Color.White;
                Btn_YDown.BackColor = Color.White;
                Btn_YUp.Enabled = true;
                Btn_YDown.Enabled = true; 
                Btn_runscaning.Enabled = true;

            }
            else
            {
                Debug.WriteLine("กรุณาเลือกพอร์ตการเชื่อมต่อในการควบคุม GPIB or RS232");
                Btn_runscaning.Enabled = false;
      
            }
        }

        #region Button Control movement
        private void Btn_ResetHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (RB_gpib.Checked)
                {
                    myMMC.WriteString("H:W");
                }
                else if (RB_rs232.Checked)
                {
                    mySerialPort.WriteLine("H:W");
                }
                ShowMessage("INFO", "Reset Process Motor");
            }
            catch (Exception Ex)
            {
                ShowMessage("ERROR", Ex.Message);
            }
      
        }

        private void Btn_stopmotor_Click(object sender, EventArgs e)
        {
            try
            {
                if (RB_gpib.Checked)
                {
                    myMMC.WriteString("L:E");
    
                }else if (RB_rs232.Checked)
                {
                    mySerialPort.WriteLine("L:E");
                }
                ShowMessage("INFO", "Stop Process Motor");
            }
            catch (Exception Ex)
            {
                ShowMessage("ERROR", Ex.Message);
            }
        }

        
        private void Btn_XLeft_Click(object sender, EventArgs e)
        {
            switch (ValueStepping()) {
                case "100":
                    MMC_Write("M:XP100");
                    ShowMessage("INFO", "M:XP100");
                    break;
                case "200":
                    MMC_Write("M:XP200");
                    ShowMessage("INFO", "M:XP200");
                    break;
                case "300":
                    MMC_Write("M:XP300");
                    ShowMessage("INFO", "M:XP300");
                    break;
                case "400":
                    MMC_Write("M:XP400");
                    ShowMessage("INFO", "M:XP400");
                    break;
                case "500":
                    MMC_Write("M:XP500");
                    ShowMessage("INFO", "M:XP500");
                    break;
                case "1000":
                    MMC_Write("M:XP1000");
                    ShowMessage("INFO", "M:XP1000");
                    break;
                default:
                    ShowMessage("ERROR",  "กรุณาเลือกสเต็ปการขับมอเตอร์ "+ ValueStepping());
                    break;
            }
        }

        private void Btn_YUp_Click(object sender, EventArgs e)
        {
            switch (ValueStepping())
            {
                case "100":
                    MMC_Write("M:YP100");
                    ShowMessage("INFO", "M:YP100");
                    break;
                case "200":
                    MMC_Write("M:YP200");
                    ShowMessage("INFO", "M:YP200");
                    break;
                case "300":
                    MMC_Write("M:YP300");
                    ShowMessage("INFO", "M:YP300");
                    break;
                case "400":
                    MMC_Write("M:YP400");
                    ShowMessage("INFO", "M:YP400");
                    break;
                case "500":
                    MMC_Write("M:YP500");
                    ShowMessage("INFO", "M:YP500");
                    break;
                case "1000":
                    MMC_Write("M:YP1000");
                    ShowMessage("INFO", "M:YP1000");
                    break;
                default:
                    ShowMessage("ERROR", "กรุณาเลือกสเต็ปการขับมอเตอร์ " + ValueStepping());
                    break;
            }
        }

        private void Btn_XRight_Click(object sender, EventArgs e)
        {
            switch (ValueStepping())
            {
                case "100":
                    MMC_Write("M:XP-100");
                    ShowMessage("INFO", "M:XP-100");
                    break;
                case "200":
                    MMC_Write("M:XP-200");
                    ShowMessage("INFO", "M:XP-200");
                    break;
                case "300":
                    MMC_Write("M:XP-300");
                    ShowMessage("INFO", "M:XP-300");
                    break;
                case "400":
                    MMC_Write("M:XP-400");
                    ShowMessage("INFO", "M:XP-400");
                    break;
                case "500":
                    MMC_Write("M:XP-500");
                    ShowMessage("INFO", "M:XP-500");
                    break;
                case "1000":
                    MMC_Write("M:XP-1000");
                    ShowMessage("INFO", "M:XP-1000");
                    break;
                default:
                    ShowMessage("ERROR", "กรุณาเลือกสเต็ปการขับมอเตอร์ " + ValueStepping());
                    break;

            }
        }

        private void Btn_YDown_Click(object sender, EventArgs e)
        {
            switch (ValueStepping())
            {
                case "100":
                    MMC_Write("M:YP-100");
                    ShowMessage("INFO", "M:YP-100");
                    break;
                case "200":
                    MMC_Write("M:YP-200");
                    ShowMessage("INFO", "M:YP-200");
                    break;
                case "300":
                    MMC_Write("M:YP-300");
                    ShowMessage("INFO", "M:YP-300");
                    break;
                case "400":
                    MMC_Write("M:YP-400");
                    ShowMessage("INFO", "M:YP-400");
                    break;
                case "500":
                    MMC_Write("M:YP-500");
                    ShowMessage("INFO", "M:YP-500");
                    break;
                case "1000":
                    MMC_Write("M:YP-1000");
                    ShowMessage("INFO", "M:YP-1000");
                    break;
                default:
                    ShowMessage("ERROR", "กรุณาเลือกสเต็ปการขับมอเตอร์ " + ValueStepping());
                    break;
            }
        }

        #endregion

        #region CalculateMovement 
        private static string MovementPositiveX(string MovestepX, string Unit)
        {
            if (Unit == "cm")
            {
                int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -2)) * 1) / (2 * Math.Pow(10, -6)));
                return $"M:XP{MathValueX}";
            }
            else if (Unit == "mm")
            {
                int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -3)) * 1) / (2 * Math.Pow(10, -6)));
                return $"M:XP{MathValueX}";

            }
            else if (Unit == "μm")
            {
                if ((float.Parse(MovestepX) >= 2))
                {
                    int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -6)) * 1) / (2 * Math.Pow(10, -6)));
                    return $"M:XP{MathValueX}";
                }
            }

            return "ERROR: Value Begin 2 μm";
        }

        private static string MovementPositiveY(string MovestepY, string Unit)
        {
            if (Unit == "cm")
            {
                int MathValueY = (int)(((float.Parse(MovestepY) * Math.Pow(10, -2)) * 1) / (2 * Math.Pow(10, -6))); 
                return $"M:YP{MathValueY}";
            }
            else if (Unit == "mm")
            {
                int MathValueY = (int)(((float.Parse(MovestepY) * Math.Pow(10, -3)) * 1) / (2 * Math.Pow(10, -6))); 
                return $"M:YP{MathValueY}";
                
            }else if (Unit == "μm")
            {
                if ((float.Parse(MovestepY) >= 2))
                {
                    int MathValueY = (int)(((float.Parse(MovestepY) * Math.Pow(10, -6)) * 1) / (2 * Math.Pow(10, -6)));
                    return $"M:YP{MathValueY}";
                }
            }

            return "ERROR: Value Begin 2 μm"; 
        }

        private static string MovementNegativeX(string MovestepX, string Unit)
        {
            if (Unit == "cm")
            {
                int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -2)) * 1) / (2 * Math.Pow(10, -6)));
                return $"M:XP-{MathValueX}";
            }
            else if (Unit == "mm")
            {
                int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -3)) * 1) / (2 * Math.Pow(10, -6)));
                return $"M:XP-{MathValueX}";

            }
            else if (Unit == "μm")
            {
                if ((float.Parse(MovestepX) >= 2))
                {
                    int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -6)) * 1) / (2 * Math.Pow(10, -6)));
                    return $"M:XP-{MathValueX}";
                }
            }

            return "ERROR: Value Begin 2 μm";

        }

        #endregion

        #region Methods ScaningArea
        private async void Btn_runscaning_Click(object sender, EventArgs e)
        {
            try
            {
                //clear Textbox
                Reportdata.Clear();

                // Requitment Class
                CalculateArea_Bind calculate = InputValue_area.Current as CalculateArea_Bind;
                calculate.EnableValidation = true;
                InputValue_area.EndEdit();
                //ErrorProvider
                ShowValidatorError(this, calculate);
 
                if (calculate != null)
                {
                    if (calculate.IsValid)
                    {
                        //เก็บตัวแปรเรียกใช้ต่อในคลาสย่อย แล้วคืนค่าตามเงื่อนไข
                        ValueProcessX = MovementPositiveX(calculate.MoveStepX, calculate.UnitX);
                        ValueProcessY = MovementPositiveY(calculate.MoveStepY, calculate.UnitY);
                        ValueNegativeX = MovementNegativeX(calculate.MoveStepX, calculate.UnitX);
                        ValueTimer = calculate.ReturnTimer();
                        LoopAreaX = calculate.CalareaScanningX();
                        LoopAreaY = calculate.CalareaScanningY();

                    }

                    ValidationContext context = new ValidationContext(calculate, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    string results = "";
                    if (!Validator.TryValidateObject(calculate, context, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            results = results + result.ErrorMessage + Environment.NewLine;

                        }
                        //MessageBox.Show(results, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ShowMessage("ERROR", $"{results}");
                        return;
                    }
                }

                //Run Scaning
                //myMMC.WriteString("H:W");
                //await Task.Delay(5000);
                //myMMC.WriteString("M:WP5000  P-5000");  //<<--- ถอยหลังไปเริ่มต้นที่ชิดกำแพง Y == 0 cm
                //myMMC.WriteString("G:");
                //await Task.Delay(5000);

                //Run Measurement
                SetupMeasurementCommand();
                //Stopwatch
                OnRunClicked?.Invoke();
                //Report Area Calculate
                Reportdata.AppendText($" คำนวณผลลัพธ์ลูปที่สแกนของ X คือ {LoopAreaX} ลูป \n คำนวณผลลัพธ์ลูปที่สแกนของ Y คือ {LoopAreaY} ลูป" + Environment.NewLine); //<--สรุปผลลัพธ์สแกนทั้งหมดจากคำนวณ

                for (int y = 0; y < LoopAreaY; y++)  // Loop แกน Y (สแกนพื้นที่ 10 แถว)
                {
                    if (y % 2 == 0)  // ถ้าเป็นแถวคู่ (0,2,4..) เคลื่อนที่ไปทางขวา
                    {
                        for (int x = 0; x < LoopAreaX; x++)
                        {
                            //myMMC.WriteString(ValueNegativeX);  // เคลื่อนที่ถอยหลังแนว X-
                            //myMMC.WriteString("G:");
                            //await Task.Delay(ValueTimer);
                        }
                    }
                    else  // ถ้าเป็นแถวคี่ (1,3,5..) เคลื่อนที่ย้อนกลับทางซ้าย
                    {
                        for (int x = 0; x < LoopAreaX; x++)
                        {
                            //myMMC.WriteString(ValueProcessX);  // เคลื่อนที่กลับแนว X+
                            //myMMC.WriteString("G:");
                            //await Task.Delay(ValueTimer);
                        }
                    }

                    //เคลื่อนที่ไปยังแถวถัดไปตามแนว Y
                    //myMMC.WriteString(ValueProcessY);
                    //myMMC.WriteString("G:");
                    await Task.Delay(ValueTimer);


                    this.Invoke(new Action(() => Reportdata.AppendText($"{y + 1} loop " + Environment.NewLine)));
                }

                if (LoopAreaY % 2 != 0)
                {

                    for (int x = 0; x < LoopAreaX; x++)
                    {
                        //myMMC.WriteString(ValueProcessX);  // เคลื่อนที่กลับแนว X+
                        //myMMC.WriteString("G:");
                        //await Task.Delay(ValueTimer);

                    }
                }

                ShowMessage("INFO", $"{ValueProcessX} {ValueProcessY} {ValueNegativeX}");
                OnCancelClicked?.Invoke();
            }
            catch (Exception Ex)
            { 
                ShowMessage("ERROR", $"กรุณาตรวจการเชื่อมต่อ \n {Ex.Message}");
            
            }
        }

        #endregion

        private void BtnCancel_scaning_Click(object sender, EventArgs e)
        {

            string TriggerMode = GlobalMeasurementSettings.Instance.TriggerMode;
            string MeasureMode = GlobalMeasurementSettings.Instance.MeasureMode;
            string SourceMode = GlobalMeasurementSettings.Instance.SourceMode;
            string AutoMode = GlobalMeasurementSettings.Instance.AutozeroMode;
            MessageBox.Show($"{TriggerMode} \n {MeasureMode} \n {SourceMode} \n {AutoMode}", "สรุปผล");
        }

        
    }
}

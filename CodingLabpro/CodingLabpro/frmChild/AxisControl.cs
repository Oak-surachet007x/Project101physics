using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;
using NPOI.Util;
using Org.BouncyCastle.Tsp;

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
        private string SelectUnitMeasure;
        private double Range;
        private double Resolution;
        private double Display_Measure;
        public event Action OnRunClicked;
        public event Action OnCancelClicked;
        public event Action <double> OnMeasurement;
        public event Action<double> OnMeasurementWithDisplay;


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
            delaySteppingComboBox.Items.AddRange(new string[] {"1000", "2000", "3000", "100", "200" });
            CBtrigger.Items.AddRange(new string[] {"IMMediate", "BUS"});

            RB_resolution4digits.Text = "4\u00BD digits";

            
        }

        
        private void UIControlDisabled(bool EnabledItem)
        {
     
            RB_resolution4digits.Enabled = !EnabledItem;
            RB_resolutionMIN.Enabled = !EnabledItem;
            RB_resolutionCustom.Enabled = !EnabledItem;
            RB_resolutionAuto.Enabled = !EnabledItem;
            RB_autorange.Enabled = !EnabledItem;
            RB_Customrange.Enabled = !EnabledItem;
            RB_autoON.Enabled = !EnabledItem;
            RB_autoOFF.Enabled = !EnabledItem;
            RB_autoOnce.Enabled = !EnabledItem;
            Btn_QueryResolution.Enabled = !EnabledItem;
            CBtrigger.Enabled = !EnabledItem;
            totalAreaXTextBox.Enabled = !EnabledItem;
            totalAreaYTextBox.Enabled = !EnabledItem;
            moveStepXTextBox.Enabled = !EnabledItem;
            moveStepYTextBox.Enabled = !EnabledItem;
            delaySteppingComboBox.Enabled = !EnabledItem;
            unitXComboBox.Enabled = !EnabledItem;
            unitYComboBox.Enabled = !EnabledItem;

        }

        private void UIVisbleControl(bool VisibleItem)
        {
            GBSource.Visible = !VisibleItem;
            STriggerlabel.Visible = !VisibleItem;
            CBtrigger.Visible = !VisibleItem;
        }

        private void AxisControl_Load(object sender, EventArgs e)
        {
            InputValue_area.DataSource = new CalculateArea_Bind();
            ButtonPortEnabled();
            UIControlDisabled(true);
            CBrange.Enabled = false;
            Numeric_Range.Enabled = false;
            Numeric_Resolution.Enabled = false;
            CBtrigger.SelectedItem = GlobalMeasurementSettings.Instance.TriggerMode; //ค่าเริ่มต้น
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
                    Debug.WriteLine("Trigger Select = " + GlobalMeasurementSettings.Instance.TriggerMode);
                    break;
                case "BUS":
                    GlobalMeasurementSettings.Instance.TriggerMode = "BUS";
                    Debug.WriteLine("Trigger Select = " + GlobalMeasurementSettings.Instance.TriggerMode);
                    break;
                //case "EXTernal": //ตัดออกเพราะส่งสัญญาณ Pulse จากอุปกรณ์ภายนอก
                //    GlobalMeasurementSettings.Instance.TriggerMode = "EXTernal";
                //    Debug.WriteLine(GlobalMeasurementSettings.Instance.TriggerMode);
                //    break;
                default:
                    CBtrigger.SelectedIndex = -1;
                    GlobalMeasurementSettings.Instance.TriggerMode = "";
                    Debug.WriteLine("Not Found Trigger Measurement");
                    break;


            }
        }
        private void RBfrep_CheckedChanged(object sender, EventArgs e)
        {
            UIVisbleControl(true);
            UIControlDisabled(false);
            GlobalMeasurementSettings.Instance.MeasureMode = "Frequency";
        }

        private void RBvoltage_CheckedChanged(object sender, EventArgs e)
        {
            Range_Control_Measurement();
            UIVisbleControl(false);
            UIControlDisabled(false);
            GlobalMeasurementSettings.Instance.MeasureMode = "Voltage";
   
            
        }
        private void RBcurrent_CheckedChanged(object sender, EventArgs e)
        {
            Range_Control_Measurement();
            UIVisbleControl(false);
            UIControlDisabled(false);
            GlobalMeasurementSettings.Instance.MeasureMode = "Current";
        }
        private void RBsource_DC_CheckedChanged(object sender, EventArgs e)
        {
            Range_Control_Measurement();
            GlobalMeasurementSettings.Instance.SourceMode = "DC";
        }
        private void RBsource_AC_CheckedChanged(object sender, EventArgs e)
        {
            Range_Control_Measurement();
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
        private void RB_resolution4digits_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.ResolutionControl = "DIGITS_4";
            Numeric_Resolution.Enabled = false; 
        }
        private void RB_resolutionMIN_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.ResolutionControl = "MIN";
            Numeric_Resolution.Enabled = false;
        }
        private void RB_resolutionMAX_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.ResolutionControl = "MAX";
            Numeric_Resolution.Enabled = false;
        }
        private void RB_resolutionAuto_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.ResolutionControl = "AUTO";
            Numeric_Resolution.Enabled = false;
        }
        private void RB_resolutionCustom_CheckedChanged(object sender, EventArgs e)
        {
            GlobalMeasurementSettings.Instance.ResolutionControl = "CUSTOM";
            Numeric_Resolution.Enabled = true;
            Numeric_Resolution.Value = (decimal)GetDefaultResolution();
        }

        #region Resolution_Measurement

        //สร้างแมปคำสั่ง SCPI สำหรับโหมดการวัด
        private Dictionary<(string Measure, string Source), string> Measurement_SCPI_Command()
        {
           var Measurement_Mode = new Dictionary<(string, string), string>
           {
                { ("Voltage", "DC"), "VOLT:DC" },
                { ("Voltage", "AC"), "VOLT:AC" },
                { ("Current", "DC"), "CURR:DC" },
                { ("Current", "AC"), "CURR:AC" }
           };

           return Measurement_Mode;

        }


        private double GetDefaultRange()
        {
            if (GlobalMeasurementSettings.Instance.MeasureMode == "Voltage" && GlobalMeasurementSettings.Instance.SourceMode == "DC")
            {
                return 10; // 10V default
            }
            else if (GlobalMeasurementSettings.Instance.MeasureMode == "Voltage" && GlobalMeasurementSettings.Instance.SourceMode == "AC")
            {
                return 20; // 20V default
            }
            else if (GlobalMeasurementSettings.Instance.MeasureMode == "Current" && GlobalMeasurementSettings.Instance.SourceMode == "DC")
            {
                return 0.1; // 100mA
            }
            else if (GlobalMeasurementSettings.Instance.MeasureMode == "Current" && GlobalMeasurementSettings.Instance.SourceMode == "AC")
            {
                return 0.1; // 100mA
            }
            else
            {
                return 1; // fallback
            }
        }

        private double GetDefaultResolution()
        {
            if (GlobalMeasurementSettings.Instance.MeasureMode == "Voltage" && GlobalMeasurementSettings.Instance.SourceMode == "DC")
            {
                return 0.001; // 1mV
            }
            else if (GlobalMeasurementSettings.Instance.MeasureMode == "Voltage" && GlobalMeasurementSettings.Instance.SourceMode == "AC")
            {
                return 0.001;
            }
            else if (GlobalMeasurementSettings.Instance.MeasureMode == "Current" && GlobalMeasurementSettings.Instance.SourceMode == "DC")
            {
                return 0.0001; // 100µA
            }
            else if (GlobalMeasurementSettings.Instance.MeasureMode == "Current" && GlobalMeasurementSettings.Instance.SourceMode == "AC")
            {
                return 0.0001;
            }
            else
            {
                return 0.001;
            }
        }


        #endregion

        #region Reange_Measurement

        //ตั้งค่าขอบเขตการวัด บน UI
        private void Range_Control_Measurement()
        {
            if (RB_autorange.Checked)
            {
                CBrange.Enabled = false;
                Numeric_Range.Enabled = false;
                GlobalMeasurementSettings.Instance.RangeControl = "AUTO";
            }
            else if (RB_Customrange.Checked)
            {
                CBrange.Enabled = true;
                Numeric_Range.Enabled = true;
                GlobalMeasurementSettings.Instance.RangeControl = "CUSTOM";
                RangeUnitMeasurement();
            }

        }

        //ตั้งค่าหน่วยขอบเขตการวัด บน ComboBox UI
        private void RangeUnitMeasurement()
        {
            if (RBvoltage.Checked)
            {
                SelectUnitMeasure = "V";
                Numeric_Range.Value = (decimal)GetDefaultRange();
                CBrange.Items.Clear();
                CBrange.Items.AddRange(new string[] { "V", "mV" });
                CBrange.SelectedItem = SelectUnitMeasure; // Set default selection
                
            }
            else if (RBcurrent.Checked)
            {
                SelectUnitMeasure = "mA";
                Numeric_Range.Value = (decimal)GetDefaultRange();
                CBrange.Items.Clear();
                CBrange.Items.AddRange(new string[] { "A", "mA", "nA" });
                CBrange.SelectedItem = SelectUnitMeasure; // Set default selection
                
            }
        }


        #endregion

        #region SCPI CONFigure Measurement Settings
        //สร้างคำสั่ง SCPI สำหรับการตั้งค่าการวัดล่วงหน้า CONFigure
        private string Build_ConfigCommand()
        {
            try
            {

                var map = Measurement_SCPI_Command();
                var key = (GlobalMeasurementSettings.Instance.MeasureMode, GlobalMeasurementSettings.Instance.SourceMode);


                if (!map.TryGetValue(key, out string baseCommand))
                {
                    throw new InvalidOperationException("ไม่พบโหมดการวัด");
                }
                else
                {

                    // รองรับกรณี AUTO ทั้งคู่
                    if (GlobalMeasurementSettings.Instance.RangeControl == "AUTO" &&
                        GlobalMeasurementSettings.Instance.ResolutionControl == "AUTO")
                    {
                        return $"CONF:{baseCommand} DEF, DEF";
                    }


                    // ตั้งค่าขอบเขตการวัดตามโหมด
                    switch (GlobalMeasurementSettings.Instance.RangeControl)
                    {
                        case "AUTO":
                            return $"CONF:{baseCommand} DEF, {Resolution}";
                        case "CUSTOM":
                            // แปลงค่าขอบเขตการวัดเป็นหน่วยมาตรฐาน
                            double Range_value = (double)Numeric_Range.Value;
                            SelectUnitMeasure = CBrange.SelectedItem.ToString();
                            Range = ConvertValueOnUnit(Range_value, SelectUnitMeasure);
                            break;

                    }

                    // ตั้งค่าความละเอียดตามโหมด
                    switch (GlobalMeasurementSettings.Instance.ResolutionControl)
                    {
                        case "DIGITS_4":
                            Resolution = 0.0001;
                            break;
                        case "MIN":
                            return $"CONF:{baseCommand} {Range}, MIN";
                        case "MAX":
                            return $"CONF:{baseCommand} {Range}, MAX";
                        case "AUTO":
                            return $"CONF:{baseCommand} {Range}";
                        case "CUSTOM":
                            Resolution = (double)Numeric_Resolution.Value;
                            break;

                    }


                }

                // ฟอร์แมตรูปแบบตัวเลข
                string formattedRange = FormatRange(Range);
                string formattedResolution = FormatResolution(Resolution);

                // สร้างคำสั่ง SCPI
                string command = $"CONF:{baseCommand} {formattedRange}, {formattedResolution}";

                Debug.WriteLine(command);
                return command;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in Build_ConfigCommand: " + ex.Message);
                return string.Empty;

            }
        }

        #endregion

        #region SCPI Measure Command Settings
        private string Build_MeasureCommand()
        {
            try
            {
                var map = Measurement_SCPI_Command();
                var key = (GlobalMeasurementSettings.Instance.MeasureMode, GlobalMeasurementSettings.Instance.SourceMode);


                if (!map.TryGetValue(key, out string baseCommand))
                {
                    throw new InvalidOperationException("ไม่พบโหมดการวัด");
                }
                else
                {

                    // รองรับกรณี AUTO ทั้งคู่
                    if (GlobalMeasurementSettings.Instance.RangeControl == "AUTO" &&
                        GlobalMeasurementSettings.Instance.ResolutionControl == "AUTO")
                    {
                        return $"MEAS:{baseCommand}? DEF, DEF";
                    }


                    // ตั้งค่าขอบเขตการวัดตามโหมด
                    switch (GlobalMeasurementSettings.Instance.RangeControl)
                    {
                        case "AUTO":
                            return $"MEAS:{baseCommand}? DEF, {Resolution}";
                        case "CUSTOM":
                            // แปลงค่าขอบเขตการวัดเป็นหน่วยมาตรฐาน
                            double Range_value = (double)Numeric_Range.Value;
                            SelectUnitMeasure = CBrange.SelectedItem.ToString();
                            Range = ConvertValueOnUnit(Range_value, SelectUnitMeasure);
                            break;

                    }

                    // ตั้งค่าความละเอียดตามโหมด
                    switch (GlobalMeasurementSettings.Instance.ResolutionControl)
                    {
                        case "DIGITS_4":
                            Resolution = 0.0001;
                            break;
                        case "MIN":
                            return $"MEAS:{baseCommand}? {Range}, MIN";
                        case "MAX":
                            return $"MEAS:{baseCommand}? {Range}, MAX";
                        case "AUTO":
                            return $"MEAS:{baseCommand}? {Range}";
                        case "CUSTOM":
                            Resolution = (double)Numeric_Resolution.Value;
                            break;

                    }


                }

                // ฟอร์แมตรูปแบบตัวเลข
                string formattedRange = FormatRange(Range);
                string formattedResolution = FormatResolution(Resolution);

                // สร้างคำสั่ง SCPI
                string command = $"MEAS:{baseCommand}? {formattedRange}, {formattedResolution}";
                Debug.WriteLine(command);
                return command;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in Build_ConfigCommand: " + ex.Message);
                return string.Empty;

            }
        }

        private string FormatResolution(double resolution)
        {
            if (Math.Abs(resolution) < 0.001)
                return resolution.ToString("0.###E-0");
            else
                return resolution.ToString("G6"); // รองรับทั้งทศนิยมและ exponential
        }

        private string FormatRange(double range)
        {
            if (Math.Abs(range) < 0.001)
                return range.ToString("0.###E-0");
            else
                return range.ToString("G6");
        }


        //แปลงค่าขอบเขตการวัดเป็นหน่วยมาตรฐาน
        private double ConvertValueOnUnit(double Value, string Unit)
        {
            switch (Unit)
            {
                case "mV":
                    return Value * 1E-3;
                case "V":
                    return Value;
                case "A":
                    return Value;
                case "mA":
                    return Value * 1E-3;
                case "nA":
                    return Value * 1E-9;
                default:
                    throw new Exception("Unknown Unit");
            }
        }

        #endregion

        private string Autozero_Measurement() // คำสั่ง autozero สำหรับใช้กับ SENSE เท่านั้น
        {
            switch (GlobalMeasurementSettings.Instance.AutozeroMode)
            {
                case "ON":
                    return "ZERO:AUTO ON";
                case "OFF":
                    return "ZERO:AUTO OFF";
                case "ONCE":
                    return "ZERO:AUTO ONCE";
                default:
                    throw new InvalidOperationException("Unknown AutozeroMode: " + GlobalMeasurementSettings.Instance.AutozeroMode);
            }

        }

        #region DMM Setup Measurement Command
        private void SetupMeasurementCommand()
        {
            if(GlobalMeasurementSettings.Instance.MeasureMode == "Voltage" || GlobalMeasurementSettings.Instance.MeasureMode == "Current")
            {
                if (GlobalMeasurementSettings.Instance.TriggerMode == "BUS")
                {
                    myDMM.WriteString(Build_ConfigCommand()); //ตั้งค่าการวัดล่วงหน้า
                    myDMM.WriteString("TRIGger:SOURce BUS");
                    myDMM.WriteString("SAMPle:COUNt 1"); //ตั้งค่าจำนวนการวัด
                    myDMM.WriteString("TRIGger:COUNt 1"); //ตั้งค่าจำนวนทริกเกอร์

                }
                else if (GlobalMeasurementSettings.Instance.TriggerMode == "IMMediate")
                {
                    myDMM.WriteString(Build_MeasureCommand()); //คำสั่งวัดทันที
               

                }
            }
            else if(GlobalMeasurementSettings.Instance.MeasureMode == "Frequency")
            {
                myDMM.WriteString("CONF:FREQ DEF, DEF");
            }
            

        }

        private async Task Measure_Trigger(CancellationToken token)
        {
            await Task.Run(() =>
            {
                if (GlobalMeasurementSettings.Instance.TriggerMode == "BUS")
                {
                    myDMM.WriteString("INIT");
                    myDMM.WriteString("*TRG"); //if Select Trigger_Source == BUS will accept command IEEE-488
                    myDMM.WriteString("FETC?");

                }
                else if (GlobalMeasurementSettings.Instance.TriggerMode == "IMMediate")
                {
                    //None command
                }

            }, token);
        }

        //-----------------------------------------------Data Acquisition Measurement---------------------------------------------

        private void SendDataMeasurement(double MeasurementValue, double DisplayValue)
        {
            OnMeasurement?.Invoke(MeasurementValue);
            OnMeasurementWithDisplay?.Invoke(DisplayValue);
        }

        private async Task<string> ReadMeasurementasync(CancellationToken token)
        {
            try
            {
                return await Task.Run(() =>
                {
                    string Value_Masurement = myDMM.ReadString().Trim();
                    //string Value_Masurement = "-1.38778E-04"; //Test Code
                    return Value_Masurement;


                }, token);
            }
            catch (Exception ex)
            {
                ShowMessage("ERROR", "Failed to read measurement result: " + ex.Message);
            }

            return null;
            
        }

        private void UpdateMeasurementUI(string Result_DMM)
        {
            try
            {
                //แปลงค่าวัดเป็น double
                double Result_Measures = double.Parse(Result_DMM);
                //แสดงผลบน UI
                Reportdata.AppendText($"Raw Data: {Result_DMM}" + Environment.NewLine);
                Debug.WriteLine($"MeasurementResult: {Result_Measures} ");
                //แปลงค่าวัดตามหน่วยที่เลือกแสดงผล
                Display_Measure = ConvertValueOnUnitDisplay(Result_DMM);
                SendDataMeasurement(Result_Measures, Display_Measure);
            }
            catch (Exception ex)
            {
                ShowMessage("ERROR", "Failed to read measurement result: " + ex.Message);
                Debug.WriteLine("Error reading measurement: " + ex.Message);
                double Result_Measures = double.NaN;
                SendDataMeasurement(Result_Measures, Result_Measures);
            }
        }

        #endregion

        #region Display Unit Conversion
        private double ConvertValueOnUnitDisplay(string measurement)
        {
            string Exponent = measurement.Substring(measurement.IndexOf("E")); //ดึงค่าเลขยกกำลังออก
            double Value = double.Parse(measurement); //ค่าจริงก่อนแปลงหน่วย
            string UnitMeasure = "";
            double Measurement_Value;
            string SI_Prefix;


            // กำหนดหน่วยการวัดตามโหมดการวัด
            if (GlobalMeasurementSettings.Instance.MeasureMode == "Voltage")
            {
                UnitMeasure = "V";
            }
            else if (GlobalMeasurementSettings.Instance.MeasureMode == "Current")
            {
                UnitMeasure = "A";
            }

           
            switch (Exponent)
            {
                case "E-12":
                    SI_Prefix = "p"; //pico official
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
                case "E-11":
                    SI_Prefix = "n"; //nano
                    Measurement_Value = Value * 1E9;
                    break;
                case "E-10":
                    SI_Prefix = "n"; //nano
                    Measurement_Value = Value * 1E9;
                    break;
                case "E-09":
                    SI_Prefix = "n"; //nano official
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
                case "E-08":
                    SI_Prefix = "μ"; //micro
                    Measurement_Value = Value * 1E6;
                    break;
                case "E-07":
                    SI_Prefix = "μ"; //micro
                    Measurement_Value = Value * 1E6;
                    break;
                case "E-06":
                    SI_Prefix = "μ"; //micro official
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
                case "E-05":
                    SI_Prefix = "m"; //milli
                    Measurement_Value = Value * 1E3;
                    break;
                case "E-04":
                    SI_Prefix = "m"; //milli
                    Measurement_Value = Value * 1E3;
                    break;
                case "E-03":
                    SI_Prefix = "m"; //milli official
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
                case "E-02":
                    SI_Prefix = "m"; //milli
                    Measurement_Value = Value * 1E3;
                    break;
                case "E-01":
                    SI_Prefix = "m"; //milli
                    Measurement_Value = Value * 1E3;
                    break;
                case "E+01":
                    SI_Prefix = "K"; //kilo
                    Measurement_Value = Value * 1E-3;
                    break;
                case "E+02":
                    SI_Prefix = "K"; //kilo
                    Measurement_Value = Value * 1E-3;
                    break;
                case "E+03":
                    SI_Prefix = "K"; //kilo official
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
                case "E+04":
                    SI_Prefix = "K"; //kilo
                    Measurement_Value = Value * 1E-3;
                    break;
                case "E+05":
                    SI_Prefix = "K"; //kilo
                    Measurement_Value = Value * 1E-3;
                    break;
                case "E+06":
                    SI_Prefix = "M"; //Mega official
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
                case "E+07":
                    SI_Prefix = "M"; //Mega
                    Measurement_Value = Value * 1E-6;
                    break;
                case "E+08":
                    SI_Prefix = "M"; //Mega
                    Measurement_Value = Value * 1E-6;
                    break;
                case "E+09":
                    SI_Prefix = "G"; //Giga official
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
                case "E+10":
                    SI_Prefix = "G"; //Giga
                    Measurement_Value = Value * 1E-9;
                    break;
                case "E+11":
                    SI_Prefix = "G"; //Giga
                    Measurement_Value = Value * 1E-9;
                    break;
                case "E+12":
                    SI_Prefix = "T"; //Tera official
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
                default:
                    SI_Prefix = "";
                    Measurement_Value = double.Parse(measurement.Substring(0, measurement.IndexOf("E")));
                    break;
            }

            // แสดงผลลัพธ์พร้อมหน่วยการวัด
            GlobalMeasurementSettings.Instance.UnitPrefix = $"{SI_Prefix}{UnitMeasure}";
            Debug.WriteLine($"[Display Measurement:] {Measurement_Value} {GlobalMeasurementSettings.Instance.UnitPrefix}");
            return Measurement_Value; //ค่าที่แปลงหน่วยแล้ว
        }


        //--------------------------------------------------Validator Error Provider------------------------------------------------

        #endregion

        #region Validator Error Provider
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

        //เมทอดตรวจสอบความถูกต้องของข้อมูลการสแกนพื้นที่ จากคลาส CalculateArea_Bind ที่ป้อนบนฟอร์ม
        public bool IsValidScaningArea()
        {

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

                    GlobalMeasurementSettings.Instance.CountOfRows = LoopAreaY;
                    GlobalMeasurementSettings.Instance.CountOfColumns = LoopAreaX;


                    return true;

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
                    return false;
                }
            }

            return false;
        }
        private bool ValidGlobalMeasurementSettings()
        {
            if (string.IsNullOrEmpty(GlobalMeasurementSettings.Instance.MeasureMode) ||
                string.IsNullOrEmpty(GlobalMeasurementSettings.Instance.SourceMode) ||
                string.IsNullOrEmpty(GlobalMeasurementSettings.Instance.RangeControl) ||
                string.IsNullOrEmpty(GlobalMeasurementSettings.Instance.ResolutionControl) ||
                string.IsNullOrEmpty(GlobalMeasurementSettings.Instance.TriggerMode))
            {
                ShowMessage("ERROR", "กรุณาตั้งค่าการวัดให้ครบถ้วน");
                return false;
            }
            return true;
        }

        #endregion

        public void ShowMessage(string type, string message)
        {
            Form MessageNotify = new MessageBox_Notify(type, message);
            MessageNotify.ShowDialog();
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
                }
                else if (RB_rs232.Checked)
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
                BtnCancel_scaning.Enabled = false;
      
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
                Debug.WriteLine($"[Positive X Movement Value: ] {MathValueX} Step");
                return $"M:XP{MathValueX}";
            }
            else if (Unit == "mm")
            {
                int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -3)) * 1) / (2 * Math.Pow(10, -6)));
                Debug.WriteLine($"[Positive X Movement Value: ] {MathValueX} Step");
                return $"M:XP{MathValueX}";

            }
            else if (Unit == "μm")
            {
                if ((float.Parse(MovestepX) >= 2))
                {
                    int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -6)) * 1) / (2 * Math.Pow(10, -6)));
                    Debug.WriteLine($"[Positive X Movement Value: ] {MathValueX} Step");
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
                Debug.WriteLine($"[Positive Y Movement Value: ] {MathValueY} Step");
                return $"M:YP{MathValueY}";
            }
            else if (Unit == "mm")
            {
                int MathValueY = (int)(((float.Parse(MovestepY) * Math.Pow(10, -3)) * 1) / (2 * Math.Pow(10, -6)));
                Debug.WriteLine($"[Positive Y Movement Value: ] {MathValueY} Step");
                return $"M:YP{MathValueY}";
                
            }else if (Unit == "μm")
            {
                if ((float.Parse(MovestepY) >= 2))
                {
                    int MathValueY = (int)(((float.Parse(MovestepY) * Math.Pow(10, -6)) * 1) / (2 * Math.Pow(10, -6)));
                    Debug.WriteLine($"[Positive Y Movement Value: ] {MathValueY} Step");
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
                Debug.WriteLine($"[Negative X Movement Value: ] {MathValueX} Step");
                return $"M:XP-{MathValueX}";
            }
            else if (Unit == "mm")
            {
                int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -3)) * 1) / (2 * Math.Pow(10, -6)));
                Debug.WriteLine($"[Negative X Movement Value: ] {MathValueX} Step");
                return $"M:XP-{MathValueX}";

            }
            else if (Unit == "μm")
            {
                if ((float.Parse(MovestepX) >= 2))
                {
                    int MathValueX = (int)(((float.Parse(MovestepX) * Math.Pow(10, -6)) * 1) / (2 * Math.Pow(10, -6)));
                    Debug.WriteLine($"[Negative X Movement Value: ] {MathValueX} Step");
                    return $"M:XP-{MathValueX}";
                }
            }

            return "ERROR: Value Begin 2 μm";

        }

        #endregion

        #region Methods ScaningArea

        private CancellationTokenSource Scan_cts;
        private async void Btn_runscaning_Click(object sender, EventArgs e)
        {
            try
            {
                //clear Textbox
                Reportdata.Clear();

                //ตรวจสอบความถูกต้องข้อมูลการสแกนพื้นที่ ผ่านเมธอด IsValidScaningArea
                if (!IsValidScaningArea()) 
                {
                    return; 
                }
                if (!ValidGlobalMeasurementSettings()) //ตรวจสอบการตั้งค่าการวัด
                {
                    return;
                }

                //Run Setup Scaning
                myMMC.WriteString("H:W");
                await Task.Delay(5000);
                myMMC.WriteString("M:WP5000  P-5000");  //<<--- ถอยหลังไปเริ่มต้นที่ชิดกำแพง Y = 0 cm & X = 1 cm
                myMMC.WriteString("G:");
                await Task.Delay(5000);
                //---------------------------------Setup Measurement-------------------------------------------- -
                //Run Measurement
                SetupMeasurementCommand();

                //Stopwatch
                OnRunClicked?.Invoke();
                BtnCancel_scaning.Enabled = true; //เปิดปุ่มยกเลิกสแกน
                Btn_runscaning.Enabled = false; //ปีดปุ่มรันสแกน
                UIControlDisabled(true); //ปิดการใช้งานปุ่มขณะรันสแกน

                //---------------------------------Loop Scaning Area---------------------------------------------
                //Report Area Calculate
                Reportdata.AppendText($"คำนวณผลลัพธ์ลูปที่สแกนของ X คือ {LoopAreaX} ลูป " + Environment.NewLine +
                                       $"คำนวณผลลัพธ์ลูปที่สแกนของ Y คือ {LoopAreaY} ลูป" + Environment.NewLine);
                //<--สรุปผลลัพธ์สแกนทั้งหมดจากคำนวณ

                Scan_cts = new CancellationTokenSource();
                await Task.Run(() => ScanningAreaProcess(Scan_cts.Token), Scan_cts.Token);

                Scan_cts.Cancel();
                OnCancelClicked?.Invoke();
                ShowMessage("INFO", $"[Process Completed]\t Value Stepping Motor: {ValueProcessX} {ValueProcessY} {ValueNegativeX}");

            }
            catch(OperationCanceledException)
            {
                ShowMessage("INFO", "ยกเลิกการสแกนพื้นที่เรียบร้อยแล้ว");
            }
            catch (Exception Ex)
            { 
                ShowMessage("ERROR", $"กรุณาตรวจการเชื่อมต่อ \n {Ex.Message}");

            }
        }

        private async Task ScanningAreaProcess(CancellationToken token)
        {
            //โค้ดสำหรับการสแกนพื้นที่
            for (int y = 0; y < LoopAreaY; y++)  // Loop แกน Y (สแกนพื้นที่ 10 แถว)
            {
                if (y % 2 == 0)  // ถ้าเป็นแถวคู่ (0,2,4..) เคลื่อนที่ไปทางขวา
                {
                    for (int x = 0; x < LoopAreaX; x++)
                    {
                        myMMC.WriteString(ValueNegativeX);  // เคลื่อนที่ถอยหลังแนว X-
                        myMMC.WriteString("G:");
                        await Task.Delay(ValueTimer, token); //หน่วงเวลา 2 วินาที เพื่อเก็บค่าการวัด

                        await Measure_Trigger(token); //ส่งคำสั่งวัดแบบ BUS
                        string result = await ReadMeasurementasync(token);
                        BeginInvoke(new Action(() =>
                        {
                            UpdateMeasurementUI(result);
                        }));
                        await Task.Delay(2000, token);
                    }
                }
                else  // ถ้าเป็นแถวคี่ (1,3,5..) เคลื่อนที่ย้อนกลับทางซ้าย
                {
                    for (int x = 0; x < LoopAreaX; x++)
                    {
                        myMMC.WriteString(ValueProcessX);  // เคลื่อนที่กลับแนว X+
                        myMMC.WriteString("G:");
                        await Task.Delay(ValueTimer, token); //หน่วงเวลา 2 วินาที เพื่อเก็บค่าการวัด

                        await Measure_Trigger(token); //ส่งคำสั่งวัดแบบ BUS
                        string result = await ReadMeasurementasync(token);
                        BeginInvoke(new Action(() =>
                        {
                            UpdateMeasurementUI(result);
                        }));
                        await Task.Delay(2000, token);
                    }
                }

                //เคลื่อนที่ไปยังแถวถัดไปตามแนว Y
                myMMC.WriteString(ValueProcessY);
                myMMC.WriteString("G:");
                await Task.Delay(ValueTimer, token);


                //this.Invoke(new Action(() => Reportdata.AppendText($"{y + 1} loop " + Environment.NewLine)));
            }

            if (LoopAreaY % 2 != 0)
            {

                for (int x = 0; x < LoopAreaX; x++)
                {
                    myMMC.WriteString(ValueProcessX);  // เคลื่อนที่กลับแนว X+
                    myMMC.WriteString("G:");
                    await Task.Delay(ValueTimer, token);

                }
            }

        }

        #endregion

        private void BtnCancel_scaning_Click(object sender, EventArgs e)
        {
            Scan_cts.Cancel();
            OnCancelClicked?.Invoke();

            Btn_runscaning.Enabled = true;
            BtnCancel_scaning.Enabled = false;
            UIControlDisabled(false); //เปิดการใช้งานปุ่มหลังยกเลิกสแกน
        }

        private void Btn_SCPItest_Click(object sender, EventArgs e)
        {
            SetupMeasurementCommand();
        }

        private void Btn_QueryResolution_Click(object sender, EventArgs e)
        {
            try
            {
                myDMM.WriteString("VOLT:DC:RESolution?");
                string QueryDmm = myDMM.ReadString();
                ShowMessage("INFO", QueryDmm);
            }
            catch (Exception Ex)
            {
                ShowMessage("ERROR", "Can't Query Resolution \n " + Ex.Message);

            }
        }

        //--------------------------------Textbox KeyPress Event---------------------------------------------
        //เมธอดตรวจสอบการกรอกข้อมูลให้เป็นตัวเลขเท่านั้น
        private void totalAreaXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void totalAreaYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void moveStepXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.';
        }

        private void moveStepYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.';
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private string StepMotor_ValueX;
        private string StepMotor_ValueY;
        private string SteppingUnitX;
        private string SteppingUnitY;
        private string ValueProcessX;
        private string ValueProcessY;
        private string ValueNegativeX;
        private string ValueTimer;



        public AxisControl(Ivi.Visa.Interop.FormattedIO488 myMMC, SerialPort mySerialPort, Ivi.Visa.Interop.FormattedIO488 myDMM)
        {
            InitializeComponent();
            //send value interface from frmMain01
            this.myMMC = myMMC;
            this.mySerialPort = mySerialPort;
            this.myDMM = myDMM;
            //Setup Value
            CblStepMotor.Items.AddRange(new string[] { "100", "200", "300", "400", "500", "1000" });
            Motortype.Items.AddRange(new string[] { "cm", "mm", "μm" });
            Motortype2.Items.AddRange(new string[] { "cm", "mm", "μm" });
            Cbltimer.Items.AddRange(new string[] {"1000", "2000", "3000" });
            CBtrigger.Items.AddRange(new string[] {"IMMediate", "BUS", "EXTernal"});
       
        }

        #region SettingMeasurement Agilent
        private void AxisControl_Load(object sender, EventArgs e)
        {
            ButtonPortEnabled();
            RangeUnitmeasuremnet();
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
            RangeUnitmeasuremnet();
            GlobalMeasurementSettings.Instance.MeasureMode = "Voltage";
        }

        private void RBcurrent_CheckedChanged(object sender, EventArgs e)
        {
            RangeUnitmeasuremnet();
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

        private void RangeUnitmeasuremnet()
        {
            if (RBvoltage.Checked)
            {
                CBrange.Items.Clear();
                CBrange.Items.AddRange(new string[] { "Auto", "1mV", "10mV", "15mV", "20mV"});
            }
            else if (RBcurrent.Checked)
            {
                CBrange.Items.Clear();
                CBrange.Items.AddRange(new string[] { "Auto", "1mA", "10mA" });

            }
         
        }

        private void SetupMeasurementCommand()
        {
            if (GlobalMeasurementSettings.Instance.MeasureMode == "Voltage" && GlobalMeasurementSettings.Instance.SourceMode == "DC")
            {
               if(GlobalMeasurementSettings.Instance.TriggerMode == "BUS")
               {
                    myDMM.WriteString("CONF:VOLT:DC 10, 0.003");
                    myDMM.WriteString("TRIGger:SOURce BUS");
                    if(GlobalMeasurementSettings.Instance.AutozeroMode == "ON")
                    {
                        myDMM.WriteString("ZERO:AUTO ON");
                    }
                    else if(GlobalMeasurementSettings.Instance.AutozeroMode == "OFF")
                    {
                        myDMM.WriteString("ZERO:AUTO OFF");
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
               else if(GlobalMeasurementSettings.Instance.TriggerMode == "")
               {

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

        #region Button Control movement
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

        private static float UnitXForCal(string UnitX)
        {
            switch (UnitX)
            {
                case "cm":
                    Debug.WriteLine(1E-2f + UnitX);
                    return 1E-2f;
                case "mm":
                    Debug.WriteLine(1E-3f + UnitX);
                    return 1E-3f;
                case "μm":
                    Debug.WriteLine(1E-6f + UnitX);
                    return 1E-6f;
                default:
                    return 0;

            }
        }
        private static float UnitYForCal(string UnitY)
        {
            switch (UnitY)
            {
                case "cm":
                    Debug.WriteLine(1E-2f + UnitY);
                    return 1E-2f;
                case "mm":
                    Debug.WriteLine(1E-3f + UnitY);
                    return 1E-3f;
                case "μm":
                    Debug.WriteLine(1E-6f + UnitY);
                    return 1E-6f;
                default:
                    return 0;

            }
        }

        #endregion

        #region Methods ScaningArea
        private async void Btn_runscaning_Click(object sender, EventArgs e)
        {
            try
            {
                Reportdata.Clear();
                SteppingUnitX = Motortype.SelectedItem.ToString();
                SteppingUnitY = Motortype2.SelectedItem.ToString();
                StepMotor_ValueX = TxtstepX.Text;
                StepMotor_ValueY = TxtstepY.Text;
                ValueTimer = Cbltimer.SelectedItem.ToString();


                //เก็บตัวแปรเรียกใช้ต่อในคลาสย่อย แล้วคืนค่าตามเงื่อนไข
                ValueProcessX = MovementPositiveX(StepMotor_ValueX, SteppingUnitX);
                ValueProcessY = MovementPositiveY(StepMotor_ValueY, SteppingUnitY);
                ValueNegativeX = MovementNegativeX(StepMotor_ValueX, SteppingUnitX);


                // Requitment Class
                var Calarea = new CalculateArea()
                {
                    TotalAreaX = TbAreaX.Text,
                    TotalAreaY = TbAreaY.Text,
                    UnitX = UnitXForCal(SteppingUnitX),
                    UnitY = UnitYForCal(SteppingUnitY),
                    MoveStepX = StepMotor_ValueX,
                    MoveStepY = StepMotor_ValueY,
                };

                int LoopAreaX = Calarea.CalareaScanningX();
                int LoopAreaY = Calarea.CalareaScanningY();

                //Run Scaning
                myMMC.WriteString("H:W");
                await Task.Delay(5000);
                myMMC.WriteString("M:WP5000  P-5000");  //<<--- ถอยหลังไปเริ่มต้นที่ชิดกำแพง Y == 0 cm
                myMMC.WriteString("G:");
                await Task.Delay(5000);

                SetupMeasurementCommand();

                Reportdata.AppendText($" คำนวณผลลัพธ์ลูปที่สแกนของ X คือ {LoopAreaX} ลูป \n คำนวณผลลัพธ์ลูปที่สแกนของ Y คือ {LoopAreaY} ลูป" + Environment.NewLine); //<--สรุปผลลัพธ์สแกนทั้งหมดจากคำนวณ

                for (int y = 0; y < LoopAreaY; y++)  // Loop แกน Y (สแกนพื้นที่ 10 แถว)
                {
                    if (y % 2 == 0)  // ถ้าเป็นแถวคู่ (0,2,4..) เคลื่อนที่ไปทางขวา
                    {
                        for (int x = 0; x < LoopAreaX; x++)
                        {
                            myMMC.WriteString(ValueNegativeX);  // เคลื่อนที่ถอยหลังแนว X-
                            myMMC.WriteString("G:");
                            await Task.Delay(int.Parse(ValueTimer));
                        }
                    }
                    else  // ถ้าเป็นแถวคี่ (1,3,5..) เคลื่อนที่ย้อนกลับทางซ้าย
                    {
                        for (int x = 0; x < LoopAreaX; x++)
                        {
                            myMMC.WriteString(ValueProcessX);  // เคลื่อนที่กลับแนว X+
                            myMMC.WriteString("G:");
                            await Task.Delay(int.Parse(ValueTimer));
                        }
                    }

                    //เคลื่อนที่ไปยังแถวถัดไปตามแนว Y
                    myMMC.WriteString(ValueProcessY);
                    myMMC.WriteString("G:");
                    await Task.Delay(int.Parse(ValueTimer));


                    this.Invoke(new Action(() => Reportdata.AppendText($"{y + 1} loop " + Environment.NewLine)));
                }

                if (LoopAreaY % 2 != 0)
                {

                    for (int x = 0; x < LoopAreaX; x++)
                    {
                        myMMC.WriteString(ValueProcessX);  // เคลื่อนที่กลับแนว X+
                        myMMC.WriteString("G:");
                        await Task.Delay(int.Parse(ValueTimer));

                    }
                }

                ShowMessage("INFO", $"{ValueProcessX} {ValueProcessY} {ValueNegativeX}");
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
            MessageBox.Show($"{TriggerMode} \n {MeasureMode} \n {SourceMode}", "สรุปผล");
        }

     
    }
}

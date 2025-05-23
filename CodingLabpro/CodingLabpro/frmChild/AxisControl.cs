﻿using System;
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
        private string StepMotor_Selected;
        private string StepMotor_ValueX;
        private string StepMotor_ValueY;
        private string SteppingUnitX;
        private string SteppingUnitY;
        private string ValueProcessX;
        private string ValueProcessY;
        private string ValueNegativeX;
        private string ValueTimer;



        public AxisControl(Ivi.Visa.Interop.FormattedIO488 myMMC, SerialPort mySerialPort)
        {
            InitializeComponent();
            //send value interface from frmMain01
            this.myMMC = myMMC;
            this.mySerialPort = mySerialPort;
            //Setup Value
            CblStepMotor.Items.AddRange(new string[] { "100", "200", "300", "400", "500", "1000" });
            Motortype.Items.AddRange(new string[] { "cm", "mm", "μm" });
            Motortype2.Items.AddRange(new string[] { "cm", "mm", "μm" });
            Cbltimer.Items.AddRange(new string[] {"1000", "2000", "3000" });
   

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

        

        public void ShowMessage(string type, string message)
        {
            Form MessageNotify = new MessageBox_Notify(type, message);
            MessageNotify.Show();
        }

        private void MMC_Write(string command)
        {
            try
            {
                myMMC.WriteString(command);
                myMMC.WriteString("G:");
            }
            catch (Exception Ex){
                ShowMessage("ERROR", "Can't Drive SteppingMotor\n " + Ex.Message);
            }
        }

        private void Btn_ResetHome_Click(object sender, EventArgs e)
        {
            try
            {
                mySerialPort.WriteLine("H:W");
                myMMC.WriteString("H:W");
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
                myMMC.WriteString("L:E");
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

        private static (int, int) CalareaScanning(string MoveStepX, string MoveStepY,string AreaX, string AreaY, float UnitX, float UnitY)
        {
            int LoopAreaX = (int)((float.Parse(AreaX) * 1E-3f) / (float.Parse(MoveStepX) * UnitX));
            Debug.WriteLine("X loop " + LoopAreaX.ToString() + "\t" + MoveStepX + "\t" + UnitX.ToString());
            int LoopAreaY = (int)((float.Parse(AreaY) * 1E-3f) / (float.Parse(MoveStepY) * UnitY));
            Debug.WriteLine("y loop " + LoopAreaY.ToString() + "\t" + MoveStepY + "\t" + UnitY.ToString());
            return (LoopAreaX, LoopAreaY);     
        }

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
                float UnitX = UnitXForCal(SteppingUnitX);
                float UnitY = UnitYForCal(SteppingUnitY);

                //เก็บตัวแปรเรียกใช้ต่อในคลาสย่อย แล้วคืนค่าตามเงื่อนไข
                ValueProcessX = MovementPositiveX(StepMotor_ValueX, SteppingUnitX);
                ValueProcessY = MovementPositiveY(StepMotor_ValueY, SteppingUnitY);
                ValueNegativeX = MovementNegativeX(StepMotor_ValueX, SteppingUnitX);
                (int LoopAreaX, int LoopAreaY) = CalareaScanning(StepMotor_ValueX, StepMotor_ValueY, TbAreaX.Text, TbAreaY.Text, UnitX, UnitY);


                //Run Scaning
                myMMC.WriteString("H:W");
                await Task.Delay(5000);
                myMMC.WriteString("M:WP5000  P-5000");  //<<--- ถอยหลังไปเริ่มต้นที่ชิดกำแพง Y == 0 cm
                myMMC.WriteString("G:");
                await Task.Delay(5000);

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
                    // เคลื่อนที่ไปยังแถวถัดไปตามแนว Y
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
                ShowMessage("ERROR", Ex.Message);
            
            }
           
            
        }

        #endregion
    }
}

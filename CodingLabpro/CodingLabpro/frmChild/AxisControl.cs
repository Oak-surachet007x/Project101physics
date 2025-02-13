using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace CodingLabpro.frmChild
{
    public partial class AxisControl : UserControl
    {
        private readonly Ivi.Visa.Interop.FormattedIO488 myMMC;
        private SerialPort mySerialPort;
        //private DataGridManager dataGridManger;
        private string StepMotor_Selected;
        private string StepMotor_ValueX;
        private string StepMotor_ValueY;
        private string SteppingUnitX;
        private string SteppingUnitY;
        private string ValueProcessX;
        private string ValueProcessY;
        private string ValueNegativeX;
        private string ValueTimer;
        public static int datastep;
        public AxisControl(Ivi.Visa.Interop.FormattedIO488 myMMC, SerialPort mySerialPort)
        {
            InitializeComponent();
            //send value interface from frmMain01
            this.myMMC = myMMC;
            this.mySerialPort = mySerialPort;
            //Setup Value
            CblStepMotor.Items.AddRange(new string[] { "100", "200", "300", "400", "500", "1000" });
            Motortype.Items.AddRange(new string[] { "cm", "mm", });
            Motortype2.Items.AddRange(new string[] { "cm", "mm", });
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

        private void MMC_Write( string command)
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
                    MMC_Write("M:XP200");
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
                switch (MovestepX)
                {
                    case "1":
                        return "M:XP(S)";
                    case "2":
                        return "M:XP10000";
                    default:
                        throw new Exception("Limit movement = 2 cm Only");
                }

            }
            else if (Unit == "mm")
            {
                switch (MovestepX)
                {
                    case "1":
                        return "M:XP500";
                    case "1.5":
                        return "M:XP750";
                    case "2":
                        return "M:XP1000";
                    default:
                        throw new Exception("Limit movement = 2 cm Only");
                }
            }

            return "ERROR: Invalid unit";
        }

        private static string MovementPositiveY(string MovestepY, string Unit)
        {
            if (Unit == "cm")
            {
                switch (MovestepY)
                {
                    case "1":
                        return "M:YP5000";
                    case "2":
                        return "M:YP10000";
                    default:
                        throw new Exception("Limit movement = 2 cm Only");

                }
            }
            else if (Unit == "mm")
            {
                switch (MovestepY)
                {
                    case "1":
                        return "M:YP500";
                    case "1.5":
                        return "M:YP750";
                    case "2":
                        return "M:YP1000";
                    default:
                        throw new Exception("Limit movement = 2 cm Only");

                }
            }

            return "ERROR: Invalid unit"; 
        }

        private static string MovementNegativeX(string MovestepX, string Unit)
        {
            if (Unit == "cm")
            {
                switch (MovestepX)
                {
                    case "1":
                        return "M:XP-5000";
                    case "2":
                        return "M:XP-10000";
                    default:
                        throw new Exception("Limit movement = 2 cm Only");
                }

            }
            else if (Unit == "mm")
            {
                switch (MovestepX)
                {
                    case "1":
                        return "M:XP-500";
                    case "1.5":
                        return "M:XP-750";
                    case "2":
                        return "M:XP-1000";
                    default:
                        throw new Exception("Limit movement = 2 cm Only");
                }
            }

            return "ERROR: Invalid unit";
        }

        private void Btn_runscaning_Click(object sender, EventArgs e)
        {
            try
            {
                SteppingUnitX = Motortype.SelectedItem.ToString();
                SteppingUnitY = Motortype2.SelectedItem.ToString();
                StepMotor_ValueX = TxtstepX.Text;
                StepMotor_ValueY = TxtstepY.Text;
                ValueTimer = Cbltimer.SelectedItem.ToString();

                //เก็บตัวแปรเรียกใช้ต่อในคลาสย่อย แล้วคืนค่าตามเงื่อนไข
                ValueProcessX = MovementPositiveX(StepMotor_ValueX, SteppingUnitX);
                ValueProcessY = MovementPositiveY(StepMotor_ValueY, SteppingUnitY);
                ValueNegativeX = MovementNegativeX(StepMotor_ValueX, SteppingUnitX);

                //Add DataTable
                //await FrmMain01.dataGridManager.LoadDataAsync();

                //Run Scaning 
                myMMC.WriteString("H:W");
                Task.Delay(5000).Wait();
                myMMC.WriteString("M:YP-5000");  //<<--- ถอยหลังไปเริ่มต้นที่ชิดกำแพง Y == 0 cm
                myMMC.WriteString("G:");
                Task.Delay(5000).Wait();

                for (int i = 1; i <= 10; i++)
                {
                    
                    //turn Back Axis : X
                    myMMC.WriteString(ValueNegativeX);
                    myMMC.WriteString("G:");
                    //Delay Process
                    Task.Delay(int.Parse(ValueTimer)).Wait(); 
                    //send data in Mainform DataGridView
                    datastep = 1;

                    if (i == 10)
                    {
                        //Next to Axis: Y
                        myMMC.WriteString(ValueProcessY);
                        myMMC.WriteString("G:");
                        //Delay Process
                        Task.Delay(int.Parse(ValueTimer)).Wait();
                        //send data in Mainform DataGridView
                        datastep = 2;

                        for (int j = 0; j <= 10; j++) 
                        {
                            //turm Back Axis : X
                            myMMC.WriteString(ValueProcessX);
                            myMMC.WriteString("G:");
                            //Dalay Process
                            Task.Delay(int.Parse(ValueTimer)).Wait();

                            if (j == 10)
                            {
                                ////Next to Axis: Y
                                myMMC.WriteString(ValueProcessY);
                                myMMC.WriteString("G:");
                                //Delay Process
                                Task.Delay(int.Parse(ValueTimer)).Wait();

                            }

                        }


                    }

                   


                }

                ////Start Axis : X Loop == 2 

                ShowMessage("INFO", $"{ValueProcessX} {ValueProcessY} {ValueNegativeX}");
            }
            catch (Exception Ex)
            { 
                ShowMessage("ERROR", Ex.Message);
            
            }
           
            
        }
    }
}

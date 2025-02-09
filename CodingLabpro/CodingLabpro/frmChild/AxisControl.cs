using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodingLabpro.Models;
using Ivi.Visa;

namespace CodingLabpro.frmChild
{
    public partial class AxisControl : UserControl
    {
        private readonly Ivi.Visa.Interop.FormattedIO488 myMMC;
        private readonly SerialPort mySerialPort;
        private string StepMotor_Selected;
        private string StepMotor_ValueX;
        private string StepMotor_ValueY;
        private string ValueProcessX;
        private string ValueProcessY;
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
            if (CblStepMotor.SelectedItem == null)
            {
                return "null";
            }
            else
            {
                StepMotor_Selected = CblStepMotor.SelectedItem.ToString();
                return StepMotor_Selected;
            }
            
        }

      

        public void ShowMessage(string type, string message)
        {
            Form MessageNotify = new MessageBox_Notify(type, message);
            MessageNotify.Show();
        }

        private void Btn_ResetHome_Click(object sender, EventArgs e)
        {
            try
            {

                myMMC.WriteString("H:W");
                mySerialPort.Write("H:W");
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
                    ShowMessage("INFO", "M:XP100");
                    break;
                case "200":
                    ShowMessage("INFO", "M:XP200");
                    break;
                case "300":
                    ShowMessage("INFO", "M:XP300");
                    break;
                case "400":
                    ShowMessage("INFO", "M:XP400");
                    break;
                case "500":
                    ShowMessage("INFO", "M:XP500");
                    break;
                case "1000":
                    ShowMessage("INFO", "M:XP1000");
                    break;
                default:
                    ShowMessage("ERROR", "Can't Drive SteppingMotor " + ValueStepping());
                    break;
            }
        }

        private void Btn_YUp_Click(object sender, EventArgs e)
        {
            switch (ValueStepping())
            {
                case "100":
                    ShowMessage("INFO", "M:YP100");
                    break;
                case "200":
                    ShowMessage("INFO", "M:YP200");
                    break;
                case "300":
                    ShowMessage("INFO", "M:YP300");
                    break;
                case "400":
                    ShowMessage("INFO", "M:YP400");
                    break;
                case "500":
                    ShowMessage("INFO", "M:YP500");
                    break;
                case "1000":
                    ShowMessage("INFO", "M:YP1000");
                    break;
                default:
                    ShowMessage("ERROR", "Can't Drive SteppingMotor " + ValueStepping());
                    break;
            }
        }

        private void Btn_XRight_Click(object sender, EventArgs e)
        {
            switch (ValueStepping())
            {
                case "100":
                    ShowMessage("INFO", "M:-XP100");
                    break;
                case "200":
                    ShowMessage("INFO", "M:-XP200");
                    break;
                case "300":
                    ShowMessage("INFO", "M:-XP300");
                    break;
                case "400":
                    ShowMessage("INFO", "M:-XP400");
                    break;
                case "500":
                    ShowMessage("INFO", "M:-XP500");
                    break;
                case "1000":
                    ShowMessage("INFO", "M:-XP1000");
                    break;
                default:
                    ShowMessage("ERROR", "Can't Drive SteppingMotor " + ValueStepping());
                    break;
            }
        }

        private void Btn_YDown_Click(object sender, EventArgs e)
        {
            switch (ValueStepping())
            {
                case "100":
                    ShowMessage("INFO", "M:-YP100");
                    break;
                case "200":
                    ShowMessage("INFO", "M:-YP200");
                    break;
                case "300":
                    ShowMessage("INFO", "M:-YP300");
                    break;
                case "400":
                    ShowMessage("INFO", "M:-YP400");
                    break;
                case "500":
                    ShowMessage("INFO", "M:-YP500");
                    break;
                case "1000":
                    ShowMessage("INFO", "M:-YP1000");
                    break;
                default:
                    ShowMessage("ERROR", "Can't Drive SteppingMotor " + ValueStepping());
                    break;
            }
        }

        private string MovementProcessX(string MovestepX)
        {
            switch (MovestepX)
            {
                case "1":
                    return "M:XP5000";
                case "2":
                    return "M:XP10000";
                default:
                    throw new Exception("Limit movement = 2 cm Only");
            }
        }

        private string MovementProcessY(string MovestepY)
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



        private void Btn_runscaning_Click(object sender, EventArgs e)
        {
            try
            {
                string SteppingUnitX = Motortype.SelectedItem.ToString();
                string SteppingUnitY = Motortype2.SelectedItem.ToString();
                StepMotor_ValueX = TxtstepX.Text;
                StepMotor_ValueY = TxtstepY.Text;
               

                if (SteppingUnitX == "cm")
                {
                    
                    ValueProcessX = MovementProcessX(StepMotor_ValueX);
                    //myMMC.WriteString(ValueProcessX);
                    

                }
                else if (SteppingUnitX == "mm")
                {
                    ShowMessage("INFO", "select to mm");
                }


                if (SteppingUnitY == "cm")
                {

                    ValueProcessY = MovementProcessY(StepMotor_ValueY);
                    //myMMC.WriteString(ValueProcessY);
                  
                }
                else if (SteppingUnitY == "mm")
                {
                    ShowMessage("INFO", "select to mm");
                }

                ShowMessage("INFO", $"{ValueProcessX} {ValueProcessY}");
            }
            catch (Exception Ex)
            { 
                ShowMessage("ERROR", Ex.Message);
            
            }
           
            
        }
    }
}

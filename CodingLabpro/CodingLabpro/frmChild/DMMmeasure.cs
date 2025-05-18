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

namespace CodingLabpro.frmChild
{
    public partial class DMMmeasure : UserControl
    {
        private readonly Ivi.Visa.Interop.FormattedIO488 myDMM;
        private FrmMain01 mainForm;

        public DMMmeasure(Ivi.Visa.Interop.FormattedIO488 myDMM, FrmMain01 form)
        {
            InitializeComponent();
            this.myDMM = myDMM;
            this.mainForm = form;

            CBrange.Items.AddRange(new string[] {"10", "20", "Auto"});
            CBdelay.Items.AddRange(new string[] {"1000", "2000", "3000", "Auto"});
            CBtrigger.Items.AddRange(new string[] { "BUS", "IMMediate", "EXTernal" });
        }

        private void DMM_Write(string command)
        {
            try
            {
                myDMM.WriteString(command);
            }
            catch (Exception Ex)
            {
                ShowMessage("ERROR", "Can't Remote Multimeter" + Ex.Message);
            }
        }

        private string DMM_Read(string command)
        {
           myDMM.WriteString(command);
           return myDMM.ReadString();
        }
        private string MeasurementType()
        {
            if (RBvoltage.Checked)
            {
                return "VOLTage";
            }
            else if (RBcurrent.Checked)
            {
                return "CURRent";
            }
            return "";
        }

        private string MeasurementSource()
        {
            if (RBsource_DC.Checked)
            {
                return "DC";
            }
            else if (RBsource_AC.Checked)
            {
                return "AC";
            }
            return "";
        }

        public void ShowMessage(string type, string message)
        {
            Form MessageNotify = new MessageBox_Notify(type, message);
            MessageNotify.Show();
        }
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            DMM_Write("*CLS");
            ShowMessage("INFO", "Clear ERROR");
        }

        private void Btn_read_Click(object sender, EventArgs e)
        {
            DMM_Write("READ?");
            string Datavalue = myDMM.ReadString();

        }

        private void Btn_Error_Click(object sender, EventArgs e)
        {
            DMM_Write("SYSTem:ERRor?");
            string Data = myDMM.ReadString();
            ShowMessage("ERROR", Data);
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            DMM_Write("*RST"); 
            ShowMessage("INFO", "Reset Measurement");
        }
        
        //private string TriggerSource()
        //{
        //    if(CBtrigger.SelectedItem == null)
        //    {
        //        return "";
        //    }
        //    else
        //    {
        //        switch (CBtrigger.SelectedItem.ToString())
        //        {
        //            case "BUS":
        //                return "TRIGger:SOURce BUS";
        //            case "IMMediate":
        //                return "TRIGger:SOURce IMMediate";
        //            case "EXTernal":
        //                return "TRIGger:SOURce EXTernal";
                    
        //        }
        //    }
           
        //}

        private string CommandMeasurement(string Type, string source)
        {
            if(Type == "VOLTage" && source == "DC")
            {
                return "MEAS:VOLT:DC?";
            }
            else if (Type == "VOLTage" && source == "AC")
            {
                return "MEAS:VOLT:AC?";
            }
            else if(Type == "CURRent" && source == "DC")
            {
                return "MEASure:CURRent:DC?";
            }
            else if(Type == "CURRent" && source == "AC")
            {
                return "MEASure:CURRent:AC?";
            }
            return "";
        }
        private void Btn_Setup_Click(object sender, EventArgs e)
        {
            string InputMeasure = MeasurementType();
            string InputSource = MeasurementSource();
            //string TrigerSU = TriggerSource();
            string CommandMeasure = CommandMeasurement(InputMeasure, InputSource);
            DMM_Write(CommandMeasure);
            string datavalue = myDMM.ReadString();
            //string data = DMM_Read("READ?");

            ShowMessage("INFO", $"{InputMeasure}, {InputSource}, {CommandMeasure}\n" + datavalue);
            //DMM_Write(TrigerSU);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingLabpro.CommandDevice
{
    public class CalculateArea_Bind : EntityValidator
    {
        [Required]
        public string MoveStepX { get; set; }
        [Required]
        public string MoveStepY { get; set; }
        [Required]
        [Range(10, 25, ErrorMessage = "กรุณาเลือกค่าขอบเขตพื้นที่ช่วง 10-25mm")]
        public int? TotalAreaX { get; set; }
        [Required]
        [Range(10, 25, ErrorMessage = "กรุณาเลือกค่าขอบเขตพื้นที่ช่วง 10-25mm")]
        public int? TotalAreaY { get; set; }
        [Required(ErrorMessage = "กรุณาเลือกค่าเวลาการเคลื่อนที่")]
        public int? DelayStepping { get; set; }
        [Required(ErrorMessage = "กรุณาเลือกหน่วยการวัด")]
        public string UnitX { get; set; }
        [Required(ErrorMessage = "กรุณาเลือกหน่วยการวัด")]
        public string UnitY { get; set; }

        private float UnitXForCal(string UnitX)
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


        private float UnitYForCal(string UnitY)
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

        public int ReturnTimer()
        {
            int Timer = (int)DelayStepping;
            Debug.WriteLine($"timer = {Timer} ms");
            return Timer;
        }
     
      
        public int CalareaScanningX()
        {
            float CoVunitX = UnitXForCal(UnitX);
            int LoopAreaX = (int)((TotalAreaX * 1E-3f) / (float.Parse(MoveStepX) * CoVunitX));
            Debug.WriteLine("X loop " + LoopAreaX.ToString() + "\t" + MoveStepX + "\t" + CoVunitX.ToString());
            return LoopAreaX;
        }

        public int CalareaScanningY()
        {
            float CoVunitY = UnitYForCal(UnitY);
            int LoopAreaY = (int)((TotalAreaY * 1E-3f) / (float.Parse(MoveStepY) * CoVunitY));
            Debug.WriteLine("Y loop " + LoopAreaY.ToString() + "\t" + MoveStepY + "\t" + CoVunitY.ToString());
            return LoopAreaY;

        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingLabpro.Tracking_scan
{
    // สถานะของแต่ละ Scan Point
    public enum ScanCellStatus
    {
        Pending,
        Scanning,
        Completed,
        Error
    }

    // ข้อมูลของแต่ละตำแหน่ง
    public class ScanPoint
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public ScanCellStatus Status { get; set; }
            = ScanCellStatus.Pending;
    }

    // การตั้งค่าพื้นที่สแกน
    public class ScanSettings
    {
        public double AreaX { get; set; }
        public double AreaY { get; set; }
        public double StepX { get; set; }
        public double StepY { get; set; }
        public double StartX { get; set; }
        public double StartY { get; set; }

        // จำนวนตำแหน่ง X
        public int Columns =>
            (int)Math.Round(AreaX / StepX) + 1;

        // จำนวนตำแหน่ง Y
        public int Rows =>
            (int)Math.Round(AreaY / StepY) + 1;

        public void Validate()
        {
            if (AreaX < 0 || AreaY < 0)
                throw new ArgumentException("Area must not be negative.");

            if (StepX <= 0 || StepY <= 0)
                throw new ArgumentException("Step must be greater than zero.");

            if (Math.Abs(AreaX / StepX -
                Math.Round(AreaX / StepX)) > 0.000001)
                throw new ArgumentException("AreaX must be divisible by StepX.");

            if (Math.Abs(AreaY / StepY -
                Math.Round(AreaY / StepY)) > 0.000001)
                throw new ArgumentException("AreaY must be divisible by StepY.");
        }
    }
}
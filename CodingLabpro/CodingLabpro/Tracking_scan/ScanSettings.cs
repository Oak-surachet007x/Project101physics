
using System;

namespace CodingLabpro.Tracking_scan
{
    // สถานะของแต่ละตำแหน่ง
    public enum ScanCellStatus
    {
        Pending,       // ยังไม่เคลื่อนที่
        Scanning,        // มอเตอร์กำลังเคลื่อนที่
        Completed,     // เคลื่อนที่เสร็จแล้ว
        Error,         // เกิดข้อผิดพลาด
        Cancelled      // ถูกยกเลิก
    }

    // ข้อมูลของแต่ละตำแหน่งใน Grid
    public class ScanPoint
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public ScanCellStatus Status { get; set; }
    }

    // การตั้งค่าพื้นที่ Scan
    public class ScanSettings
    {
        public int AreaX { get; set; }
        public int AreaY { get; set; }
        public double StepX { get; set; }
        public double StepY { get; set; }
        public double StartX { get; set; }
        public double StartY { get; set; }

        // จำนวน Column
        public int Columns =>
            (int)Math.Round(AreaX / StepX);

        // จำนวน Row
        public int Rows =>
            (int)Math.Round(AreaY / StepY);

        // ตรวจสอบค่าการตั้งค่า
        public void Validate()
        {
            if (AreaX < 0 || AreaY < 0)
            {
                throw new ArgumentException("Scan Area must not be negative.");
            }

            if (StepX <= 0 || StepY <= 0)
            {
                throw new ArgumentException("Step must be greater than zero.");
            }

            if (Math.Abs(AreaX / StepX - Math.Round(AreaX / StepX)) > 0.000001)
            {
                throw new ArgumentException(
                    "AreaX must be divisible by StepX.");
            }

            if (Math.Abs(AreaY / StepY - Math.Round(AreaY / StepY)) > 0.000001)
            {
                throw new ArgumentException(
                    "AreaY must be divisible by StepY.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingLabpro.CommandDevice
{
    public class CalculateCellsDataTable : IDataTableBuilder
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public DataTable MeasurementTable { get;  private set; }

        public CalculateCellsDataTable(int rows, int columns)
        { 
            Rows = rows;
            Columns = columns;
        }

        //เมธอดสร้างตารางข้อมูล
        public DataTable BuildTable()
        {
            MeasurementTable = new DataTable();

            MeasurementTable.Clear();

            // สร้างคอลัมน์ตามจำนวน Columns ที่กำหนด
            for (int c = 0; c < Columns; c++)
            {
                MeasurementTable.Columns.Add($"Step{c + 1} ({GlobalMeasurementSettings.Instance.MeasureMode})", typeof(double));
            }

            // สร้างแถวตามจำนวน Rows ที่กำหนด
            for (int r = 0; r < Rows; r++)
            {
                DataRow row = MeasurementTable.NewRow();
                row[r] = DBNull.Value;
                MeasurementTable.Rows.Add(row);
            }

            return MeasurementTable;
        }

        //เมธอดอัปเดตค่าข้อมูลในเซลล์ตาราง
        public void UpdateCell(int row, int col, double value)
        {
            if (MeasurementTable == null) return;

            if (row < 0 || row >= MeasurementTable.Rows.Count) return;
            if (col < 0 || col >= MeasurementTable.Columns.Count) return;

            MeasurementTable.Rows[row][col] = value;

        }

        //เมธอดรายงานข้อมูลดีบัก
        public void DebugReport()
        {
            Debug.WriteLine($"[Table] Rows count : {Rows}");
            Debug.WriteLine($"[Table] Columns count : {Columns}");
            Debug.WriteLine($"[Table] Total Cells : {Rows*Columns}");
        }
        


    }
}

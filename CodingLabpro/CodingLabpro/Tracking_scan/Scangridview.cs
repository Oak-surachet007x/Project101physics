
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CodingLabpro.Tracking_scan
{
    public class Scangridview
    {
        private readonly DataGridView gridView;
        private byte[,] _status;                       // [row, col] = ScanCellStatus
        private readonly Timer _refresh = new Timer { Interval = 1000 };

        // กำหนดสีของสถานะ
        private static readonly Color[] colors = new Color[]
        {
            Color.LightGray,   // Pending
            Color.Yellow,      // Scanning
            Color.LightGreen,  // Completed
            Color.Red,         // Error
            Color.LightGray    // Cancelled
        };

        public Scangridview(DataGridView dataGridView)
        {
            gridView = dataGridView;
            gridView.VirtualMode = true;

            gridView.CellValueNeeded += (s, e) => e.Value = null;   // ไม่แสดงข้อความในเซลล์

            gridView.CellFormatting += (s, e) =>
            {
                var st = _status;
                if (st == null || e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (e.RowIndex >= st.GetLength(0) || e.ColumnIndex >= st.GetLength(1)) return;

                var c = colors[st[e.RowIndex, e.ColumnIndex]];
                e.CellStyle.BackColor = c;
                e.CellStyle.SelectionBackColor = c;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionForeColor = Color.Black;
            };

            // แสดงเลขแถวโดยไม่สร้าง HeaderCell ต่อแถว
            gridView.RowPostPaint += (s, e) =>
            {
                var fmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center};
                var rect = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, gridView.RowHeadersWidth, e.RowBounds.Height);
                var font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), font, SystemBrushes.ControlText, rect, fmt);
            };

            _refresh.Tick += (s, e) => gridView.Invalidate();
            _refresh.Start();
        }

        public void InitializeGrid(int rows, int columns)
        {
            if (gridView.InvokeRequired)
            {
                gridView.Invoke(new Action<int, int>(InitializeGrid), rows, columns);
                return;
            }

            gridView.SuspendLayout();
            try
            {
                _status = new byte[rows, columns];          // Pending = 0  <-- บรรทัดที่ขาดอยู่

       
                gridView.Columns.Clear();

                gridView.AllowUserToAddRows = false;
                gridView.AllowUserToDeleteRows = false;
                gridView.AllowUserToResizeRows = false;
                gridView.AllowUserToResizeColumns = false;

                gridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point, 0);
                gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point, 0);

                gridView.ReadOnly = true;
                gridView.MultiSelect = false;
                gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                
                gridView.RowHeadersWidth = 45;
                gridView.RowTemplate.Height = 25;
                gridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                gridView.GridColor = Color.White;
                gridView.BackgroundColor = Color.White;
                gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                


                var cols = new DataGridViewColumn[columns];
                for (int c = 0; c < columns; c++)
                {
                    cols[c] = new DataGridViewTextBoxColumn
                    {
                        Name = "X" + c,
                        HeaderText = (c + 1).ToString(),
                        Width = 35,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                }


                gridView.Columns.AddRange(cols);
                gridView.RowCount = rows;      // ตอนนี้ปลอดภัยแล้ว
                gridView.ClearSelection();

            }
            finally
            {
                gridView.ResumeLayout();
            }
        }

        // อัปเดตสถานะของแต่ละตำแหน่ง
        public void UpdateCellStatus(int row, int column, ScanCellStatus status)
        {
            var s = _status;
            if (s != null && row < s.GetLength(0) && column < s.GetLength(1))
                s[row, column] = (byte)status;

        }
       
    }
}

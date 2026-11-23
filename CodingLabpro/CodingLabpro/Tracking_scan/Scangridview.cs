
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodingLabpro.Tracking_scan
{
    public class Scangridview
    {
        private readonly DataGridView gridView;

        // กำหนดสีของสถานะ
        private readonly Color PendingColor = Color.LightGray;
        private readonly Color MovingColor = Color.Yellow;
        private readonly Color CompletedColor = Color.LightGreen;
        private readonly Color ErrorColor = Color.Red;
        private readonly Color CancelledColor = Color.Orange;

        public Scangridview(DataGridView dataGridView)
        {
            gridView = dataGridView;
        }

        // สร้างตาราง Scan Grid
        public void InitializeGrid(int rows, int columns)
        {
            if (gridView.InvokeRequired)
            {
                gridView.Invoke(
                    new Action<int, int>(InitializeGrid),
                    rows, columns);

                return;
            }

            gridView.SuspendLayout();

            try
            {
                gridView.Columns.Clear();
                gridView.Rows.Clear();

                // ตั้งค่าตาราง
                gridView.AllowUserToAddRows = false;
                gridView.AllowUserToDeleteRows = false;
                gridView.AllowUserToResizeRows = false;
                gridView.AllowUserToResizeColumns = false;

                gridView.ReadOnly = true;
                gridView.MultiSelect = false;

                gridView.RowHeadersVisible = true;
                gridView.ColumnHeadersVisible = true;

                gridView.SelectionMode =
                    DataGridViewSelectionMode.CellSelect;

                gridView.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.None;

                gridView.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells;

                gridView.RowHeadersWidth = 55;

                gridView.CellBorderStyle =
                    DataGridViewCellBorderStyle.Single;

                gridView.GridColor = Color.White;
                gridView.BackgroundColor = Color.White;

                gridView.ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                gridView.RowHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                // สร้าง Column
                for (int column = 0; column < columns; column++)
                {
                    gridView.Columns.Add(
                        "X" + column,
                        (column + 1).ToString());

                    gridView.Columns[column].Width = 35;

                    gridView.Columns[column].SortMode =
                        DataGridViewColumnSortMode.NotSortable;
                }

                // สร้าง Row
                gridView.Rows.Add(rows);

                for (int row = 0; row < rows; row++)
                {
                    gridView.Rows[row].HeaderCell.Value = (row + 1).ToString();
                    gridView.Rows[row].Height = 25;

                    for (int column = 0; column < columns; column++)
                    {
                        DataGridViewCell cell =
                            gridView.Rows[row].Cells[column];

                        // ไม่แสดงข้อความหรือค่าตัวเลข
                        cell.Value = null;

                        SetCellColor(cell, PendingColor);
                    }
                }

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
            if (gridView == null ||
                gridView.IsDisposed ||
                !gridView.IsHandleCreated)
                return;

            // ตรวจสอบ Thread ก่อนแก้ไข DataGridView
            if (gridView.InvokeRequired)
            {
                gridView.BeginInvoke(new Action(() =>
                    UpdateCellStatus(row, column, status)));

                return;
            }

            if (row < 0 || row >= gridView.Rows.Count)
                return;

            if (column < 0 || column >= gridView.Columns.Count)
                return;

            DataGridViewCell cell =
                gridView.Rows[row].Cells[column];

            Color color;

            switch (status)
            {
                case ScanCellStatus.Pending:
                    color = Color.LightGray;
                    break;

                case ScanCellStatus.Scanning:
                    color = Color.Yellow;
                    break;

                case ScanCellStatus.Completed:
                    color = Color.LightGreen;
                    break;

                case ScanCellStatus.Error:
                    color = Color.Red;
                    break;

                default:
                    color = Color.LightGray;
                    break;
            }

            cell.Value = "";
            cell.Style.BackColor = color;
            cell.Style.SelectionBackColor = color;
        }
        // กำหนดสีให้ Cell
        private void SetCellColor(DataGridViewCell cell, Color color)
        {
            cell.Value = null;
            cell.Style.BackColor = color;
            cell.Style.SelectionBackColor = color;
            cell.Style.ForeColor = Color.Black;
            cell.Style.SelectionForeColor = Color.Black;
            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}

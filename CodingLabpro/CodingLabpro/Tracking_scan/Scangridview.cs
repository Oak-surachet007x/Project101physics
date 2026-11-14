using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingLabpro.Tracking_scan
{
    public class Scangridview
    {
        private readonly DataGridView gridView;
        
        public Scangridview(DataGridView dataGridView)
        {
            gridView = dataGridView;
        }

        public void intializeGrid(int rows, int columns)
        {
            if (gridView.InvokeRequired)
            {
                gridView.Invoke(new Action<int, int>(intializeGrid), rows, columns);
                return;
            }

            gridView.SuspendLayout();

            try
            {
                gridView.Columns.Clear();
                gridView.Rows.Clear();

                gridView.AllowUserToAddRows = false;
                gridView.AllowUserToDeleteRows = false;
                gridView.AllowUserToResizeRows = false;
                gridView.AllowUserToResizeColumns = false;
                gridView.ReadOnly = true;
                gridView.MultiSelect = false;
                gridView.RowHeadersVisible = true;
                gridView.ColumnHeadersVisible = true;
                gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                gridView.RowHeadersWidth = 55;
                gridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                gridView.GridColor = Color.White;
                gridView.BackgroundColor = Color.White;

                gridView.ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                gridView.RowHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                for (int column = 0; column < columns; column++)
                {
                    gridView.Columns.Add("X" + column, (column + 1).ToString());
                    gridView.Columns[column].Width = 35;
                    gridView.Columns[column].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                gridView.Rows.Add(rows);

                for (int row = 0; row < rows; row++)
                {
                    gridView.Rows[row].Height = 35;
                    gridView.Rows[row].HeaderCell.Value = (row + 1).ToString();

                    for (int column = 0; column < columns; column++)
                    {
                        DataGridViewCell cell = gridView.Rows[row].Cells[column];
                        cell.Value = "";
                        cell.Style.BackColor = Color.LightGray;
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        cell.Style.SelectionBackColor = Color.LightGray;
                        cell.Style.SelectionForeColor = Color.Black;
                    }
                }

                gridView.ClearSelection();
            }
            finally
            {
                gridView.ResumeLayout();
            }
        }

        public void UpdateCellStatus(int row, int column, ScanCellStatus status)
        {
            if (row < 0 || row >= gridView.Rows.Count) return;
            if (column < 0 || column >= gridView.Columns.Count) return;
            var cell = gridView.Rows[row].Cells[column];
            switch (status)
            {
                case ScanCellStatus.Pending:
                    cell.Style.BackColor = System.Drawing.Color.LightGray;
                    cell.Value = "Pending";
                    break;
                case ScanCellStatus.Scanning:
                    cell.Style.BackColor = System.Drawing.Color.Yellow;
                    cell.Value = "Scanning";
                    break;
                case ScanCellStatus.Completed:
                    cell.Style.BackColor = System.Drawing.Color.LightGreen;
                    cell.Value = "Completed";
                    break;
                case ScanCellStatus.Error:
                    cell.Style.BackColor = System.Drawing.Color.Red;
                    cell.Value = "Error";
                    break;
            }
        }

    }
}

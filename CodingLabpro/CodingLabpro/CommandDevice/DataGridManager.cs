using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodingLabpro.frmChild;

namespace CodingLabpro.CommandDevice
{
    public class DataGridManager
    {
        private DataTable Dt;
        private DataGridView dataGridView;
        private DataSet M_dataGrid = new DataSet();
        public DataGridManager(DataGridView dgv) 
        {
            this.dataGridView = dgv;
            InitializeGridColumn();

        }

        public void InitializeGridColumn()
        {
            Dt = new DataTable("MainGrid");
            M_dataGrid.Tables.Add(Dt);

            //ADD Columns
            Dt.Columns.Add("Step_1", typeof(int));
            Dt.Columns.Add("Step_2", typeof(int));
            Dt.Columns.Add("Step_3", typeof(int));
            Dt.Columns.Add("Step_4", typeof(int));
            Dt.Columns.Add("Step_5", typeof(int));
            Dt.Columns.Add("Step_6", typeof(int));
            Dt.Columns.Add("Step_7", typeof(int));
            Dt.Columns.Add("Step_8", typeof(int));
            Dt.Columns.Add("Step_9", typeof(int));
            Dt.Columns.Add("Step_10", typeof(int));

            dataGridView.DataSource = Dt;
        }

        public async Task LoadDataTable()
        {
            //data Row
            DataRow NewdataRow;
            NewdataRow = Dt.NewRow();

            while (NewdataRow != null)
            {
                NewdataRow["Step_1"] = AxisControl.datastep;
                NewdataRow["Step_2"] = AxisControl.datastep;
                NewdataRow["Step_3"] = AxisControl.datastep;
                NewdataRow["Step_4"] = AxisControl.datastep;
                NewdataRow["Step_5"] = AxisControl.datastep;
                NewdataRow["Step_6"] = AxisControl.datastep;
                NewdataRow["Step_7"] = AxisControl.datastep;
                NewdataRow["Step_8"] = AxisControl.datastep;
                NewdataRow["Step_9"] = AxisControl.datastep;
                NewdataRow["Step_10"] = AxisControl.datastep;
                Dt.Rows.Add(NewdataRow);
            }

            dataGridView.Invoke((MethodInvoker)(() => {dataGridView.Refresh();}));

            await Task.Delay(1000);
        }
    }
}

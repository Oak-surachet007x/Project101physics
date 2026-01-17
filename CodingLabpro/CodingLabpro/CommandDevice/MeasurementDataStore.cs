using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;

namespace CodingLabpro.CommandDevice
{
    public sealed class MeasurementDataStore
    {
        private static readonly Lazy<MeasurementDataStore> _instance =
        new Lazy<MeasurementDataStore>(() => new MeasurementDataStore());

        public static MeasurementDataStore Instance => _instance.Value;
        public DataTable MeasurementTable { get; private set; }
        private MeasurementDataStore()
        {
            
        }

        public DataTable ConvertArrayToTable(int Rows, int Columns)
        {
            MeasurementTable = new DataTable();

            MeasurementTable.Columns.Add("Unit", typeof(int));

            for (int c = 0; c < Columns; c++)
            {
                MeasurementTable.Columns.Add($"Step {c + 1}", typeof(double));
            }

            for (int r = 0; r < Rows; r++)
            {
                var row = MeasurementTable.NewRow();
                row["Unit"] = r + 1;
                MeasurementTable.Rows.Add(row);
            }

            return MeasurementTable;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingLabpro.CommandDevice
{
    public interface IDataTableBuilder
    {
        DataTable BuildTable();
    }
}

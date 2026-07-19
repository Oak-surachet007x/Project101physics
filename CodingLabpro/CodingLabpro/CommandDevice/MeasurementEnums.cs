using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingLabpro.CommandDevice
{
    //เมธอดนี้ใช้สำหรับเก็บค่าคงที่ของ MeasurementEnums และ Enum ต่างๆ
    public class MeasurementEnums
    {

    }

    public enum MeasureMode
    {
        Voltage,
        Current,
        Resistance2Wire,
        Resistance4Wire,
        Frequency,
        Period
    }

    public enum SourceMode
    {
        None,
        DC,
        AC
    }

    public enum RangeMode
    {
        AUTO,
        CUSTOM
    }

    public enum ResolutionMode
    {
        AUTO,
        MIN,
        MAX,
        DIGITS_4,
        CUSTOM
    }

    public enum TriggerMode
    {
        IMMediate,
        BUS,
        EXTernal,
        None
    }
}

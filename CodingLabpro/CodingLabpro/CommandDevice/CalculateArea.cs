using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingLabpro.CommandDevice
{
    public class CalculateArea
    {
        private string _MoveStepX;
        private string _MoveStepY;
        private string _TotalAreaX;
        private string _TotalAreaY;
        private float _UnitX;
        private float _UnitY;

        public string MoveStepX { get => _MoveStepX; set => _MoveStepX = value; }
        public string MoveStepY { get => _MoveStepY; set => _MoveStepY = value; }
        public string TotalAreaX { get => _TotalAreaX; set => _TotalAreaX = value; }
        public string TotalAreaY { get => _TotalAreaY; set => _TotalAreaY = value; }
        public float UnitX { get => _UnitX; set => _UnitX = value; }
        public float UnitY { get => _UnitY; set => _UnitY = value; }

        public int CalareaScanningX ()
        {
            int LoopAreaX = (int)((float.Parse(_TotalAreaX) * 1E-3f) / (float.Parse(_MoveStepX) * _UnitX));
            Debug.WriteLine("X loop " + LoopAreaX.ToString() + "\t" + _MoveStepX + "\t" + _UnitX.ToString());
            return LoopAreaX;
        }

        public int CalareaScanningY()
        {
            int LoopAreaY = (int)((float.Parse(_TotalAreaY) * 1E-3f) / (float.Parse(_MoveStepY) * _UnitY));
            Debug.WriteLine("Y loop " + LoopAreaY.ToString() + "\t" + _MoveStepY + "\t" + _UnitY.ToString());
            return LoopAreaY;
        }
    }
}

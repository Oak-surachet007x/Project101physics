using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingLabpro.CommandDevice
{
    public class GlobalMeasurementSettings : INotifyPropertyChanged
    {
        private static readonly Lazy<GlobalMeasurementSettings> _instance =
        new Lazy<GlobalMeasurementSettings>(() => new GlobalMeasurementSettings());

        public static GlobalMeasurementSettings Instance => _instance.Value;

        private string _MeasureMode;
        private string _SourceMode;
        private string _TriggerMode;
        private string _AutozeroMode = "ON";
        private string _RangeControl = "AUTO";
        private string _ResolutionControl = "AUTO";
        private string _UnitPrefix;
        private int _CountOfRows;
        private int _CountOfColumns;
        
        public event EventHandler SettingsChanged;

        public string MeasureMode {
            get => _MeasureMode;
            set
            {
                SetProperty(ref _MeasureMode, value);
                SettingsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public string SourceMode { 
            get => _SourceMode;
            set
            {
                SetProperty(ref _SourceMode, value);
                SettingsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public string TriggerMode
        {
            get => _TriggerMode;
            set => SetProperty(ref _TriggerMode, value);
        }

        public string AutozeroMode
        {
            get => _AutozeroMode;
            set => SetProperty(ref _AutozeroMode, value);
        }

        public string RangeControl
        {
            get => _RangeControl;
            set => SetProperty(ref _RangeControl, value);
        }

        public string ResolutionControl
        {
            get => _ResolutionControl;
            set => SetProperty(ref _ResolutionControl, value);
        }

        public string UnitPrefix
        {
            get => _UnitPrefix;
            set => SetProperty(ref _UnitPrefix, value);
        }

        public int CountOfRows
        {
            get => _CountOfRows;
            set => SetProperty(ref _CountOfRows, value);
        }

        public int CountOfColumns
        {
            get => _CountOfColumns;
            set => SetProperty(ref _CountOfColumns, value);
        }


        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
            
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

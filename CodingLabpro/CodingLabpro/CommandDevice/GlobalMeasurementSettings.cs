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

        private string _MeasureMode = "Voltage";
        private string _SourceMode = "DC";
        private string _TriggerMode = "IMMediate";
        private string _AutozeroMode = "ON";

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

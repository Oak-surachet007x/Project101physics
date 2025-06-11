using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivi.Visa;

namespace CodingLabpro.CommandDevice
{
    public class FindDevices
    {
        // Event สำหรับ onDeviceFound
        public event Action<string> OnDeviceFound;
        public event Action<string> OnDeviceFound1;
        public void FDevice()
        {
            IEnumerable<string> devices;
            try
            {
                // Finding all devices and interfaces is straightforward
                devices = GlobalResourceManager.Find("GPIB?*INSTR");


                foreach (string device in devices)
                {
                    OnDeviceFound?.Invoke(device);
                }
            }
            catch (VisaException ex)
            {
                Console.WriteLine("Didn't find any devices!" + ex.Message);
            }
        }

        public void RSdevice()
        {
            IEnumerable<string> Rsdevices;

            try
            {
                // Finding all devices and interfaces is straightforward
                Rsdevices = SerialPort.GetPortNames();

                foreach (string device1 in Rsdevices)
                {
                    //OnDeviceFound1?.Invoke(GlobalResourceManager.Parse(device1).AliasIfExists);
                    OnDeviceFound1?.Invoke(device1);
                }
            }
            catch (VisaException ex)
            {
                Console.WriteLine("Didn't find any devices!" + ex.Message);
            }
        }
    }
}

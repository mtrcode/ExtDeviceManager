using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtDeviceManager
{
    public class Device
    {
        public string Name { get; set; } = "Неизвестное устройство";
        public string DeviceId { get; set; } = "Нет ID";
        public string Status { get; set; } = "Неизвестно";

        public Device(string name, string deviceID, string status)
        {
            Name = name;
            DeviceId = deviceID;
            Status = status;
        }

        public override bool Equals(object obj)
        {
            if (obj is Device other)
                return Name == other.Name && DeviceId == other.DeviceId;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, DeviceId);
        }
    }
}

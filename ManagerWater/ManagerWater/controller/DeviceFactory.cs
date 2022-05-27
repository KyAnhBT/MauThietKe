using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    //Ap factory pattern
    //Factory class
    public class DeviceFactory
    {
        public enum DeviceType
        {
            VoiSen,
            BonVeSinh,
            MayNuocNong,
            Lavabo,
        }

        private DeviceFactory(){ }

        public static Device getDevice1(DeviceType type, int cubicmetre_id)
        {
            if (type == DeviceType.VoiSen)
            {
                return new Device_VoiSen(cubicmetre_id);
            }
            else if(type == DeviceType.BonVeSinh)
            {
                return new Device_BonVeSinh(cubicmetre_id);
            }
            else if (type == DeviceType.MayNuocNong)
            {
                return new Device_MayNuocNong(cubicmetre_id);
            }
            else if (type == DeviceType.Lavabo)
            {
                return new Device_Lavabo(cubicmetre_id);
            }
            else
            {
                return null;
            }
        }
    }
}

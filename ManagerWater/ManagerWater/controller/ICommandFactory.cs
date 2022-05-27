using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap command pattern
    //
    class ICommandFactory
    {
        public ICommand CreateCommand(string type)
        {
            Customers customers = new Customers();
            Customers customer = customers.findCustomer(Program.phone);

            //Voisen
            Device_VoiSen voiSen;
            voiSen = (Device_VoiSen)Device.getDevice1(DeviceFactory.DeviceType.VoiSen, customer.CubicMetre_ID);

            //BonVeSinh
            Device_BonVeSinh bonVeSinh;
            bonVeSinh = (Device_BonVeSinh)Device.getDevice1(DeviceFactory.DeviceType.BonVeSinh, customer.CubicMetre_ID);

            //MayNuocNong
            Device_MayNuocNong mayNuocNong;
            mayNuocNong = (Device_MayNuocNong)Device.getDevice1(DeviceFactory.DeviceType.MayNuocNong, customer.CubicMetre_ID);

            //Lavabo
            Device_Lavabo lavabo;
            lavabo = (Device_Lavabo)Device.getDevice1(DeviceFactory.DeviceType.Lavabo, customer.CubicMetre_ID);

            if (type == "VoiSen")
            {
                return new ICommand_VoiSen(voiSen);
            }
            else if(type == "BonVeSinh")
            {
                return new ICommand_BonVeSinh(bonVeSinh);
            }
            else if (type == "MayNuocNong")
            {
                return new ICommand_MayNuocNong(mayNuocNong);
            }
            else if (type == "Lavabo")
            {
                return new ICommand_Lavabo(lavabo);
            }
            else
            {
                return null;
            }
        }
    }
}

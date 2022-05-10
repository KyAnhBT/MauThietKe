using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap command pattern
    //ConcreteCommand
    public class ICommand_MayNuocNong: ICommand
    {
        private Device_MayNuocNong mayNuocNong;

        public ICommand_MayNuocNong(Device_MayNuocNong mayNuocNong)
        {
            this.mayNuocNong = mayNuocNong;
        }

        public string getName()
        {
            return "MayNuocNong";
        }

        public void turnOff()
        {
            mayNuocNong.turnOff();
        }

        public void turnOn()
        {
            mayNuocNong.turnOn();
        }
    }
}

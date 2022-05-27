using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap command pattern
    //ConcreteCommand
    public class ICommand_BonVeSinh : ICommand
    {
        private Device_BonVeSinh bonVeSinh;

        public ICommand_BonVeSinh(Device_BonVeSinh bonVeSinh)
        {
            this.bonVeSinh = bonVeSinh;
        }

        public string getName()
        {
            return "BonVeSinh";
        }

        public void turnOff()
        {
            bonVeSinh.turnOff();
        }

        public void turnOn()
        {
            bonVeSinh.turnOn();
        }
    }
}

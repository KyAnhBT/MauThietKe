using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap command pattern
    //ConcreteCommand
    public class ICommand_Lavabo : ICommand
    {
        private Device_Lavabo lavabo;

        public ICommand_Lavabo(Device_Lavabo lavabo)
        {
            this.lavabo = lavabo;
        }

        public string getName()
        {
            return "Lavabo";
        }

        public void turnOff()
        {
            lavabo.turnOff();
        }

        public void turnOn()
        {
            lavabo.turnOn();
        }
    }
}

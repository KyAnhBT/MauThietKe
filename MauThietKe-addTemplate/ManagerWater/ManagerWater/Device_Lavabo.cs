using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    //AP Factory Pattern
    //SubClass
    public class Device_Lavabo : Device
    {
        public Device_Lavabo(int cubicMetreID) : base("Lavabo", 0.14f, cubicMetreID)
        {

        }

        public override void turnOff()
        {
            this.stop();
        }

        public override void turnOn()
        {
            this.use();
        }
    }
}

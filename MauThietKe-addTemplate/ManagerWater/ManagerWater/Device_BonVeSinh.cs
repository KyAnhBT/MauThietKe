using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    //AP Factory Pattern
    //SubClass
    public class Device_BonVeSinh: Device
    {
        public Device_BonVeSinh(int cubicMetreID) : base("BonVeSinh", 0.14f, cubicMetreID)
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

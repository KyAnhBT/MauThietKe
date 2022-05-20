using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Áp dụng adapter pattern

    //Target interface
    public interface VNDTarget
    {
        float change(float money);
    }

}
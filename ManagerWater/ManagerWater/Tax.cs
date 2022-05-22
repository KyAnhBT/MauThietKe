using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
   public interface DiaDiem
    {
        public Double thue(ThoiGian ThoiGian);
    }
    public interface ThoiGian
    {
        public Double thueBy(NoiThanh NoiThanh);
        public Double thueBy(NgoaiThanh NgoaiThanh);
    }
    public class NoiThanh : DiaDiem
    {
        public Double thue(ThoiGian ThoiGian)
        {
            return ThoiGian.thueBy(this);
        }
    }
    public class NgoaiThanh : DiaDiem
    {
        public Double thue(ThoiGian ThoiGian)
        {
            return ThoiGian.thueBy(this);
        }
    }
    public class Three : ThoiGian
    {
        public Double thueBy(NoiThanh NoiThanh)
        {
            return 0.13;
        }
        public Double thueBy(NgoaiThanh NgoaiThanh)
        {
            return 0.1;
        }

    }
    public class Six : ThoiGian
    {
        public Double thueBy(NoiThanh NoiThanh)
        {
            return 0.15;
        }
        public Double thueBy(NgoaiThanh NgoaiThanh)
        {
            return 0.13;
        }

    }
    public class Twelve : ThoiGian
    {
        public Double thueBy(NoiThanh NoiThanh)
        {
            return 0.18;
        }
        public Double thueBy(NgoaiThanh NgoaiThanh)
        {
            return 0.16;
        }

    }
}

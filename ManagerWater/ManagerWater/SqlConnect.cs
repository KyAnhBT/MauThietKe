﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace ManagerWater
{
    public class SqlConnect
    {
        private const string ConnectionString = "Data Source=DESKTOP-DDKM1BA;Initial Catalog=ManagerWater;Integrated Security=True";
        protected SqlConnection conn = new SqlConnection(ConnectionString);
    }
}

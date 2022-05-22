using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace ManagerWater
{
    public class SqlConnect
    {
        private const string ConnectionString = "Data Source=LAPTOP-9V8839UD"+@"\"+"KYANH;Initial Catalog=ManagerWater;Integrated Security=True";
        protected SqlConnection conn = new SqlConnection(ConnectionString);
    }
}

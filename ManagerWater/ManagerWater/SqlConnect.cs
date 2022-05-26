using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace ManagerWater
{
    public class SqlConnect
    {
        private const string ConnectionString = @"Data Source=MSI\SQL;Initial Catalog=ManagerWater;User ID=sa;Password=123456;Integrated Security=True";
        protected SqlConnection conn = new SqlConnection(ConnectionString);
    }
}

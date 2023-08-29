using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace App_reto1
{
    public class cls_conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EEKCIUN\\SQLEXPRESS;Initial Catalog=dbs_creditos;Integrated Security=True");
    }
}
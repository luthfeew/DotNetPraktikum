using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum8
{
    internal class Koneksi
    {
        SqlConnection con = new SqlConnection(@"Data source=MATRIXDESKTOP\SQLEXPRESS;initial catalog=kantinAmikom;integrated security=True;");
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Conexao
{
    class dal
    {
       // Data Source = LAB2 - 11; Initial Catalog = tcc; Integrated Security = True
          public static string conexao = @"
        Data Source=LAB2-11;Initial Catalog=tcc;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conexao);
        SqlCommand cmd = null;
    }
}

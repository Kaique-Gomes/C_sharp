using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Dados
{
    class Banco
    {
        public static string conexao = "Colocar conexao";

        SqlConnection conn = new SqlConnection(conexao);

        SqlConnection cmd = null;

        public void ComandoSQL(string Sql)
        {
            conn.Open();
            cmd = new SqlCommand(Sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Consultar (DataGridView dgv, string Sql)
        {
            cmd = new SqlCommand(Sql, conn);
            conn.Open();

            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable Cliente = new DataTable();

            da.Fill(cliente);

            dgv.DataSource = Cliente;

            conn.Close();
        }
    }
}

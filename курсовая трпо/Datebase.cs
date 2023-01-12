using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая_трпо
{
    internal class Datebase
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");

        public void openonnection()
        {
            if(con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                MessageBox.Show("Вы уже вошли");
            }
        }
        public void closeonnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                MessageBox.Show("База данных закрыта");
            }
        }
        public SqlConnection getconnection()
        {
            return con;
        }
    }
}

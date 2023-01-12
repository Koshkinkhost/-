using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace курсовая_трпо
{
    public partial class @new : Form
    {
        DataTable dt=new DataTable();
        public @new()
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
        }

        private void new_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string q = $"SELECT TOP(1000) [surname],[order_num],[type_of],[date_1],[date_2],[surname_master],[cost] FROM[course].[dbo].[course_db]where surname_master = '{textBox1.Text}'";
            SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
            com.Open();
            SqlCommand c = new SqlCommand(q, com);
            SqlDataAdapter adapter = new SqlDataAdapter($" SELECT TOP(1000) [surname],[order_num],[type_of],[date_1],[date_2],[surname_master],[cost] FROM[course].[dbo].[course_db]where surname_master = '{textBox1.Text}'", com);
            adapter.Fill(dt);

            c.ExecuteNonQuery();
        }
    }
}

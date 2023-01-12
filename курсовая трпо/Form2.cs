using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace курсовая_трпо
{
    public partial class Form2 : Form
    {
        SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "Вы уверены,что хотите удалить информацию об этом человеке?";
            const string caption = "Подтверждение";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                com.Open();
                string q = $"DELETE  FROM course_db WHERE surname='{textBoxdel.Text}'";

                SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
                SqlCommand c = new SqlCommand(q, com);
                c.ExecuteNonQuery();
                adapter.Update(dt);
                com.Close();
            }
           
        }
    }
}

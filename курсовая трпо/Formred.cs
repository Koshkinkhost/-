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
    public partial class Formred : Form
    {
        public Formred()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formred_Load(object sender, EventArgs e)
        {

        }
        SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
        DataTable date = new DataTable();
        private void button7_Click(object sender, EventArgs e)
        {
            com.Open();
            string q = $"UPDATE course_db SET surname='{textBox1.Text}',type_of='{textBox2.Text}',date_1='{textBox3.Text}',date_2='{textBox4.Text}',surname_master='{textBox5.Text}',cost='{textBox6.Text}' Where order_num='{textBox7.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
            SqlCommand c = new SqlCommand(q, com);
            c.ExecuteNonQuery();
            adapter.Fill(date);
            adapter.Update(date);
            MessageBox.Show($"{c.ExecuteScalar()}");
            com.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Open();
            string q1 = $"Select count (order_num) FROM course_db WHERE order_num={textBox7.Text}";
            SqlDataAdapter ad = new SqlDataAdapter($"Select * from course_db where exists (select * from course_db where order_num ={textBox7.Text})", com);
            SqlCommand co = new SqlCommand(q1, com);


            if ((int)co.ExecuteScalar() == 0)
            {
                MessageBox.Show("Такого заказа не существует!");
                

            }
            com.Close();
          



                com.Open();
                string q = $"UPDATE course_db SET surname='{textBox1.Text}' Where order_num='{textBox7.Text}'";
                SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
                SqlCommand c = new SqlCommand(q, com);
                c.ExecuteNonQuery();
                adapter.Fill(date);
                adapter.Update(date);
                MessageBox.Show($" Данные изменены");
                com.Close();
            
        }
        Registerform f=new Registerform();
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            com.Open();
            string q = $"UPDATE course_db SET type_of='{textBox1.Text}' Where order_num='{textBox7.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
            SqlCommand c = new SqlCommand(q, com);
            c.ExecuteNonQuery();
            adapter.Fill(date);
            adapter.Update(date);
            MessageBox.Show($"{c.ExecuteScalar()}");
            com.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            com.Open();
            string q = $"UPDATE course_db SET date_1='{textBox1.Text}' Where order_num='{textBox7.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
            SqlCommand c = new SqlCommand(q, com);
            c.ExecuteNonQuery();
            adapter.Fill(date);
            adapter.Update(date);
            MessageBox.Show($"{c.ExecuteScalar()}");
            com.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            com.Open();
            string q = $"UPDATE course_db SET date_2='{textBox1.Text}' Where order_num='{textBox7.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
            SqlCommand c = new SqlCommand(q, com);
            c.ExecuteNonQuery();
            adapter.Fill(date);
            adapter.Update(date);
            MessageBox.Show($"{c.ExecuteScalar()}");
            com.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            com.Open();
            string q = $"UPDATE course_db SET surname_master='{textBox1.Text}' Where order_num='{textBox7.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
            SqlCommand c = new SqlCommand(q, com);
            c.ExecuteNonQuery();
            adapter.Fill(date);
            adapter.Update(date);
            MessageBox.Show($"{c.ExecuteScalar()}");
            com.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            com.Open();
            string q = $"UPDATE course_db SET cost='{textBox1.Text}' Where order_num='{textBox7.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
            SqlCommand c = new SqlCommand(q, com);
            c.ExecuteNonQuery();
            adapter.Fill(date);
            adapter.Update(date);
            MessageBox.Show($"{c.ExecuteScalar()}");
            com.Close();
        }
    }
}

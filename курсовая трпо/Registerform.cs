using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Input;
using System.IO;

namespace курсовая_трпо
{
    enum Rowscon
    {
        isexist,
        isnew,
        modified,
        modifiednew,
        delete,
    }
    public partial class Registerform : Form
    {
      
        Datebase db = new Datebase();
        public Registerform()
        {
            InitializeComponent();

        }
        DataTable dt = new DataTable();
        private void Registerform_Load(object sender, EventArgs e)
        {
            //createcolumns();
            // filldata(dataGridView1);
            SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
            com.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db",com);
            com.Close();
            adapter.Fill(dt);
            adapter.Update(dt);
            
            dataGridView1.DataSource = dt;
            
            
        }
       
       
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
        DataTable d = new DataTable();
        private void button_add_Click(object sender, EventArgs e)
        {



            SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
            com.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"insert into course_db(surname,type_of,date_1,date_2,surname_master,cost) VALUES('{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}','{textBox1.Text}',{textBox2.Text});", com);
            com.Close();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            

          
           

           // DataSet ds1 = new DataSet();

           
          
        }
        SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            
            dt.Clear();
            //string query = $"SELECT TOP(1000) surname,order_num,type_of,date_1,date_2,surname_master,cost FROM course_db";
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
            //con.Open();
            //DataTable dt = new DataTable();
            //SqlCommand c = new SqlCommand(query, con);
            //dt.Clear();
            
            //con.Close();
            
            com.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
            com.Close();
            adapter.Fill(dt);
            adapter.Update(dt);
            
            dataGridView1.DataSource = dt;
            
        }
        

        private void button_del_Click(object sender, EventArgs e)
        {
            Form2 formdel = new Form2();
            formdel.Show();
            formdel.StartPosition = FormStartPosition.CenterParent;


        }

        private void button_sav_Click(object sender, EventArgs e)
        {
            StreamWriter s = new StreamWriter(@"C:\\Users\\boris\\Downloads\\coursera.txt");
           
            DataTable data = new DataTable();
            dataGridView1.DataSource = data;
            
            com.Open();
            string q = $"SELECT cost,type_of,surname  FROM course_db Where cost=(select MAX (cost) from course_db)";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT surname,order_num,type_of,date_1,date_2,surname_master,cost  FROM course_db Where cost=(select MAX (cost) from course_db)", com);
            SqlCommand c = new SqlCommand(q, com);
            
            
            adapter.Fill(data);
            
            //MessageBox.Show($"{c.ExecuteScalar()}");
           
            c.ExecuteNonQuery();
            int str = (int)c.ExecuteScalar();
            s.Write($"Стоимость самого дорогого заказа = "+(int)c.ExecuteScalar());
            s.Close();
            com.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formred f = new Formred();
            f.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter s = new StreamWriter(@"C:\\Users\\boris\\Downloads\\average.txt");
            DataTable d=new DataTable();    
            com.Open();
            string q = $"SELECT AVG (cost) FROM course_db";
            SqlDataAdapter adapter = new SqlDataAdapter("select * FROM course_db", com);
            SqlCommand c = new SqlCommand(q, com);
            var item = c.ExecuteNonQuery();
            s.Write($"Средняя стоимость = " + (int)c.ExecuteScalar());
            s.Close();
            MessageBox.Show($"{c.ExecuteScalar()}");
            com.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            Sortform sf=new Sortform();
            sf.Show();
        }
       

        private void button5_Click_1(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            dataGridView1.DataSource=data;
            //com.Close();
            
            string q = $"SELECT TOP(1000) [surname],[order_num],[type_of],[date_1],[date_2],[surname_master],[cost] FROM[course].[dbo].[course_db]where surname_master = '{textBox11.Text}'";
            SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
            com.Open();
            SqlCommand c = new SqlCommand(q, com);
            SqlDataAdapter adapter = new SqlDataAdapter($" SELECT TOP(1000) [surname],[order_num],[type_of],[date_1],[date_2],[surname_master],[cost] FROM[course].[dbo].[course_db]where surname_master = '{textBox11.Text}'", com);
            adapter.Fill(data);
            
            c.ExecuteNonQuery();
        }
    }
}

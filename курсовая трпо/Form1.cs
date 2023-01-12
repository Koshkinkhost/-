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

namespace курсовая_трпо
{
   
    public partial class Form1 : Form
    {
        Datebase data = new Datebase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
            textBox1.PasswordChar = '⬤';
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginuser = textBox2.Text;
            var passworduser = textBox1.Text;
            SqlDataAdapter  a=new SqlDataAdapter();
            DataTable t=new DataTable();
            string querystring = $"SELECT * FROM register WHERE login_user = '{loginuser}' AND pass_user = '{passworduser}'";
            SqlCommand com = new SqlCommand(querystring, data.getconnection());
            a.SelectCommand = com;
            
            a.Fill(t);
            if(t.Rows.Count==1)
            {
                MessageBox.Show("Вы успешно зашли");
                
                this.Hide();
                Registerform r=new Registerform();
                r.Show();
                
                
                //registerform.ShowDialog();
                //registerform.Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя нет!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;

        }
    }

}

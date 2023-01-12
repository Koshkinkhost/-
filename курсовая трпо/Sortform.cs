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
    public partial class Sortform : Form
    {
        SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-QK0CGSD;Initial Catalog=course;Integrated Security=True");
        public Sortform()
        {
            
            InitializeComponent();
        }
        
        
        
    }
}


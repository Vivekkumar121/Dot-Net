using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace form112
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightGreen;

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            str = "Insert into Doctors Values('"+Dname.Text+"','"+gender.Text+ "','"+spc.Text+"','"+contact.Text+"',)";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.0.0.13; Database = mcadotnet; uid = Student; pwd = mca@123");
            con.Open();
            MessageBox.Show("Done");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str = "Create table Doctors('"DName varchar2(20)"','"Gender varchar(2)"');
        }
    }
}

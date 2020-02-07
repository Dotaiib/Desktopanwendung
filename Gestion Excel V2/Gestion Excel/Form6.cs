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
namespace Gestion_Excel
{
    public partial class Form6 : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = Localhost ; initial catalog = saveexcel ; integrated security = true");
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string req = "select distinct * from Save_Calcule where LaDate = '" + textBox1.Text + "'";
            if (textBox2.Text != "") { req += " and Matricule = '" + textBox2.Text + "'"; }
            if (textBox3.Text != "") { req += " and NbrHeure = " + textBox3.Text; }
            if (textBox4.Text != "") { req += " and HSupp = " + textBox4.Text; }
            if (textBox5.Text != "") { req += " and HNormal = " + textBox5.Text; }
            if (textBox6.Text != "") { req += " and HPrime = " + textBox6.Text; }
            if (textBox7.Text != "") { req += " and NbrJour = " + textBox7.Text; }
             
            SqlCommand cmd = new SqlCommand(req, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11));
            }
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

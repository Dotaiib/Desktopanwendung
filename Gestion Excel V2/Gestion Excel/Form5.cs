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
    public partial class Form5 : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = Localhost ; initial catalog = saveexcel ; integrated security = true");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        //private void Afficher()
        //{

        //    dataGridView1.Rows.Clear();
        //    string req = "select * from Table_save";
        //    SqlCommand cmd = new SqlCommand(req, cn);
        //    cn.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4));
        //    }
        //    cn.Close();


        //}

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string req = "select distinct * from Save_Excel where LaDate = '" + textBox1.Text + "'";
            if (textBox2.Text != "") { req += " and Matricule = '" + textBox2.Text + "'"; }
            if (textBox3.Text != "") { req += " and NbrHeure = " + textBox3.Text; }
            SqlCommand cmd = new SqlCommand(req, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6));
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

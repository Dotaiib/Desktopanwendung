using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Gestion_Excel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Files | *.xlsx; *.xls;";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                { this.textBox1.Text = ofd.FileName; }


                string path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties = \"Excel 12.0; HDR=YES\" ; ";
                OleDbConnection cn = new OleDbConnection(path);
                cn.Open();

                comboBox1.DataSource = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                comboBox1.DisplayMember = "TABLE_NAME";
                comboBox1.ValueMember = "TABLE_NAME";

                cn.Close();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                string path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties = \"Excel 12.0; HDR=YES\" ; ";
                OleDbConnection cn = new OleDbConnection(path);
                OleDbDataAdapter dta = new OleDbDataAdapter("Select * from [" + comboBox1.SelectedValue + "]", cn);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                MessageBox.Show(dt.Rows.Count.ToString(), "Nbr de Lignes");

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.DataSource = dt;
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection sc = new SqlConnection(@"data source = Localhost ; initial catalog = saveexcel ; integrated security = true");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //SqlCommand cmd = new SqlCommand("insert into Save_Excel values('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "')", sc);
                SqlCommand cmd = new SqlCommand("insert into Save_Excel (LaDate,Matricule,Nom,Prenom,NbrHeure,Prime,HeureDlla) values(@LaDate,@Matricule,@Nom,@Prenom,@NbrHeure,@Prime,@HeureDlla) ", sc);
                cmd.Parameters.AddWithValue("@LaDate", textBox2.Text);
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Nom", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Prenom", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@NbrHeure", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@Prime", dataGridView1.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@HeureDlla", dataGridView1.Rows[i].Cells[5].Value);
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
            }

            MessageBox.Show("Sauvegarde à réussi! ", "Saving", MessageBoxButtons.OK);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dt.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            { button3.Enabled = true; }
            else { button3.Enabled = false; }
        }
    }
}

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
    public partial class Form4 : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = Localhost ; initial catalog = saveexcel ; integrated security = true");
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Calc();       
        }

        private void button1_Click(object sender, EventArgs e)
        {

                dataGridView1.Rows.Clear();
                SqlCommand cmd = new SqlCommand(" select distinct * from Save_Excel where LaDate = '" + textBox1.Text + "' and NbrHeure >  0", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6));
                }
                cn.Close();                
                Calc();
                MessageBox.Show(dataGridView1.Rows.Count.ToString(), "Nbr de Lignes");
            
        }

        void Calc()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int Cell1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                int Cell3 = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
                int Cell2 = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                int Cell4 = Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
                double Cell5 = Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value);
                int Cell6 = Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value);
                int C1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                int C2 = Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
                int v1 = 44;
                int v2 = 12;
                double J1 =6;
                double J2 = 5;
                double J3 = 4;
                double J4 = 3;
                double J5 = 2;
                double J6 = 1.5;
                double J7 = 1;


                if (Cell1 <= v1) { Cell2 = Cell1; }
                else { Cell2 = v1; }

                int CellA = Cell1 - Cell2;

                if (CellA <= v2) { Cell3 = CellA; }
                else { Cell3 = v2; }

                Cell4 = Cell1 - (Cell2 + Cell3);

                if (Cell4 < 0) { Cell4 = 0; }
                else { dataGridView1.Rows[i].Cells[9].Value = Cell4; }

                dataGridView1.Rows[i].Cells[4].Value = Cell1;
                dataGridView1.Rows[i].Cells[7].Value = Cell3;
                dataGridView1.Rows[i].Cells[8].Value = Cell2;


                if (Cell1 >= 44) { Cell5 = J1; }
                else if (Cell1 >=39 && Cell1<=43.5){Cell5 = J2;}
                else if (Cell1 >= 30 && Cell1 <= 38.5) { Cell5 = J3; }
                else if (Cell1 >= 20 && Cell1 <= 29.5) { Cell5 = J4; }
                else if (Cell1 >= 13 && Cell1 <= 19.5) { Cell5 = J5; }
                else if (Cell1 >= 11 && Cell1 <= 12.5) { Cell5 = J6; }
                else if (Cell1 >= 5 && Cell1 <= 10.5) { Cell5 = J7; }
                else { Cell5 = 0; }

                dataGridView1.Rows[i].Cells[10].Value = Cell5;


                Cell6 = C1 + C2;
                dataGridView1.Rows[i].Cells[11].Value = Cell6;
            
            }
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            Calc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into Save_Calcule (LaDate,Matricule,Nom,Prenom,NbrHeure,Prime,HeureDlla,HPrime,HSupp,HNormal,NbrJour,TPrime) values(@LaDate,@Matricule,@Nom,@Prenom,@NbrHeure,@Prime,@HeureDlla,@HPrime,@HSupp,@HNormal,@NbrJour,@TPrime) ", cn);
                cmd.Parameters.AddWithValue("@LaDate", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Matricule", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Nom", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Prenom", dataGridView1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@NbrHeure", dataGridView1.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@Prime", dataGridView1.Rows[i].Cells[5].Value);
                cmd.Parameters.AddWithValue("@HeureDlla", dataGridView1.Rows[i].Cells[6].Value);
                cmd.Parameters.AddWithValue("@HSupp", dataGridView1.Rows[i].Cells[7].Value);
                cmd.Parameters.AddWithValue("@HNormal", dataGridView1.Rows[i].Cells[8].Value);
                cmd.Parameters.AddWithValue("@HPrime", dataGridView1.Rows[i].Cells[9].Value);
                cmd.Parameters.AddWithValue("@NbrJour", dataGridView1.Rows[i].Cells[10].Value);
                cmd.Parameters.AddWithValue("@TPrime", dataGridView1.Rows[i].Cells[11].Value);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            MessageBox.Show("Sauvegarde à réussi! ", "Saving", MessageBoxButtons.OK);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "" )
            { button1.Enabled = true; }
            else { button1.Enabled = false; }

            if (textBox1.Text != "")
            { button2.Enabled = true; }
            else { button2.Enabled = false; }
        }
    }
}

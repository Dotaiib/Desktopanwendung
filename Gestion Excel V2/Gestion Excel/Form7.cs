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
    public partial class Form7 : Form
    {
        SqlConnection cn = new SqlConnection(@"data source = Localhost ; initial catalog = saveexcel ; integrated security = true");
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Calc();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        void Calc()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int Cell1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

                if (dataGridView1.Rows[i].Cells[0].Value == null) { Cell1 = 0; }
                else { Cell1 = 255; }


                dataGridView1.Rows[i].Cells[3].Value = Cell1;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select distinct * from Save_Calcule where LaDate = '" + textBox1.Text + "'", cn);
            cn.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            for (int i = 0 ; i<dt.Rows.Count; i ++)
            {
            dataGridView1.Rows.Add(dt.Rows[i][1].ToString() , dt.Rows[i][7].ToString() , "HS01");
            dataGridView1.Rows.Add(dt.Rows[i][1].ToString(), dt.Rows[i][8].ToString(), "CL01");
            dataGridView1.Rows.Add(dt.Rows[i][1].ToString() , dt.Rows[i][10].ToString() , "CL14");
            dataGridView1.Rows.Add(dt.Rows[i][1].ToString() , dt.Rows[i][11].ToString() , "CL02");
            dataGridView1.Rows.Add(dt.Rows[i][1].ToString() , dt.Rows[i][6].ToString() , "CL33");
            }

            cn.Close();
            Calc();
            

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Calc();
        }



        void ExportTOExcel(DataGridView dataGridView1)
            {


                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                //add data 
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }

                //For Diagramme :

                //Microsoft.Office.Interop.Excel.Range chartRange;

                //Microsoft.Office.Interop.Excel.ChartObjects xlCharts = (Microsoft.Office.Interop.Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                //Microsoft.Office.Interop.Excel.ChartObject myChart = (Microsoft.Office.Interop.Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
                //Microsoft.Office.Interop.Excel.Chart chartPage = myChart.Chart;

                //chartRange = xlWorkSheet.get_Range("A1", "B" + dataGridView1.Rows.Count);
                //chartPage.SetSourceData(chartRange, misValue);
                //chartPage.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;

                xlApp.Visible = true;

            }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportTOExcel(dataGridView1);
        }

        }
    }



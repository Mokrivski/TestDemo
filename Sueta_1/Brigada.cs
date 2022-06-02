using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sueta_1
{
    public partial class Brigada : Form
    {
        public Brigada()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void GetList()
        {
            con = new SqlConnection(@"Data Source=AKOP\AKOP;Initial Catalog=So_AKOP;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Brigada", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Brigada");
            dataGridViewBrigada.DataSource = ds.Tables["Brigada"];
            con.Close();
        }

        //Добавление
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbKolSotr.Text == "" || tbSpecial.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("insert into Brigada (Name_Brigadi, Kolichestvo_sotrudnikov, Specializaciya_brigadi, Sotrudnik_ID) values ('{0}','{1}','{2}','{3}')",
                    tbName.Text, tbKolSotr.Text, tbSpecial.Text, cbID.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbKolSotr.Text == "" || tbSpecial.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("update Brigada set Name_Brigadi = '{0}', Kolichestvo_sotrudnikov = '{1}', Specializaciya_brigadi = '{2}'," +
                        " Sotrudnik_ID = '{3}' where Name_Brigadi = '{0}'",
                    tbName.Text, tbKolSotr.Text, tbSpecial.Text, cbID.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Заполни полните поле!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("delete from Brigada where  Name_Brigadi = '{0}'",
                    tbName.Text, tbKolSotr.Text, tbSpecial.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBrigada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Brigada_Load(object sender, EventArgs e)
        {
            this.sotrudnikTableAdapter1.Fill(this.so_AKOPDataSet1.Sotrudnik);
            GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 0; i < dataGridViewBrigada.Rows.Count; i++)
            {
                for(int j = 0; j < dataGridViewBrigada.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridViewBrigada.Rows[i].Cells[j].Value;
                }             
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}


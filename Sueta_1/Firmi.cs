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

namespace Sueta_1
{
    public partial class Firmi : Form
    {
        public Firmi()
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
            da = new SqlDataAdapter("Select *From Medikamenti", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Medikamenti");
            dataGridViewfirma.DataSource = ds.Tables["Medikamenti"];
            con.Close();
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (tbKol.Text == "" || tbNaz.Text == "")
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
                    cmd.CommandText = string.Format("insert into Medikamenti (Kolichestvo,Nazvaniya) values ('{0}','{1}')",
                    tbKol.Text, tbNaz.Text);
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

        private void Firmi_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbKol.Text == "")
            {
                MessageBox.Show("Заполни поле!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("delete from Firmi where  Nazvanie = '{0}'",
                    tbKol.Text);
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

        private void dataGridViewfirma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

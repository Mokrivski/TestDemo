using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sueta_1
{
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void Klient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "so_AKOPDataSet2.Firmi". При необходимости она может быть перемещена или удалена.
            this.firmiTableAdapter1.Fill(this.so_AKOPDataSet2.Firmi);
            GetList();

        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void GetList()
        {
            con = new SqlConnection(@"Data Source=AKOP\AKOP;Initial Catalog=So_AKOP;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Zakazchik", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Zakazchik");
            dataGridViewKlient.DataSource = ds.Tables["Zakazchik"];
            con.Close();
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (tbKlinika.Text == "" || tbVedom.Text == "" || tbFizLic.Text == "")
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
                    cmd.CommandText = string.Format("insert into Zakazchik (Chastnie_kliniki, Vedomstva, Phisicheskie_lica, Firmi_ID) values ('{0}', '{1}', '{2}', '{3}')",
                    tbKlinika.Text, tbVedom.Text, tbFizLic.Text, cbID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    

            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbKlinika.Text == "" || tbVedom.Text == "" || tbFizLic.Text == "")
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
                    cmd.CommandText = string.Format("update Zakazchik set Chastnie_kliniki = '{0}', Vedomstva = '{1}', Phisicheskie_lica = '{2}', Firmi_ID = '{3}' where Chastnie_kliniki = '{0}'",
                    tbKlinika.Text, tbVedom.Text, tbFizLic.Text, cbID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                  
               
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbKlinika.Text == "")
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
                    cmd.CommandText = string.Format("delete from Firmi where  Chastnie_kliniki = '{0}'",
                    tbKlinika.Text);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbFizLic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Sotrudnik : Form
    {
        public Sotrudnik()
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
            GetList();

        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void GetList()
        {
            con = new SqlConnection(@"Data Source=AKOP\AKOP;Initial Catalog=So_AKOP;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Sotrudnik", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sotrudnik");
            dataGridViewSotrudnik.DataSource = ds.Tables["Sotrudnik"];
            con.Close();
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbFamiliya.Text == "" || tbOthestvo.Text == "" || tbTelephone.Text == "" || tbEmail.Text == "" || tbPasport.Text == "" || textBox1.Text == "")
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
                    cmd.CommandText = string.Format("insert into Sotrudnik (Imya, Familiya, Otchestvo, Nomer_telefona, Email, Seriya_nomer_pasporta, Post_Id) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    tbName.Text, tbFamiliya.Text, tbOthestvo.Text, tbTelephone.Text, tbEmail.Text, tbPasport.Text, cbID.Text);
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

        private void Sotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "so_AKOPDataSet2.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter1.Fill(this.so_AKOPDataSet2.Post);
            GetList();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbFamiliya.Text == "" || tbOthestvo.Text == "" || tbTelephone.Text == "" || tbEmail.Text == "" || tbPasport.Text == "" || textBox1.Text == "")
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
                    cmd.CommandText = string.Format("update Sotrudnik set Imya = '{0}', Familiya= '{1}', Otchestvo = '{2}', Nomer_telefona = '{3}', Email = '{4}', Seriya_nomer_pasporta = '{5}', Post_Id = '{6}' where Imya = '{0}'",
                    tbName.Text, tbFamiliya.Text, tbOthestvo.Text, tbTelephone.Text, tbEmail.Text, tbPasport.Text, cbID.Text, textBox1.Text);
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
                MessageBox.Show("Заполни поле!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("delete from Objekt Sotrudnik  Imya = '{0}",
                    tbName.Text);
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
    }
}

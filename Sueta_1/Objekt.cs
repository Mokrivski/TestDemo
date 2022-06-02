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
    public partial class Objekt : Form
    {
        public Objekt()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
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
            da = new SqlDataAdapter("Select *From Objekt", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Objekt");
            dataGridViewObjekt.DataSource = ds.Tables["Objekt"];
            con.Close();
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (tbRazmer.Text == "" || tbTime.Text == "" || tbStoimost.Text == "" || tbKolVo.Text == "")
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
                    cmd.CommandText = string.Format("insert into Objekt (Razmer_objekt, Vremya_vipolneniya, Stoimost, Kolichestvo_brigad, Brigada_ID, Zakazchik_ID) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    tbRazmer.Text, tbTime.Text, tbStoimost.Text, tbKolVo.Text, cbBrig.Text, cbZak.Text);
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

        private void Objekt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "so_AKOPDataSet2.Brigada". При необходимости она может быть перемещена или удалена.
            this.brigadaTableAdapter1.Fill(this.so_AKOPDataSet2.Brigada);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "so_AKOPDataSet2.Zakazchik". При необходимости она может быть перемещена или удалена.
            this.zakazchikTableAdapter1.Fill(this.so_AKOPDataSet2.Zakazchik);
            GetList();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbRazmer.Text == "" || tbTime.Text == "" || tbStoimost.Text == "" || tbKolVo.Text == "")
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
                    cmd.CommandText = string.Format("update Objekt set Razmer_objekt = '{0}', Vremya_vipolneniya = '{1}', Stoimost = '{2}', Kolichestvo_brigad = '{3}', Brigada_ID = '{4}', Zakazchik_ID = '{5}' where Razmer_objekt = '{0}'",
                    tbRazmer.Text, tbTime.Text, tbStoimost.Text, tbKolVo.Text, cbBrig.Text, cbZak.Text);
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
            if (tbRazmer.Text == "")
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
                    cmd.CommandText = string.Format("delete from Objekt where  Razmer_objekt = '{0}'",
                    tbRazmer.Text);
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

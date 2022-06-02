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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        int i;
        DataTable dt;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=AKOP\AKOP;Initial Catalog=So_AKOP;Integrated Security=True");
            da = new SqlDataAdapter("Select *From [dbo].[Sotrudnik]", con);

            ds = new DataSet();

            con.Open();
            da.Fill(ds, "[dbo].[Sotrudnik]");

            con.Close();


        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand thisCommand = con.CreateCommand();
            thisCommand.CommandText = @"select Post_Id from [dbo].[Sotrudnik] Where Email = '" + tbLogin.Text + "' and Password = '" + tbPassword.Text + "'";
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            if (tbLogin.Text == String.Empty || tbPassword.Text == String.Empty)
            {
                MessageBox.Show("Пустые поля!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            while (thisReader.Read())
            {

                label3.Text += thisReader["Post_Id"].ToString();
            }
            thisReader.Close();

            if (label3.Text == "1")
            {
                i = 0;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("select * from [dbo].[Sotrudnik] where Email = '{0}' and Password = '{1}'", tbLogin.Text, tbPassword.Text);
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                MainForm a = new MainForm();
                a.Show();
                Hide();
                a.справочникиToolStripMenuItem.Enabled = true;
                a.справочникиToolStripMenuItem.Visible = true;
                a.функцииToolStripMenuItem.Enabled = false;
                a.функцииToolStripMenuItem.Visible = false;
            }
            else
            {
                if (label3.Text == "2")
                {
                    i = 0;
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = String.Format("select * from [dbo].[Sotrudnik] where Email = '{0}' and Password = '{1}'", tbLogin.Text, tbPassword.Text);
                    dt = new DataTable();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                    MainForm a = new MainForm();
                    a.Show();
                    Hide();
                    a.справочникиToolStripMenuItem.Enabled = false;
                    a.справочникиToolStripMenuItem.Visible = false;
                    a.функцииToolStripMenuItem.Enabled = true;
                    a.функцииToolStripMenuItem.Visible = true;
                }
               
                
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

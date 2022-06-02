using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueta_1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btZakazchik_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klient klient = new Klient();
            klient.Show();
        }

        private void btSotrudnik_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sotrudnik sotrudnik = new Sotrudnik();
            sotrudnik.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

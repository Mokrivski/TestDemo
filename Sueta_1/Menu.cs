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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void btObjekt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Objekt objekt = new Objekt();
            objekt.Show();
        }

        private void btFirma_Click(object sender, EventArgs e)
        {
            this.Hide();
            Firmi firmi = new Firmi();
            firmi.Show();
        }

        private void btBrigada_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brigada brigada = new Brigada();
            brigada.Show();
        }

        private void btSklad_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

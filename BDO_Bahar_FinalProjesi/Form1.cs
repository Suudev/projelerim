using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_Bahar_FinalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btniskelet_Click(object sender, EventArgs e)
        {
            iskeletSistemi iskeletSistemi = new iskeletSistemi();
            iskeletSistemi.Show();
            this.Hide();
        }

        private void btnkas_Click(object sender, EventArgs e)
        {
            kasSistemi kasSistemi = new kasSistemi();
            kasSistemi.Show();
            this.Hide();
        }

        private void btnicorganlar_Click(object sender, EventArgs e)
        {
            icOrganlar icOrganlar = new icOrganlar();
            icOrganlar.Show();
            this.Hide();
        }

        private void btnduyuorganlari_Click(object sender, EventArgs e)
        {
            duyuOrganlari duyuOrganlari = new duyuOrganlari();
            duyuOrganlari.Show();
            this.Hide();
        }
    }
}

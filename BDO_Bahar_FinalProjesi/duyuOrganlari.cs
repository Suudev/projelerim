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
    public partial class duyuOrganlari : Form
    {
        public duyuOrganlari()
        {
            InitializeComponent();
        }

        private void btnGoz_Click(object sender, EventArgs e)
        {
            FormGoz formGoz = new FormGoz();
            formGoz.Show();
            this.Hide();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnKulak_Click(object sender, EventArgs e)
        {
            FormKulak formKulak = new FormKulak();
            formKulak.Show();
            this.Hide();
        }

        private void btnBurun_Click(object sender, EventArgs e)
        {
            FormBurun formBurun = new FormBurun();
            formBurun.Show();
            this.Hide();
        }

        private void btnAgiz_Click(object sender, EventArgs e)
        {
            FormAgiz formAgiz = new FormAgiz();
            formAgiz.Show();
            this.Hide();
        }

        private void btnDokunma_Click(object sender, EventArgs e)
        {
            FormDeri formDeri = new FormDeri();
            formDeri.Show();
            this.Hide();
        }
    }
}

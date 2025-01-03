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
    public partial class kasSistemi : Form
    {
        public kasSistemi()
        {
            InitializeComponent();
        }

        private void kasSistemi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnKafa_Click(object sender, EventArgs e)
        {
            FormKafa_kas formKafa_Kas = new FormKafa_kas();
            formKafa_Kas.Show();
            this.Close();
        }

        private void btnKol_Click(object sender, EventArgs e)
        {
            FormKol_kas formKol_kas = new FormKol_kas();
            formKol_kas.Show();
            this.Close();
        }

        private void btnGovde_Click(object sender, EventArgs e)
        {
            FormGovde_kas formGovde_Kas = new FormGovde_kas();
            formGovde_Kas.Show();
            this.Close();
        }

        private void btnBacak_Click(object sender, EventArgs e)
        {
            FormBacak_kas formBacak_kas = new FormBacak_kas();
            formBacak_kas.Show();
            this.Close();
        }
    }
}

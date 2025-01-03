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
    public partial class iskeletSistemi : Form
    {
        public iskeletSistemi()
        {
            InitializeComponent();
            
        }

        private void btnKafa_Click(object sender, EventArgs e)
        {
            FormKafa formKafa = new FormKafa();
            formKafa.Show();
            this.Close();
        }
       
      

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void iskeletSistemi_Load(object sender, EventArgs e)
        {

        }

        private void btnKol_Click_1(object sender, EventArgs e)
        {

            FormKol formKol = new FormKol();
            formKol.Show();
            this.Close();
        }

        private void btnGovde_Click_1(object sender, EventArgs e)
        {
            FormGovde formGovde = new FormGovde();
            formGovde.Show();
            this.Close();
        }

        private void btnBacak_Click_1(object sender, EventArgs e)
        {
            FormBacak formBacak = new FormBacak();
            formBacak.Show();
            this.Close();
        }
    }
}

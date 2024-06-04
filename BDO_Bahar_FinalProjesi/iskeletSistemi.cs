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
            this.btnKafa.Click += new EventHandler(this.btnKafa_Click);
            this.btnKol.Click += new EventHandler(this.btnKol_Click);
            this.btnBacak.Click += new EventHandler(this.btnBacak_Click);
            this.btnGovde.Click += new EventHandler(this.btnovde_Click);
        }

        private void btnKafa_Click(object sender, EventArgs e)
        {
            FormKafa formKafa = new FormKafa();
            formKafa.ShowDialog();
        }
        private void btnKol_Click(object sender, EventArgs e)
        {
            FormKol formKol = new FormKol();
            formKol.ShowDialog();
        }
        private void btnBacak_Click(object sender, EventArgs e)
        {
            FormBacak formBacak = new FormBacak();
            formBacak.ShowDialog();
        }
        private void btnGovde(object sender, EventArgs e)
        {
            FormGovde formGovde = new FormGovde();
            formGovde.ShowDialog();
        }
    }
}

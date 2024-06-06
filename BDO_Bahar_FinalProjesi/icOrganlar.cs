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
    public partial class icOrganlar : Form
    {
        public icOrganlar()
        {
            InitializeComponent();
            this.btnBeyin.Click += new EventHandler(this.btnBeyin_Click);
            this.btnAkciger.Click += new EventHandler(this.btnAkciger_Click);
            this.btnKalp.Click += new EventHandler(this.btnKalp_Click);
            this.btnKaraciger.Click += new EventHandler(this.btnKaraciger_Click);
            this.btnDalak.Click += new EventHandler(this.btnDalak_Click);
            this.btnMide.Click += new EventHandler(this.btnMide_Click);
            this.btnInce.Click += new EventHandler(this.btnInce_Click);
            this.btnKalın.Click += new EventHandler(this.btnKalın_Click);
        }
        private void btnBeyin_Click(object sender, EventArgs e)
        {
            FormBeyin formBeyin = new FormBeyin();
            formBeyin.ShowDialog();


        }
        private void btnAkciger_Click(object sender,EventArgs e)
        {
            FormAkciger formAkciger = new FormAkciger();
            formAkciger.ShowDialog();
        }
        private void btnKalp_Click(object sender, EventArgs e)
        {
            FormKalp formKalp = new FormKalp();
            formKalp.ShowDialog();
        }
        private void btnKaraciger_Click(object sender, EventArgs e)
        {
            FormKaraciger formKaraciger = new FormKaraciger();
            formKaraciger.ShowDialog();
        }
        private void btnDalak_Click(object sender, EventArgs e)
        {
            FormDalak formDalak = new FormDalak();
            formDalak.ShowDialog();
        }
        private void btnMide_Click(object sender, EventArgs e)
        {
            FormMide formMide = new FormMide();
            formMide.ShowDialog();
        }
        private void btnInce_Click(object sender, EventArgs e)
        {
            FormInce formInce = new FormInce();
            formInce.ShowDialog();
        }
        private void btnKalın_Click(object sender, EventArgs e)
        {
            FormKalın formKalın = new FormKalın();
            formKalın.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void icOrganlar_Load(object sender, EventArgs e)
        {

        }
    }
}

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
            
            this.btnMide.Click += new EventHandler(this.btnMide_Click);
            this.btnInce.Click += new EventHandler(this.btnInce_Click);
            this.btnKalın.Click += new EventHandler(this.btnKalın_Click);
        }
        private void btnBeyin_Click(object sender, EventArgs e)
        {
            FormBeyin formBeyin = new FormBeyin();
            formBeyin.Show();
            this.Hide();

        }
        private void btnAkciger_Click(object sender,EventArgs e)
        {
            FormAkciger formAkciger = new FormAkciger();
            formAkciger.Show();
            this.Hide();
        }
        private void btnKalp_Click(object sender, EventArgs e)
        {
            FormKalp formKalp = new FormKalp();
            formKalp.Show();
            this.Hide();
        }
        private void btnKaraciger_Click(object sender, EventArgs e)
        {
            FormKaraciger formKaraciger = new FormKaraciger();
            formKaraciger.Show();
            this.Hide();
        }
        
        private void btnMide_Click(object sender, EventArgs e)
        {
            FormMide formMide = new FormMide();
            formMide.Show(); 
            this.Hide();
        }
        private void btnInce_Click(object sender, EventArgs e)
        {
            FormInce formInce = new FormInce();
            formInce.Show();
            this.Hide();
        }
        private void btnKalın_Click(object sender, EventArgs e)
        {
            FormKalın formKalın = new FormKalın();
            formKalın.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void icOrganlar_Load(object sender, EventArgs e)
        {

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnBobrek_Click(object sender, EventArgs e)
        {
            FormBobrek formBobrek = new FormBobrek();
            formBobrek.Show();
            this.Hide();
        }

        private void btnBeyin_Click_1(object sender, EventArgs e)
        {
        }

        private void btnAkciger_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKalp_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnKaraciger_Click_1(object sender, EventArgs e)
        {
        }

        private void btnMide_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnInce_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnKalın_Click_1(object sender, EventArgs e)
        {
        }
    }
}

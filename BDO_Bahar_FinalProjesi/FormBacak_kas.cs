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
    public partial class FormBacak_kas : Form
    {
        public FormBacak_kas()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormBacak_kas_Load);
        }

        private void FormBacak_kas_Load(object sender, EventArgs e)
        {
            label1.Click += Label_Click;
            label2.Click += Label_Click;
            label3.Click += Label_Click;
            label4.Click += Label_Click;
            label5.Click += Label_Click;
            label6.Click += Label_Click;
            label7.Click += Label_Click;
            label8.Click += Label_Click;
            label9.Click += Label_Click;
            label10.Click += Label_Click;
            label11.Click += Label_Click;
            label12.Click += Label_Click;
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                string legmPart = selectedLabel.Text;
                ShowLegPartDetails(legmPart);
            }

        }
        private void ShowLegPartDetails(string legmPart)
        {
            string details = " ";
            if(legmPart == "Anterior Iliac Spine")
            {
                details = "Yerleşim: Kalçanın ön kısmında, pelvik kemiğin üst çıkıntısında bulunur.\r\nFonksiyon: Kasların ve bağ dokularının tutunma noktasıdır, bacak hareketlerine destek sağlar.\r\nYapı: Kemik çıkıntı.\r\n";
            }
           else if(legmPart == "Tensor Fasciae Latae")
            {
                details = "Yerleşim: Kalçanın üst yan kısmında, iliac spine ile büyük trokanter arasında uzanır.\r\nFonksiyon: Uyluğun abduksiyonunu (dışa doğru açılmasını) ve iç rotasyonunu sağlar, pelvisi dengeler.\r\nYapı: Kas dokusu.";
            }
            else if (legmPart == "Rectus Femoris")
            {
                details = "Yerleşim: Uyluğun ön kısmında bulunur, quadriceps kas grubunun bir parçasıdır.\r\nFonksiyon: Diz ekstensiyonu ve kalça fleksiyonunu sağlar.\r\nYapı: Kas dokusu.";
            }
            else if (legmPart == "Vastus Lateralis")
            {
                details = "Yerleşim: Uyluğun dış kısmında bulunur, quadriceps kas grubunun bir parçasıdır.\r\nFonksiyon: Diz ekstensiyonunu sağlar.\r\nYapı: Kas dokusu.";
            }
            else if (legmPart == "Peroneus Longus")
            {
                details = "Yerleşim: Alt bacağın dış kısmında bulunur.\r\nFonksiyon: Ayağın eversiyonunu (dışa doğru dönmesini) ve plantar fleksiyonunu sağlar.\r\nYapı: Kas dokusu.";
            }
            else if (legmPart == "Tibialis Anterior")
            {
                details = "Yerleşim: Alt bacağın ön kısmında bulunur.\r\nFonksiyon: Ayağın dorsifleksiyonunu (yukarı doğru bükülmesini) sağlar.\r\nYapı: Kas dokusu.";
            }
            else if (legmPart == "Peroneus Brevis")
            {
                details = "Yerleşim: Alt bacağın dış kısmında, peroneus longus'un altında bulunur.\r\nFonksiyon: Ayağın eversiyonunu sağlar.\r\nYapı: Kas dokusu.";
            }
            else if (legmPart == "Sartorius")
            {
                details = "Yerleşim: Kalçadan iç dize kadar uzanan, vücuttaki en uzun kastır.\r\nFonksiyon: Uyluğun ve dizin fleksiyonunu, abduksiyonunu ve dış rotasyonunu sağlar.\r\nYapı: Uzun ve ince kas dokusu.";
            }
            else if (legmPart == "Adductor Longus")
            {
                details = "Yerleşim: Uyluğun iç kısmında bulunur.\r\nFonksiyon: Uyluğun adduksiyonunu (içe doğru çekilmesini) sağlar.\r\nYapı: Kas dokusu.";
            }
            else if (legmPart == "Patella")
            {
                details = "Yerleşim: Diz kapağı.\r\nFonksiyon: Diz ekstensiyonunda quadriceps kasına yardımcı olur, diz eklemini korur.\r\nYapı: Kıkırdak ve kemik dokusu.";
            }
            else if (legmPart == "Gastrocnemius")
            {
                details = "Yerleşim: Alt bacağın arka üst kısmında bulunur, baldırın büyük kasıdır.\r\nFonksiyon: Ayağın plantar fleksiyonunu ve diz fleksiyonunu sağlar.\r\nYapı: Kas dokusu.";
            }
            else if (legmPart == "Soleus")
            {
                details = "Yerleşim: Alt bacağın arka kısmında, gastrocnemius kasının altında bulunur.\r\nFonksiyon: Ayağın plantar fleksiyonunu sağlar.\r\nYapı: Kas dokusu.";
            }
            else
            {
                details = "Belirtilen burun bölümü hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Bacak Kas Bölümleri Detayları");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

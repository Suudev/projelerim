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
    public partial class FormKulak : Form
    {
        public FormKulak()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormKulak_Load);
        }
        private void FormKulak_Load(object sender, EventArgs e)
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

        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                string earPart = selectedLabel.Text;
                ShowEarPartDetails(earPart);
            }

        }
        private void ShowEarPartDetails(string earPart)
        {
            string details = " ";

            if(earPart == "Pinna")
            {
                details = "Yerleşim: Dış kulakta bulunur ve kulak kepçesi olarak bilinir. Başın yan tarafında, gözün hemen üstünde yer alır.\nFonksiyon: Ses dalgalarını toplar ve kulak kanalına yönlendirir. Aynı zamanda sesin yönünü belirlemeye yardımcı olur.\nYapı: Kıkırdaktan yapılmıştır ve deri ile kaplıdır. Kıvrımlı yapısı ses dalgalarını toplayıp yönlendirmek için idealdir. ";
            }
            else if (earPart =="Concha")
            {
                details = "Yerleşim: Pinna'nın iç kısmında bulunur ve dış kulak ile kulak kanalının girişinde yer alır.\nFonksiyon: Ses dalgalarının kulak kanalına girmesine yardımcı olur.\nYapı: Kıkırdaktan yapılmış ve deri ile kaplıdır. Ses dalgalarını kulak kanalına doğru yönlendiren kıvrımlı bir yapıya sahiptir.";
            }
            else if (earPart == "Çekiç")
            {
                details = "Yerleşim: Kulak zarına bağlı olan ve orta kulakta bulunan bir kemiktir.\nFonksiyon: Kulak zarından gelen titreşimleri örse iletir.\nYapı: Küçük bir kemik olup, bir ucu kulak zarına diğer ucu örse bağlıdır.";
            }
            else if (earPart == "Örs")
            {
                details = "Yerleşim: Orta kulakta bulunur, çekiç ile üzengi arasında yer alır.\nFonksiyon: Çekiçten gelen titreşimleri üzengiye iletir.\nYapı: Küçük, çekiç ve üzengi arasında yer alan bir kemiktir";
            }
            else if (earPart == "Üzengi")
            {
                details = "Yerleşim: Orta kulakta bulunur ve örsten sonra yer alır. İç kulaktaki oval pencereye bağlıdır.\nFonksiyon: Örsten gelen titreşimleri iç kulaktaki oval pencereye ileterek kokleaya iletir.\nYapı: Vücutta bulunan en küçük kemiktir ve halka şeklinde bir yapıya sahiptir.";
            }
            else if (earPart == "İşitme Siniri")
            {
                details = "Yerleşim: İç kulakta bulunur ve kokleadan beyne doğru uzanır.\nFonksiyon: Ses titreşimlerinden oluşan elektrik sinyallerini beyne iletir.\nYapı: Sinir liflerinden oluşur ve koklea ile beyin arasındaki bağlantıyı sağlar.";
            }
            else if (earPart == "Kohlea")
            {
                details = "Yerleşim: İç kulakta bulunur ve salyangoz şeklinde bir yapıdır.\nFonksiyon: Ses titreşimlerini elektrik sinyallerine dönüştürür ve işitme sinirine iletir.\nYapı: Sıvı dolu tüplerden oluşur ve içindeki tüylü hücreler titreşimleri algılar.";
            }
            else if (earPart == "Östaki Borusu")
            {
                details = "Yerleşim: Orta kulaktan nazofarenkse (geniz boşluğu) kadar uzanır.\nFonksiyon: Orta kulaktaki basıncı dengeleyerek kulak zarının düzgün çalışmasını sağlar.\nYapı: Kas ve mukozal doku ile kaplı bir kanaldır, normalde kapalıdır ancak yutkunma veya esneme sırasında açılır.";
            }
            else if (earPart == "Tympanic Membrane")
            {
                details = "Kulak Zarı olarak da bilinir.\nYerleşim: Dış kulak ile orta kulağı ayıran ince bir zardır.\nFonksiyon: Ses dalgalarını titreşimlere dönüştürür ve bu titreşimleri orta kulağa iletir.\nYapı: İnce, esnek bir zardır. Kolajen lifleri ve epitelyal hücrelerden oluşur.";
            }
            else if (earPart == "Kulak Kanalı")
            {
                details = "Yerleşim: Pinna'dan kulak zarına kadar uzanan tüptür.\nFonksiyon: Ses dalgalarını dış kulaktan orta kulağa taşır. Ayrıca kulak kiri (serumen) üretir, bu da kulak kanalını temizler ve korur.\nYapı: Yaklaşık 2.5 cm uzunluğunda, deri ile kaplı bir tüptür. Dış kısmı kıkırdaktan, iç kısmı kemikten oluşur.";
            }
            else
            {
                details = "Belirtilen kulak bölümü hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Kulak Bölümleri Detayları");

        }

        
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

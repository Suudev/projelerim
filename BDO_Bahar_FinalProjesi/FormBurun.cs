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
    public partial class FormBurun : Form
    {
        public FormBurun()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormBurun_Load);
        }

        private void FormBurun_Load(object sender, EventArgs e)
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
            label13.Click += Label_Click;
            label14.Click += Label_Click;
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                string nosePart = selectedLabel.Text;
                ShowNosePartDetails(nosePart);
            }

        }

        private void ShowNosePartDetails(string nosePart)
        {
            string details = " ";
            
            if(nosePart == "Frontal Sinus")
            {
                details = "Yerleşim: Alın kemiğinin içinde, gözlerin üstünde yer alır.\r\nFonksiyon: Mukus üretir ve burun boşluğuna boşaltır; kafatasının ağırlığını hafifletir ve sesin rezonansını artırır.\r\nYapı: Hava dolu boşluklardan oluşur ve mukus salgılayan epitelyumla kaplıdır. ";
            }
            else if(nosePart == "Üst Nazal Konka")
            {
                details = "Yerleşim: Burun boşluğunun üst kısmında yer alır.\r\nFonksiyon: Solunan havayı nemlendirir, ısıtır ve filtreler.\r\nYapı: Kemikten oluşur ve mukozal doku ile kaplıdır. ";
            }
            else if (nosePart == "Orta Nazal Konka")
            {
                details = "Yerleşim: Burun boşluğunun orta kısmında yer alır.\r\nFonksiyon: Havanın dolaşımını düzenler ve sinüs drenajını sağlar.\r\nYapı: Kemikten oluşur ve mukozal doku ile kaplıdır.";
            }
            else if (nosePart == "Alt Nazal Konka")
            {
                details = "Yerleşim: Burun boşluğunun alt kısmında yer alır.\r\nFonksiyon: Solunan havayı nemlendirir, ısıtır ve filtreler.\r\nYapı: Kemikten oluşur ve mukozal doku ile kaplıdır. ";
            }
            else if (nosePart == "Vestibule")
            {
                details = "Yerleşim: Burun deliklerinin hemen arkasında yer alır.\r\nFonksiyon: Solunan havanın ilk filtresi olarak işlev görür, büyük partikülleri tutar.\r\nYapı: Kıkırdakla desteklenmiş, deri ve mukozal doku ile kaplı bir alandır. ";
            }
            else if (nosePart == "Dil")
            {
                details = "Yerleşim: Ağız boşluğunda bulunur.\r\nFonksiyon: Tat almayı sağlar, yiyeceklerin çiğnenmesi ve yutulmasına yardımcı olur, konuşmada rol oynar.\r\nYapı: Kas dokusundan oluşur ve tat tomurcukları içerir. ";
            }
            else if (nosePart == "Hard Palate")
            {
                details = "Hard Palate (Sert Damak)\r\n\r\nYerleşim: Ağız boşluğunun üst kısmında, ön bölümde yer alır.\r\nFonksiyon: Ağız ve burun boşluklarını ayırır, yiyeceklerin ağız içinde hareketini yönlendirir.\r\nYapı: Kemikten oluşur ve mukozal doku ile kaplıdır. ";
            }
            else if (nosePart == "Oral Cavity")
            {
                details = "Oral Cavity (Ağız Boşluğu)\r\n\r\nYerleşim: Ağız içinde, dil ve dişlerle çevrilidir.\r\nFonksiyon: Besinlerin alımı, çiğnenmesi, tat alma ve konuşma gibi işlevleri yerine getirir.\r\nYapı: Kas, diş, dil ve mukozal dokulardan oluşur. ";
            }
            else if (nosePart == "Soft Palate")
            {
                details = "Soft Palate (Yumuşak Damak)\r\n\r\nYerleşim: Sert damak ile farenks arasında, ağız boşluğunun arka üst kısmında yer alır.\r\nFonksiyon: Yutkunma sırasında burun boşluğunu kapatarak yiyecek ve sıvıların burun boşluğuna kaçmasını önler.\r\nYapı: Kas ve bağ dokusundan oluşur, uvula (küçük dil) içerir. ";
            }
            else if (nosePart == "Östaki Borusu Girişi")
            {
                details = "Yerleşim: Burun boşluğu ile orta kulak arasında yer alır.\r\nFonksiyon: Orta kulaktaki basıncı dengeleyerek kulak zarının düzgün çalışmasını sağlar.\r\nYapı: Kas ve mukozal doku ile kaplı bir kanaldır, normalde kapalıdır ancak yutkunma veya esneme sırasında açılır. ";
            }
            else if (nosePart == "Pharyngeal Tonsil")
            {
                details = "Pharyngeal Tonsil (Adenoid)\r\n\r\nYerleşim: Burun boşluğunun arka üst kısmında, farenkste yer alır.\r\nFonksiyon: Bağışıklık sistemi için önemli olan lenfatik dokudur, enfeksiyonlara karşı koruma sağlar.\r\nYapı: Lenfatik dokudan oluşur ve mukozal doku ile kaplıdır. ";
            }
            else if (nosePart == "Sphenoid Sinus")
            {
                details = "Yerleşim: Sfenoid kemiğinin içinde, kafatasının tabanında bulunur.\r\nFonksiyon: Mukus üretir ve burun boşluğuna boşaltır; kafatasının ağırlığını hafifletir ve sesin rezonansını artırır.\r\nYapı: Hava dolu boşluklardan oluşur ve mukus salgılayan epitelyumla kaplıdır. ";
            }
            else if (nosePart == "Koku Sinirleri")
            {
                details = "Yerleşim: Burun boşluğunun üst kısmında, koku epitelyumu içinde bulunur.\r\nFonksiyon: Koku moleküllerini algılar ve koku bilgilerini beyne iletir.\r\nYapı: Sinir liflerinden oluşur ve olfaktör bulbusa bağlanır.";
            }
            else if (nosePart == "Koku Soğanı")
            {
                details = "Yerleşim: Beynin alt kısmında, frontal lobun hemen altında yer alır.\r\nFonksiyon: Koku sinirlerinden gelen bilgileri alır ve işleyerek beyne iletir.\r\nYapı: Sinir hücrelerinden oluşur ve koku sinir lifleri ile bağlantılıdır. ";
            }
            else
            {
                details = "Belirtilen burun bölümü hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Burun Bölümleri Detayları");
        }

        private void label1_Click(object sender, EventArgs e)
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

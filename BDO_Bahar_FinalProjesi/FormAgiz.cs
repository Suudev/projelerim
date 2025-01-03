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
    public partial class FormAgiz : Form
    {
        public FormAgiz()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormAgiz_Load);
        }

        private void FormAgiz_Load(object sender, EventArgs e)
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
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                string mouthPart = selectedLabel.Text;
                ShowMouthPartDetails(mouthPart);
            }

        }

        private void ShowMouthPartDetails(string mouthPart)
        {
            string details = " ";

            if(mouthPart == "Diş Eti")
            {
                details = "Yerleşim: Dişleri çevreleyen ve çene kemiğini kaplayan yumuşak doku.\r\nFonksiyon: Dişleri destekler ve korur.\r\nYapı: Yoğun bağ dokusu ve epitelyumdan oluşur.";
            }
            else if(mouthPart == "Sert Damak")
            {
                details = "Yerleşim: Ağız boşluğunun üst kısmında, ön bölümde yer alır.\r\nFonksiyon: Ağız ve burun boşluklarını ayırır, yiyeceklerin ağız içinde hareketini yönlendirir.\r\nYapı: Kemikten oluşur ve mukozal doku ile kaplıdır.";
            }
            else if (mouthPart == "Yumuşak Damak")
            {
                details = "Yerleşim: Sert damak ile farenks arasında, ağız boşluğunun arka üst kısmında yer alır.\r\nFonksiyon: Yutkunma sırasında burun boşluğunu kapatarak yiyecek ve sıvıların burun boşluğuna kaçmasını önler.\r\nYapı: Kas ve bağ dokusundan oluşur, uvula (küçük dil) içerir.";
            }
            else if (mouthPart == "Uvula(Küçük Dil)")
            {
                details = "Yerleşim: Yumuşak damağın arka kısmında, merkezi olarak asılıdır.\r\nFonksiyon: Yutkunma sırasında burun boşluğunu kapatarak yiyecek ve sıvıların burun boşluğuna kaçmasını önler; ayrıca konuşma ve ses oluşturma süreçlerinde rol oynar.\r\nYapı: Kas ve mukoza dokusundan oluşur.";
            }
            else if (mouthPart == "Bademcikler")
            {
                details = "Yerleşim: Boğazın yan duvarlarında, dil kökünün arkasında yer alır.\r\nFonksiyon: Bağışıklık sisteminin bir parçası olarak enfeksiyonlara karşı koruma sağlar.\r\nYapı: Lenfatik dokudan oluşur ve mukozal doku ile kaplıdır.";
            }
            else if (mouthPart == "Dil")
            {
                details = "Yerleşim: Ağız boşluğunda bulunur.\r\nFonksiyon: Tat almayı sağlar, yiyeceklerin çiğnenmesi ve yutulmasına yardımcı olur, konuşmada rol oynar.\r\nYapı: Kas dokusundan oluşur ve tat tomurcukları içerir.";
            }
            else if (mouthPart == "Küçük Azı Dişler")
            {
                details = "Yerleşim: Köpek dişlerinin hemen arkasında, üst ve alt çenede yer alır.\r\nFonksiyon: Yiyecekleri ezmek ve parçalamak için kullanılır.\r\nYapı: Daha küçük ve dar yüzeyli dişlerdir, azı dişlerinden küçüktür.";
            }
            else if (mouthPart == "Azı Dişler")
            {
                details = "Yerleşim: Ağız boşluğunun arka kısmında, üst ve alt çenede yer alır.\r\nFonksiyon: Yiyecekleri öğütmek ve ezmek için kullanılır.\r\nYapı: Geniş ve düz yüzeyli dişlerdir.";
            }
            else if (mouthPart == "Oropharynx")
            {
                details = "Yerleşim: Ağız boşluğunun arka kısmında, farenkste yer alır.\r\nFonksiyon: Yutma sırasında yiyecek ve sıvıların yemek borusuna geçişini sağlar; solunum yolunun bir parçasıdır.\r\nYapı: Kas ve mukozal dokudan oluşur";
            }
            else if (mouthPart == "Köpek Dişleri")
            {
                details = "Yerleşim: Lateral kesicilerin hemen yanında, üst ve alt çenede yer alır.\r\nFonksiyon: Yiyecekleri parçalamak ve tutmak için kullanılır.\r\nYapı: Sivri ve güçlü dişlerdir.";
            }
            else if (mouthPart == "Lateral Kesiciler")
            {
                details = "Yerleşim: Central kesicilerin hemen yanında, üst ve alt çenede yer alır.\r\nFonksiyon: Yiyecekleri kesmek ve koparmak için kullanılır.\r\nYapı: Düz ve keskin kenarlı dişlerdir, central kesicilerden biraz daha küçüktür.";
            }
            else if (mouthPart == "Central Kesiciler")
            {
                details = "Yerleşim: Ağız boşluğunun ön kısmında, üst ve alt çenede yer alır.\r\nFonksiyon: Yiyecekleri kesmek ve koparmak için kullanılır.\r\nYapı: Düz ve keskin kenarlı dişlerdir.";
            }
            else if (mouthPart == "Labial Frenulum")
            {
                details = "Yerleşim: Üst dudağın iç kısmından diş etine kadar uzanır.\r\nFonksiyon: Üst dudağı diş etine bağlar ve dudak hareketlerini düzenler.\r\nYapı: İnce bağ dokusundan oluşur";
            }
            else
            {
                details = "Belirtilen burun bölümü hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Ağız Bölümleri Detayları");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

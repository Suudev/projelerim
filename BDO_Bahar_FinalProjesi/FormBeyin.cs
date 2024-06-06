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
    public partial class FormBeyin : Form
    {
        public FormBeyin()
        {
            InitializeComponent();
        }

        private void FormBeyin_Load(object sender, EventArgs e)
        {
            label1.Click += Label1_Click;
            label2.Click += Label1_Click;
            label3.Click += Label1_Click;
            label4.Click += Label1_Click;
            label5.Click += Label1_Click;
            label6.Click += Label1_Click;
            label7.Click += Label1_Click;
            label8.Click += Label1_Click;
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Label SelectedLabel = sender as Label;
            if (SelectedLabel != null)
            {
                string beyinPart = SelectedLabel.Text;
                ShowBeyinPart(beyinPart);
            }
        }
        private void ShowBeyinPart(string beyinPart)
        {
            string details = " ";
            if (beyinPart == "Frontal Lob")
            {
                details = "Frontal Lob (Ön Lob):\n" +
                          "Beynin ön kısmında yer alır ve birçok önemli işlevden sorumludur. Bunlar arasında:\n" +
                          "- Motor fonksiyonları: İstemli kas hareketlerini kontrol eder.\n" +
                          "- Yüksek bilişsel işlevler: Problem çözme, muhakeme, planlama, karar verme ve yargılama.\n" +
                          "- Dil: Konuşma ve dil üretimi (Broca alanı).\n" +
                          "- Kişilik ve davranış: Duygusal ifadeler, sosyal davranışlar ve dürtü kontrolü.\n" +
                          "- Hafıza: Kısa süreli bellek işlevleri.";
            }
            else if (beyinPart == "Büyük Beyin(Serebrum)")
            {
                details = "Büyük Beyin (Serebrum):\n" +
                          "Serebrum, beynin en büyük kısmıdır ve iki yarımküreden oluşur. İşlevleri şunlardır:\n" +
                          "- Bilişsel işlevler: Düşünme, problem çözme, planlama, hafıza ve dil gibi yüksek düzey bilişsel işlevlerden sorumludur.\n" +
                          "- Duyusal işlevler: Duyusal bilgileri işleyerek algı oluşturur.\n" +
                          "- Motor işlevler: İstemli hareketleri kontrol eder.\n" +
                          "- Duygusal işlevler: Duygusal tepkileri ve davranışları düzenler.\n" +
                          "- İki yarımküre: Sol yarımküre genellikle dil ve mantıksal işlemlerden sorumluyken, sağ yarımküre yaratıcı ve mekansal yeteneklerden sorumludur.";
            }
            else if (beyinPart == "Parietal Lob")
            {
                details = "Parietal Lob:\n" +
                          "Beynin orta üst kısmında bulunur ve duyusal bilgilerin işlenmesinden sorumludur. İşlevleri şunlardır:\n" +
                          "- Duyusal bilgi işlemesi: Dokunma, sıcaklık, basınç ve ağrı duyularının işlenmesi.\n" +
                          "- Mekansal farkındalık: Vücudun uzaydaki pozisyonunu algılama ve mekansal yönelim.\n" +
                          "- Okuma, yazma ve hesap yapma gibi akademik yetenekler.";
            }
            else if (beyinPart == "Temporal Lob")
            {
                details = "Temporal Lob:\n" +
                          "Beynin yan kısımlarında yer alır ve işitme, dil ve hafıza işlevlerini yönetir. İşlevleri şunlardır:\n" +
                          "- İşitme: Sesleri işitme ve işleme (birincil işitsel korteks).\n" +
                          "- Dil: Dilin anlaşılması ve işlenmesi (Wernicke alanı).\n" +
                          "- Hafıza: Uzun süreli bellek oluşturma ve hatırlama.";
            }
            else if (beyinPart == "Oksipital Lob")
            {
                details = "Occipital Lob:\n" +
                          "Beynin arka kısmında yer alır ve görsel bilgilerin işlenmesinden sorumludur. İşlevleri şunlardır:\n" +
                          "- Görsel işlemleme: Renk, ışık ve hareket gibi görsel bilgilerin analiz edilmesi.\n" +
                          "- Görsel tanıma: Yüzlerin, nesnelerin ve yazıların tanınması.";
            }
            else if (beyinPart == "Beyincik(Serebellum)")
            {
                details = "Cerebellum (Beyincik):\n" +
                          "Beynin arka alt kısmında yer alır ve motor kontrol, denge ve koordinasyon işlevlerini yönetir. İşlevleri şunlardır:\n" +
                          "- Motor kontrol: İnce motor hareketlerin koordine edilmesi.\n" +
                          "- Denge: Vücut dengesinin korunması ve postürün kontrolü.\n" +
                          "- Motor öğrenme: Yeni motor becerilerin öğrenilmesi.";
            }
            else if (beyinPart == "Omurilik")
            {
                details = "Omurilik:\n" +
                      "Omurilik, beyin ve vücut arasındaki sinir sinyallerini ileten merkezi sinir sisteminin bir parçasıdır. İşlevleri şunlardır:\n" +
                      "- Sinir iletimi: Beyinden gelen motor emirlerin kaslara iletilmesi ve duyusal bilgilerin beyine taşınması.\n" +
                      "- Refleksler: Vücudun hızlı ve otomatik tepkilerini düzenleyen refleks yollarının bulunması.\n" +
                      "- Motor ve duyusal yollar: İstemli hareketler ve duyusal algılar için sinir yollarının barındırılması.\n" +
                      "- Destek ve koruma: Omurganın içerisinde yer alarak fiziksel korunma ve yapısal destek sağlar.";
            }
            else if (beyinPart == "Motor Korteks")
            {
                details = "Motor Korteks:\n" +
                          "Frontal lobun hemen arkasında, parietal lobun önünde yer alır. İşlevleri şunlardır:\n" +
                          "- İstemli kas hareketlerini kontrol eder.\n" +
                          "- Vücudun belirli bölgelerine karşılık gelen motor işlevleri organize eder (homunculus).";
            }
            else if (beyinPart == "Somatosensoriyel Korteks")
            {
                details = "Somatosensoriyel Korteks:\n" +
                          "Parietal lobun ön kısmında, motor korteksin hemen arkasında bulunur. İşlevleri şunlardır:\n" +
                          "- Vücudun duyusal bilgilerini (dokunma, basınç, sıcaklık, ağrı) işlemektedir.\n" +
                          "- Vücudun belirli bölgelerine karşılık gelen duyusal işlevleri organize eder (homunculus).";
            }
            else
            {
                details = "Belirtilen beyin bölgesi hakkında bilgi bulunmamaktadır.";
            }

            MessageBox.Show(details, "Beyin Detayları");
        }
    }
    }


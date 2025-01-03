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
    public partial class FormInce : Form
    {
        public FormInce()
        {
            InitializeComponent();
        }

        private void FormInce_Load(object sender, EventArgs e)
        {
            label1.Click += Label1_Click;
            label2.Click += Label1_Click;
            label3.Click += Label1_Click;
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Label SelectedLabel = sender as Label;
            if (SelectedLabel != null)
            {
                string ıncePart = SelectedLabel.Text;
                ShowIncePart(ıncePart);
            }
        }
        private void ShowIncePart(string ıncePart)
        {
            string detail = " ";
            if (ıncePart == "Duodenum")
            {
                detail = "Duodenum, jejunum ve ileum'dan önce gelir ve ince bağırsağın en kısa kısmıdır. İnsanlarda duodenum, mideyi jejunum ile birleştiren yaklaşık 25–38 cm (10-15 inç) uzunluğunda içi boş, eklemli bir bağırsaktır. Duodenal bulbus ile başlar ve duodenumun asıcı kasında sona erer. Dört bölüme ayrılabilir. Duodenum neredeyse tamamen retroperitonealdir. Duodenumun pH seviyesi yaklaşık 6'dır. Duodenum ismi Latince duodenum digitorum yani 'oniki parmak'tan gelmektedir. Türkçe ismi olan onikiparmak bağırsağı da buradan gelir. Oniki parmak bağırsağının 'ilk bölümü' veya 'superior bölümü', pilor'dan transplorik düzleme doğru devam eden kısımdır. L1'in omur seviyesinde, segmentlerin geri kalanından daha üsttedir. Yaklaşık 2 cm uzunluğundaki duodenal ampul duodenumun ilk kısmıdır ve hafifçe genişlemiştir. Duodenal ampul, fetal yaşamda organı arka karın duvarından askıya alan bir mezenter olan mezoduodenumun kalıntısıdır. Oniki parmak bağırsağının ilk kısmı hareketlidir ve karaciğere küçük omentum'un hepatoduodenal ligament ile bağlıdır. Oniki parmak bağırsağının ilk kısmı köşede, 'üst duodenal eğilme' (İngilizce: superior duodenal flexure) ile biter.";
            }
            else if (ıncePart == "Jejunum")
            {
                detail = "Jejunum duodenum ile ileum arasındadır. Yetişkinlerdeki ince bağırsak ortalama 5,5–6 m uzunluğundadır. Bunun 2,5 m'si jejunumdur. pH seviyesi 7 ile 8 arasındadır. Jejunum ve ileum, karın içerisinde hareketlilik sağlayan mesenter zarıyla asılır. Ayrıca peristaltizm olarak da bilinen, yiyeceklerin bağırsak boyunca ilerlemesine yardım eden düz kaslar tarafından da sarılır. Jejunumun iç yüzeyi, kullanılabilir bağırsak iç yüzeyini artırarak bağırsak içeriği absorbsiyonunu artıran bir katmana sahiptir. Bu görevi yapan bağırsak villuslarıdır. Jejunum ve ileum ile epitel hücreleri arasında besin taşınması, fruktoz şekerlerinin pasif transportunu ve amino asitlerin, küçük peptitlerin, vitaminlerin ve büyük yapılı glikozların aktif transportunu kapsar.";
            }

            else if (ıncePart == "Ileum")
            {
                detail = "Duodenum ve jejunumu ileum takip eder ve çekumdan ileoçekal valf ile ayrılır. İnsanlarda ileum uzunluğu 2–4 m ve pH genellikle 7 ile 8 arasındadır. Superior mezenterik arterin aa. ileales ve a. ileocolica dallarından beslenir. Yapısında emilim yüzeyi oluşturan plicae circulares bulunur. Özelleşmiş olarak ise yapısında ince bağırsağın diğer kısımlarında bulunmayan Peyer plakları bulunur. Bu plaklar lenf nodüllerince zengindir. Mideden salgılanan intrinsik faktör etkisiyle ileumda B12 vitamini emilimi gerçekleşir. Ayrıca safra tuzları emilimi de ileumda gerçekleşir. Genel olarak ileumun fonksiyonu B12 vitamini, safra tuzları, jejunumda sindirilip absorbe olmamış besinlerin emilimidir. İleum duvarı, her biri küçük parmaklar gibi görev yapan, yüzeyinde mikrovillus adı verilen kıvrımlardan oluşmuştur.";
            }

            else
            {
                detail = "Bilinmeyen ince bağırsak bölümü.";
            }

            MessageBox.Show(detail, "İnce Bağırsak Detyaları");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

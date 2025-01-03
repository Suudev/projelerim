using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BDO_Bahar_FinalProjesi
{
    public partial class FormGovde_kas : Form
    {
        public FormGovde_kas()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormGovde_kas_Load);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGovde_kas_Load(object sender, EventArgs e)
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
                string bodymPart = selectedLabel.Text;
                ShowBodyPartDetails(bodymPart);
            }

        }

        private void ShowBodyPartDetails(string bodymPart)
        {
            string details = " ";

            if(bodymPart == "Lattissimus Dorsi")
            {
                details = "Yerleşim: Sırtın alt ve orta kısmında geniş bir alanı kaplayan kas, omurganın alt bölgesinden başlayıp kolun üst kısmına kadar uzanır.\r\nFonksiyon: Kolun içe rotasyonunu, ekstansiyonunu ve adduksiyonunu sağlar; aynı zamanda gövdeyi geriye doğru çeker.\r\nYapı: Geniş ve düz kas liflerinden oluşan güçlü bir kastır.\r\n";
            }
            else if (bodymPart == "Serratus Anterior")
            {
                details = "Yerleşim: Göğüs kafesinin yan tarafında, ilk dokuz kaburganın dış yüzeyinden başlayarak skapulanın iç kenarına kadar uzanır.\r\nFonksiyon: Skapulayı öne ve yukarı doğru çeker, kolun yukarı kaldırılmasına yardımcı olur.\r\nYapı: Parmak benzeri uzantılara sahip olan kas, düz ve ince kas liflerinden oluşur.";
            }
            else if (bodymPart == "Rectus Abdominis")
            {
                details = "Yerleşim: Karın bölgesinin ön kısmında, pubik kemikten başlayıp sternuma (göğüs kemiği) kadar uzanır.\r\nFonksiyon: Gövdenin fleksiyonunu sağlar, omurgayı öne doğru büker ve karın içi basıncını artırarak gövdenin stabilitesini sağlar.\r\nYapı: Dikey olarak uzanan uzun kas liflerinden oluşur, tendonlarla bölümlere ayrılmıştır ve bu segmentler \"six-pack\" olarak bilinir.";
            }
            else if (bodymPart == "Rectus Sheath")
            {
                details = "Yerleşim: Karın kaslarının üzerini kaplayan bağ dokusu kılıfı, rectus abdominis kasının önünde ve arkasında bulunur.\r\nFonksiyon: Rectus abdominis kasını sararak destek sağlar ve karın kaslarının düzgün bir şekilde çalışmasına yardımcı olur.\r\nYapı: Lifli bağ dokusundan oluşan kalın bir kılıftır.";
            }
            else if (bodymPart == "Iliac Crest")
            {
                details = "Yerleşim: Pelvik kemikte, kalçanın üst kısmında yer alan kemik çıkıntıdır.\r\nFonksiyon: Kasların ve bağ dokularının tutunma noktasıdır, aynı zamanda kalça hareketlerine destek sağlar.\r\nYapı: Kalça kemiğinin üst kısmında bulunan geniş ve kalın bir kemik çıkıntıdır.";
            }
            else if (bodymPart == "Inguinal Ligament")
            {
                details = "Yerleşim: Kasık bölgesinde, pelvisin iliac spine kısmından pubik kemiğe kadar uzanır.\r\nFonksiyon: Karın kaslarının ve bacak kaslarının bir kısmının tutunma noktasıdır, aynı zamanda kasık bölgesinin sınırlarını belirler.\r\nYapı: Kalın bağ dokusundan oluşan güçlü bir bağdır.";
            }
            else if (bodymPart == "Pectoralis Major")
            {
                details = "Yerleşim: Göğüs kafesinin ön kısmında, klavikuladan (köprücük kemiği) başlayıp üst kol kemiğine kadar uzanır.\r\nFonksiyon: Kolun adduksiyonunu, fleksiyonunu ve iç rotasyonunu sağlar; aynı zamanda omuz hareketlerine destek olur.\r\nYapı: Büyük, yelpaze şeklinde kas liflerinden oluşur.";
            }
            else if (bodymPart == "Rectus Abdominis(sheated)")
            {
                details = "Yerleşim: Karın bölgesinin ön kısmında, pubik kemikten başlayıp sternuma (göğüs kemiği) kadar uzanan ve bağ dokusu kılıfıyla çevrili bir kas.\r\nFonksiyon: Gövdenin fleksiyonunu sağlar, omurgayı öne doğru büker ve karın içi basıncını artırarak gövdenin stabilitesini sağlar. Ayrıca, karın kaslarını koruyarak karın içi organların güvenliğini sağlar.\r\nYapı: Uzun, dikey kas liflerinden oluşur ve tendonlarla bölümlere ayrılmıştır. Bu kas, rectus sheath adı verilen bağ dokusu kılıfıyla sarılmış olup, bu kılıf kasın düzgün çalışmasını ve korunmasını sağlar.";
            }
            else if (bodymPart == "Linea Alba")
            {
                details = "Yerleşim: Karın bölgesinin ortasında, göbek deliğinden sternuma kadar uzanan dikey bir çizgi şeklinde bulunur.\r\nFonksiyon: Karın kaslarını iki yanda birbirine bağlar ve karın duvarının güçlü ve esnek olmasını sağlar.\r\nYapı: Bağ dokusundan oluşan ince, beyaz bir banttır.";
            }
            else if (bodymPart == "Umbilicus")
            {
                details = "Yerleşim: Karın bölgesinin ortasında, linea alba üzerinde bulunur; göbek deliği olarak da bilinir.\r\nFonksiyon: Doğumdan önce göbek kordonunun bağlandığı noktadır, doğumdan sonra karın duvarının bir parçası olarak kalır.\r\nYapı: Derinin içe doğru kıvrılarak oluşturduğu küçük bir çukur veya izdir.";
            }
            else if (bodymPart == "External Abdominal Oblique")
            {
                details = "Yerleşim: Karın bölgesinin yan taraflarında, alt sekiz kaburgadan başlayarak pelvise kadar uzanır.\r\nFonksiyon: Gövdenin rotasyonunu ve yanlara doğru fleksiyonunu sağlar, aynı zamanda karın içi basıncını artırarak gövde stabilitesini destekler.\r\nYapı: Dışa doğru eğik uzanan kas liflerinden oluşur.";
            }
            else if (bodymPart == "Inguinal Canal")
            {
                details = "Yerleşim: Kasık bölgesinde, inguinal ligamentin hemen altında bulunur.\r\nFonksiyon: Erkeklerde sperm kanalının, kadınlarda ise rahim yuvarlak bağının geçtiği kanaldır; kasık bölgesinin anatomik yapılarının geçiş noktasıdır.\r\nYapı: Kasık bölgesinde, kas dokuları arasında yer alan kısa bir kanaldır.";
            }

            else
            {
                details = "Belirtilen burun bölümü hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Gövde Kasları Bölümleri Detayları");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }



    }

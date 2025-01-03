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
    public partial class FormKalın : Form
    {
        public FormKalın()
        {
            InitializeComponent();
        }

        private void FormKalın_Load(object sender, EventArgs e)
        {
            label1.Click += Label1_Click;
            label2.Click += Label1_Click;
            label3.Click += Label1_Click;
            label4.Click += Label1_Click;
            label5.Click += Label1_Click;
            label6.Click += Label1_Click;
            label7.Click += Label1_Click;
        
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Label SelectedLabel = sender as Label;
            if (SelectedLabel != null)
            {
                string kalınPart = SelectedLabel.Text;
                ShowKalınPart(kalınPart);
            }
        }
        private void ShowKalınPart(string kalınPart)
        {
            string details = " ";

            if (kalınPart == "Çekum")
            {
                details = "Çekum, kolonun ilk ve en kalın parçasıdır, karın sağ alt kadrandadır (sağ iliak fossa), tabanında apendiks bulunur. Nispeten mobildir (serbesttir). İleum çekumun medialinden çekuma bağlanır. Çekumun yaklaşık boyu 6,5 cm, eni 7,5-8.5 cm dir ve kalın bağırsağın en geniş kısmıdır. Bu yüzden çekum, obstrüksiyona en dirençli, perforasyona en duyarlı kolon segmentidir. 3 tenia, çekum tabanında dağılarak birleşir ve tam buradan apendiks köken alır.";
            }
            else if (kalınPart == "Rektum")
            {
                details = "Rektum, kalın bağırsağın son kısmıdır ve sigmoid kolon ile anüs arasındadır. Dışkıların depolandığı ve son hazırlıkların yapıldığı bölümdür. Hemoroid gibi sorunlar bu bölgede ortaya çıkabilir.";
            }
            else if (kalınPart == "Apendiks")
            {
                details = "Apendiks çekumun solucan şeklinde (vermiform) bir uzantısıdır (ince kör bir tüptür). Uzunluğu yaklaşık 5-10 cm kadardır (1-25 cm olabilir). Sağlıklı apendiks çapı 6 mm'yi geçmez.\r\n\r\nApendiksin çıkış yeri nispeten sabittir; 3 tenianın çekum tabanında dağılarak birleştiği yerdir (McBurney noktasının izdüşümüne karşılık gelir). Ancak apendiksin diğer kısımları serbesttir bu yüzden farklı pozisyonlarda bulunabilir; retroçekal (en çok), pelvik, subçekal, preileal, postileal. Apendektomi yaparken çekumun önündeki tenia takip edilerek apendikse ulaşılabilir (tenia libera).";
            }
            else if (kalınPart == "Çıkan Kolon")
            {
                details = "Çıkan Kolon, karnın sağ üst tarafında yer alır ve aslen incebağırsak ile bağlantılıdır. Yemeklerin son aşamasında suyun emilimi gerçekleşir. Bu bölgede divertiküloz gibi durumlar ortaya çıkabilir.Çıkan kolon, çekumdan sonraki kolon segmentidir, yaklaşık 12,5-20 cm uzunluğundadır, yukarı (karaciğere) doğru çıkar, karaciğer sağ lobunun altından keskin bir dönüş yaparak sola döner (hepatik fleksura) ve dalağa doğru gider (transvers kolon). Çıkan kolonun sadece lateral, ön yüzü ve mediali peritonla kaplıdır bu yüzden retroperitoneal kabul edilir (inen kolon gibi).\r\n\r\nHepatik fleksura, sağ böbrek alt kutbunun ve duodenumun inen kısmının (2. kıta) önünde, safra kesesinin lateralinde kalır.";
            }
            else if (kalınPart == "İnen Kolon")
            {
                details = "Inen Kolon, karın bölgesinin sağ tarafında bulunur ve çıkan kolonun devamı niteliğindedir. Besinlerin sindiriminden sonra atıkların şekillendirildiği yerdir. Kolon kanseri gibi ciddi sağlık sorunları bu bölgede görülebilir.";
            }
            else if (kalınPart == "Sigmoid Kolon")
            {
                details = "Sigmoid Kolon, ince bağırsak ile rektum arasında yer alır ve kolonun son kısmını oluşturur. Katı atıkların geçişi ve depolanması bu bölgede gerçekleşir. Bu bölgede divertikülit gibi durumlar ortaya çıkabilir.";
            }
            else if (kalınPart == "Tansvers Kolon")
            {
                details = " Transvers kolon, hepatik fleksuradan başlayıp splenik fleksuraya uzanan, aşağı doğru kavisli, yatay kolon parçasıdır. 40-50 cm uzunluğundadır. Tamamen intraperitoneal dir ve mezosu vardır (transvers mezokolon), kolonun en mobil kısmıdır.\r\n\r\nTransvers mezokolon, karın boşluğunu iki kompartmana ayırır; supra-mezokolik ve infra-mezokolik boşluk (kompartman). Transvers mezokolon böylece peritonit ve apsenin yayılımında doğal bir bariyer görevi görür.\r\n\r\nTransvers kolon anterosuperior kısmından, mide büyük kurvatürüne gastrokolik omentum (ligament) ile bağlıdır. Gastrokolik ligament, kolonoskopide transvers kolonun içeriden üçgenimsi (trianguler) görünmesine neden olur. Gastrokolik ligament aşağıya bir mutfak önlüğü gibi uzanarak, karın içi organların üzerini örter (omentum majus). Gastrokolik ligament açıldığında, bursa omentalise girilmiş olur (lesser sac). Başka bir deyişle midenin arka yüzüne ve pankreasa ulaşılır. Örneğin, mide yaralanmalarında midenin arka yüzünü kontrol etmek için, distal pankreatektomilerde gastrokolik ligaman (ligament) açılır. ";
            }


            MessageBox.Show(details, "Kalın Bğırsak Detayları");
        }


        private void label6_Click(object sender, EventArgs e)
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

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
    public partial class FormKafa : Form
    {
        public FormKafa()
        {
            InitializeComponent();
        }

        private void FormKafa_Load(object sender, EventArgs e)
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
                // Tıklanan bölümün adını al ve detaylarını göster
                string skullPart = selectedLabel.Text;
                ShowSkullPartDetails(skullPart);
            }
        }

        private void ShowSkullPartDetails(string skullPart)
        {
            string details;

            if (skullPart == "Parietal Bone")
            {
                details = "Parietal Kemik:\n\n" +
                          "- Kafatasının yanları ve tepesinde bulunan, çift halinde iki kemiktir.\n" +
                          "- Orta hatta sagittal sütur ile birleşirler.\n" +
                          "- Beyni koruma görevi görür ve kafatasının merkezi yan ve üst arka kısmını oluşturur.";
            }
            else if (skullPart == "Frontal Bone")
            {
                details = "Frontal Kemik:\n\n" +
                          "- Kafatasının ön kısmında bulunur.\n" +
                          "- Alnı, burun kökünü ve göz yuvalarının üst kısmını oluşturur.\n" +
                          "- Frontal sinüsleri içerir ve beyni koruma işlevi görür.";
            }
            else if (skullPart == "Occipital Bone")
            {
                details = "Oksipital Kemik:\n\n" +
                          "- Kafatasının arka ve taban kısmında bulunur.\n" +
                          "- Omuriliğin beyinle bağlantısını sağlayan foramen magnum içerir.\n" +
                          "- Ayrıca oksipital kondiller ile ilk boyun omuru (atlas) ile eklem yapar.";
            }
            else if (skullPart == "Temporal Bone (Squamous)")
            {
                details = "Temporal Kemik (Squamous Kısım):\n\n" +
                          "- Kafatasının yanları ve tabanında bulunur.\n" +
                          "- Kulak yapılarını barındırır ve temporal bölgenin büyük bir kısmını oluşturur.\n" +
                          "- Squamous kısmı, temporal kemiğin ince ve yassı olan kısmıdır.";
            }
            else if (skullPart == "Sphenoid Bone")
            {
                details = "Sfenoid Kemik:\n\n" +
                          "- Kafatasının tabanında, merkezi bir konumda bulunur.\n" +
                          "- Kelebeğe benzeyen bir yapısı vardır ve tüm kafatası kemikleriyle eklem yapar.\n" +
                          "- Hipofiz bezi için sella turcica adı verilen bir çukura sahiptir.";
            }
            else if (skullPart == "Lacrimal Bone")
            {
                details = "Lakrimel Kemik:\n\n" +
                          "- Göz yuvasının iç köşesinde, burun yanındaki küçük kemiktir.\n" +
                          "- Gözyaşı kanalını barındırır ve gözyaşlarının burun boşluğuna akmasını sağlar.";
            }
            else if (skullPart == "Nasal Bone")
            {
                details = "Nazal Kemik:\n\n" +
                          "- Burun köprüsünü oluşturan iki küçük dikdörtgen kemiktir.\n" +
                          "- Burnun üst kısmını destekler ve burun yapısının sağlamlığını sağlar.";
            }
            else if (skullPart == "Zygomatic Bone")
            {
                details = "Zigomatik Kemik:\n\n" +
                          "- Elmacık kemikleri olarak bilinir.\n" +
                          "- Yüzün yan kısmında, göz yuvasının alt ve yan tarafında bulunur.\n" +
                          "- Maksilla, temporal ve frontal kemiklerle eklem yapar.";
            }
            else if (skullPart == "Maxilla")
            {
                details = "Maksilla:\n\n" +
                          "- Üst çene kemiğidir ve iki parçadan oluşur.\n" +
                          "- Üst dişleri, burun boşluğunun bir kısmını ve damak yapısını barındırır.\n" +
                          "- Maksiller sinüsleri içerir ve yüzün merkezi yapılarından biridir.";
            }
            else if (skullPart == "Teeth")
            {
                details = "Dişler:\n\n" +
                          "- Besinleri parçalamak ve çiğnemek için kullanılan sert, mineralleşmiş yapılar.\n" +
                          "- Dişler, üst (maksilla) ve alt (mandibula) çenelerde bulunur.\n" +
                          "- Her bir diş, kök, boyun ve taç olmak üzere üç ana bölümden oluşur.";
            }
            else if (skullPart == "External Acoustic Meatus")
            {
                details = "Dış Akustik Meatus:\n\n" +
                          "- Kafatasının temporal kemiğinde bulunan dış kulak yoludur.\n" +
                          "- Ses dalgalarını kulak zarına ileterek işitme sürecini başlatır.";
            }
            else if (skullPart == "Temporal Bone (Mastoid)")
            {
                details = "Temporal Kemik (Mastoid Kısım):\n\n" +
                          "- Temporal kemiğin arka alt kısmında bulunur.\n" +
                          "- Mastoid hücreleri içeren, hava dolu boşluklarla kaplı bir kemik yapısıdır.\n" +
                          "- Kulak enfeksiyonlarının yayılmasını önler ve boyun kaslarının bağlandığı yerlerden biridir.";
            }
            else if (skullPart == "Temporal Bone (Styloid Process)")
            {
                details = "Temporal Kemik (Stiloid Çıkıntı):\n\n" +
                          "- Temporal kemiğin alt kısmında, ince ve sivri bir çıkıntıdır.\n" +
                          "- Dil ve boyun kaslarının, ligamentlerin bağlandığı yerdir.";
            }
            else if (skullPart == "Mandible")
            {
                details = "Mandibula:\n\n" +
                          "- Alt çene kemiğidir.\n" +
                          "- Yüzün en hareketli ve güçlü kemiğidir, çiğneme fonksiyonunda önemli rol oynar.\n" +
                          "- Temporomandibular eklem ile kafatasına bağlanır ve çene hareketlerini sağlar.";
            }
            else
            {
                details = "Belirtilen kafatası parçası hakkında bilgi bulunmamaktadır.";
            }

            // Detayları bir mesaj kutusunda göster
            MessageBox.Show(details, "Kafatası Kemikleri Detayları");

        }


    }
}

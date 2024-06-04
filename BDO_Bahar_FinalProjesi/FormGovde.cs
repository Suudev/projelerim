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
    public partial class FormGovde : Form
    {
        public FormGovde()
        {
            InitializeComponent();
        }

        private void FormGovde_Load(object sender, EventArgs e)
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
            if(SelectedLabel != null)
            {
                string govdePart = SelectedLabel.Text;
                ShowGovdePart(govdePart);
            }
        }
        private void ShowGovdePart(string govdePart)
        {
            string details = " ";
            if (govdePart == "Clavicle")
            {
                details = "Köprücük kemiği (Clavicle), omuz kuşağının bir parçası olup, sternum (göğüs kemiği) ile scapula (kürek kemiği) arasında yer alır. Bu kemik, omuz hareketlerinin geniş bir yelpazede yapılmasına olanak tanır ve aynı zamanda üst ekstremitenin gövdeye bağlanmasında önemli bir rol oynar. Köprücük kemiği, S şeklindedir ve kırılması durumunda kolayca hissedilebilir. Kaslar ve bağlar aracılığıyla birçok önemli yapı ile bağlantılıdır ve vücudun duruşunu destekler.";
            }
            else if (govdePart == "Shoulder Joint")
            {
                details = "Omuz eklemi (Shoulder Joint), kol kemiği (humerus) ile kürek kemiği (scapula) arasındaki eklemdir. Bu eklem, insan vücudunun en hareketli eklemidir ve geniş bir hareket yelpazesi sağlar. Rotator cuff olarak bilinen kas grubu tarafından desteklenir ve stabilize edilir. Omuz eklemi, fleksiyon, ekstansiyon, abduksiyon, adduksiyon, iç rotasyon ve dış rotasyon gibi çeşitli hareketleri gerçekleştirir. Bu eklemdeki yaralanmalar, hareket kısıtlılığına ve ağrıya neden olabilir.";
            }
            else if (govdePart == "Ribs")
            {
                details = "Kaburgalar (Ribs), göğüs kafesini oluşturan kemiklerdir. Toplamda 12 çift kaburga bulunur ve bunlar omurgaya bağlıdır. İlk yedi çift kaburga gerçek kaburgalar olarak bilinir ve doğrudan sternuma bağlanır. Kalan beş çift kaburga ise yalancı kaburgalar olarak bilinir ve doğrudan sternuma bağlanmaz. Kaburgalar, akciğerleri ve kalbi koruyan güçlü bir yapıdır ve solunum sırasında göğüs kafesinin genişlemesine yardımcı olur. Ayrıca, kaburga kemikleri, birçok kasın bağlanma noktasıdır.";
            }
            else if (govdePart == "Spine")
            {
                details = "Omurga (Spine), vertebralar adı verilen kemiklerin ardışık olarak dizilmesiyle oluşur. İnsan omurgası, 33 vertebradan oluşur ve bu vertebralar beş farklı bölgeye ayrılır: servikal (boyun), torasik (göğüs), lomber (bel), sakral (kuyruk sokumu) ve koksigeal (kuyruk kemiği) bölgeler. Omurga, vücudun dik durmasını sağlar, merkezi sinir sistemini korur ve vücudun esnekliğini artırır. Omurlar arasındaki diskler, şok emici olarak işlev görür ve omurga hareketlerini kolaylaştırır.";
            }
            else if (govdePart == "Ilium")
            {
                details = "İlium, pelvisin (leğen kemiği) üst ve geniş kısmını oluşturan kemiktir. İlium, vücudun ağırlığını taşıyan ve bacakların hareketine olanak tanıyan önemli bir kemiktir. Ayrıca iliak krest adı verilen üst kenarı, kasların ve bağların bağlandığı önemli bir bölgedir. İlium, kalça eklemi ile birleşerek femurun (uyluk kemiği) gövdeye bağlanmasını sağlar. Pelvik kemikler, doğum sırasında kadınlarda genişleyerek doğum kanalını oluşturur.";
            }
            else if (govdePart == "Sacrum")
            {
                details = "Sakrum, omurganın alt kısmında yer alan büyük, üçgen şekilli bir kemiktir. Beş omurun birleşmesiyle oluşur ve pelvisin arka kısmını oluşturur. Sakrum, omurganın stabilitesini sağlamakta ve pelvisle olan bağlantıyı oluşturmaktadır. Sakrumdaki foramina adı verilen delikler, sinirlerin geçişine izin verir. Sakrum, aynı zamanda bacakların hareketini ve vücudun dik durmasını sağlayan birçok kasın ve bağın bağlanma noktasıdır.";
            }
            else if (govdePart == "Coccyx Bone")
            {
                details = "Kuyruk sokumu kemiği (Coccyx), omurganın en alt kısmında yer alan küçük, üçgen şekilli bir kemiktir. Dört küçük omurun birleşmesiyle oluşur ve pelvisin alt kısmını tamamlar. Kuyruk sokumu kemiği, bazı kas ve bağların bağlanma noktasıdır ve otururken vücut ağırlığını dağıtmaya yardımcı olur. Kuyruk sokumu kemiği, zamanla kaynaşarak tek bir yapı haline gelir ve genellikle hareketsizdir. Yaralanmaları, oturma pozisyonunda ağrıya neden olabilir.";
            }
            else
            {
                details = "Belirtilen vücut parçası hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Govde Kemikleri Detayları");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

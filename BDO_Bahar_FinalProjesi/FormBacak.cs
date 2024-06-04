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
    public partial class FormBacak : Form
    {
        public FormBacak()
        {
            InitializeComponent();
        }

        private void FormBacak_Load(object sender, EventArgs e)
        {
            label1.Click += Label_Click;
            label2.Click += Label_Click;
            label3.Click += Label_Click;
            label4.Click += Label_Click;
            label5.Click += Label_Click;
            label6.Click += Label_Click;
            label7.Click += Label_Click;
            
        }
        private void Label_Click(object sender ,EventArgs e)
        {
            Label selectedLabel = sender as Label;
            if(selectedLabel != null)
            {
                string legPart = selectedLabel.Text;
                ShowLegPartDetails(legPart);
            }
        }
        private void ShowLegPartDetails(string legPart)
        {
            string details = " ";

            if (legPart == "Femur")
            {
                details = "Femur, insan vücudundaki en uzun ve en güçlü kemiktir. Uyluk bölgesinde bulunur ve kalçadan dize kadar uzanır. Kalça ekleminde pelvis ile, diz ekleminde ise tibia ve patella ile bağlantı kurar. Femur, vücudun ağırlığını taşır ve yürüme, koşma, zıplama gibi hareketlerde önemli rol oynar. Femurun üst ucu kalça eklemine, alt ucu ise diz eklemine bağlanır. Ayrıca, femurda bulunan trokanterler (büyük ve küçük) kasların yapışma noktalarıdır.";
            }
            else if (legPart == "Patella")
            {
                details = "Patella, diz kapağı olarak da bilinir ve diz ekleminin önünde bulunan üçgen şeklinde bir kemiktir. Patella, quadriceps kasının bir parçası olarak hareket eder ve diz eklemini korur. Diz bükülmesi sırasında femurun oluğunda kayar ve bacağın düzleşmesine yardımcı olur. Patella ayrıca diz ekleminin stabilitesini artırır ve aşırı gerilme durumlarında koruma sağlar.";
            }
            else if (legPart == "Fibula")
            {
                details = "Fibula, ince ve uzun bir kemik olup, bacağın yan tarafında bulunur. Tibia ile birlikte bacağın alt kısmını oluşturur. Fibula, diz eklemine doğrudan katılmaz ancak ayak bileği ekleminde önemli bir rol oynar. Fibula, bacağın stabilitesini ve dayanıklılığını artırır. Ayrıca, fibula üzerine kaslar ve bağlar tutunarak bacak hareketlerine destek olur.";
            }
            else if (legPart == "Tibia")
            {
                details = "Tibia, kalın ve güçlü bir kemiktir ve bacağın iç kısmında bulunur. Fibula ile birlikte bacağın alt kısmını oluşturur ve diz ekleminden ayak bileğine kadar uzanır. Tibia, vücudun ağırlığını taşır ve yürürken, koşarken veya zıplarken destek sağlar. Tibianın üst ucu diz eklemine, alt ucu ise ayak bileği eklemine bağlanır. Tibia ayrıca, ön ve arka kısımlarında kas ve bağların tutunma noktaları bulunan geniş bir yüzeye sahiptir.";
            }
            else if (legPart == "Tarsals")
            {
                details = "Tarsal kemikler, ayak bileğinde bulunan küçük kemiklerdir. Toplamda yedi tarsal kemik bulunur: talus, kalkaneus, naviküler, küboid ve üç kuneiform kemik. Tarsal kemikler, ayak bileğinin hareketliliğini ve stabilitesini sağlar. Talus, tibia ve fibula ile eklem yaparak ayak bileğinin ana eklemini oluşturur. Kalkaneus, topuk kemiği olarak bilinir ve vücut ağırlığının büyük bir kısmını taşır.";
            }
            else if (legPart == "Metatarsals")
            {
                details = "Metatarsal kemikler, ayak tabanında bulunan beş uzun kemiktir. Her bir metatarsal kemik, ayak bileği kemiklerinden başlayarak ayak parmaklarına kadar uzanır. Metatarsal kemikler, ayak parmaklarını destekler ve yürüme, koşma gibi aktiviteler sırasında vücut ağırlığını taşır. Metatarsal kemiklerin tabanında bulunan baş kısımları, parmak eklemleri ile bağlantılıdır ve ayak kemerinin oluşumuna katkıda bulunur.";
            }
            else if (legPart == "Phalanges")
            {
                details = "Phalanges, ayak parmaklarında bulunan kemiklerdir. Her ayakta toplam 14 adet phalange bulunur: her bir büyük ayakta iki distal, iki orta ve bir proksimal phalange; her bir küçük ayakta ise üç distal, iki orta ve bir proksimal phalange. Phalanges kemikleri, ayak parmaklarının hareket etmesine olanak sağlar ve dengeyi korumada önemli bir rol oynar. Ayak parmakları, yürüme ve koşma sırasında zemine tutunarak itici kuvvet sağlar.";
            }
            else
            {
                details = "Belirtilen bacak parçası hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Bacak Kemikleri Detayları");

            
        }
       

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

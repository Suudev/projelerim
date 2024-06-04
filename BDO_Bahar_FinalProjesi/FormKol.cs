using System;
using System.Windows.Forms;

namespace BDO_Bahar_FinalProjesi
{
    public partial class FormKol : Form
    {
        public FormKol()
        {
            InitializeComponent();
        }

        private void FormKol_Load(object sender, EventArgs e)
        {
            
            label1.Click += Label_Click;
            label2.Click += Label_Click;
            label3.Click += Label_Click;
            label4.Click += Label_Click;
            label5.Click += Label_Click;
            label6.Click += Label_Click;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;

            if (selectedLabel != null)
            {
                string armPart = selectedLabel.Text;
                ShowArmPartDetails(armPart);
            }
        }

        private void ShowArmPartDetails(string armPart)
        {
            string details;

            if (armPart == "Phalanges")
            {
                details = "Phalanges (Parmak Kemikleri):\n\n" +
                          "- Parmakları oluşturan kemiklerdir.\n" +
                          "- Her parmakta üç falanks (proksimal, orta, distal), baş parmakta ise iki falanks (proksimal, distal) bulunur.\n" +
                          "- Phalanges kemikleri, parmakların hareketini sağlar ve el becerilerini artırır.\n" +
                          "- Parmak eklemleri, kavrama ve ince motor hareketleri için esneklik ve dayanıklılık sağlar.";
            }
            else if (armPart == "Metacarpals")
            {
                details = "Metacarpals (Orta El Kemikleri):\n\n" +
                          "- El bileği ve parmaklar arasındaki beş uzun kemikten oluşur.\n" +
                          "- Her metacarpal kemik, bir parmağa bağlıdır ve elin avuç içi kısmını oluşturur.\n" +
                          "- Metacarpal kemikler, elin kavrama gücünü ve esnekliğini sağlar.\n" +
                          "- Parmakların hareketini destekleyen kaslar ve tendonlar, metacarpal kemiklere bağlanır.";
            }
            else if (armPart == "Carpals")
            {
                details = "Carpals (El Bileği Kemikleri):\n\n" +
                          "- El bileğini oluşturan sekiz küçük kemikten oluşur.\n" +
                          "- İki sıra halinde dizilmiş olan carpals kemikleri, proksimal sıra (scaphoid, lunate, triquetrum, pisiform) ve distal sıra (trapezium, trapezoid, capitate, hamate) olarak adlandırılır.\n" +
                          "- El bileği ekleminin esnekliğini ve hareketliliğini sağlar.\n" +
                          "- Carpals kemikleri, elin stabilitesini artırır ve bilek hareketlerine destek olur.";
            }
            else if (armPart == "Ulna")
            {
                details = "Ulna:\n\n" +
                          "- El bileği ve dirsek arasında bulunan uzun kemiklerden biridir.\n" +
                          "- Radiusun karşısında, elin iç tarafında yer alır.\n" +
                          "- Dirsekte humerus ile eklem yapar ve dirsek hareketlerine yardımcı olur.\n" +
                          "- Ulnanın alt ucu, el bileği kemikleriyle eklem yapar ve bilek hareketlerini destekler.";
            }
            else if (armPart == "Radius")
            {
                details = "Radius:\n\n" +
                          "- El bileği ve dirsek arasında bulunan uzun kemiklerden biridir.\n" +
                          "- Ulnaya paralel olarak uzanır ve elin dış tarafında yer alır.\n" +
                          "- Radiusun üst ucu, humerus ile dirsek eklemini oluşturur.\n" +
                          "- Alt ucu ise el bileği kemikleriyle eklem yapar ve bilek hareketlerini sağlar.\n" +
                          "- Radius, önkolun dönme hareketine (pronasyon ve supinasyon) olanak tanır.";
            }
            else if (armPart == "Humerus")
            {
                details = "Humerus (Üst Kol Kemiği):\n\n" +
                          "- Omuz ve dirsek arasında yer alan en uzun üst kol kemiğidir.\n" +
                          "- Üst kısmında omuz eklemi, alt kısmında dirsek eklemi bulunur.\n" +
                          "- Humerusun baş kısmı, scapula ile omuz eklemini oluşturur.\n" +
                          "- Alt uçta ise radius ve ulna ile dirsek eklemini oluşturur.\n" +
                          "- Humerus, kolun hareketini sağlayan kasların bağlandığı önemli bir kemiktir.";
            }
            else
            {
                details = "Belirtilen kol parçası hakkında bilgi bulunmamaktadır.";
            }

            MessageBox.Show(details, "Kol ve El Kemikleri Detayları");

        }
    }
}
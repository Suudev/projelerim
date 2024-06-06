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
    public partial class FormKaraciger : Form
    {
        public FormKaraciger()
        {
            InitializeComponent();
        }

        private void FormKaraciger_Load(object sender, EventArgs e)
        {
            label1.Click += Label1_Click;
            label2.Click += Label1_Click;
            label3.Click += Label1_Click;
            label4.Click += Label1_Click;
            label5.Click += Label1_Click;
            label6.Click += Label1_Click;
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Label SelectedLabel = sender as Label;
            if (SelectedLabel != null)
            {
                string karacigerPart = SelectedLabel.Text;
                ShowKaracigerPart(karacigerPart);
            }
        }
        private void ShowKaracigerPart(string karacigerPart)
        {
            string detail = "";

            if (karacigerPart == "Inferior Vena Cava")
            {
                detail = "Inferior Vena Cava, vücudun alt kısmından kalbe dönen kirli kanı taşıyan büyük bir toplardamardır. Karaciğerin alt kısmından geçer ve sağ atriyuma dökülür.";
            }
            else if (karacigerPart == "Aorta")
            {
                detail = "Aorta, kalpten çıkan büyük atardamardır. Oksijenli kanı vücuda taşır ve vücudun tüm bölgelerine kan pompalar. Aorta, karaciğerin yanından geçer ve vücuttaki en büyük atardamarlardan biridir.";
            }
            else if (karacigerPart == "Gall Bladder")
            {
                detail = "Gall Bladder, safra kesesi olarak da bilinir. Karaciğer tarafından üretilen safra depolandığı ve konsantre edildiği bir organdır. Safra, yağların sindiriminde yardımcı olur.";
            }
            else if (karacigerPart == "Common Bile Duct")
            {
                detail = "Common Bile Duct, safra kanalı olarak da bilinir. Karaciğer ve safra kesesi tarafından üretilen safra, common bile duct aracılığıyla onikiparmak bağırsağına taşınır. Burada yağların sindiriminde rol oynar.";
            }
            else if (karacigerPart == "Hepatic Artery")
            {
                detail = "Hepatic Artery, karaciğer arteri olarak da bilinir. Karaciğere oksijenli kan taşır ve karaciğer hücrelerine besin sağlar. Karaciğer, hem oksijenli hem de besleyici kanı hepatic artery aracılığıyla alır.";
            }
            else if (karacigerPart == "Portal Vein")
            {
                detail = "Portal Vein, karaciğer portali olarak da bilinir. Bağırsaklardan gelen kirli kanı karaciğere taşır. Bu kan, sindirilmiş besin maddelerini ve toksinleri karaciğere götürür, burada temizlenir ve işlenir.";
            }

            MessageBox.Show(detail, "Karaciğer Detayları - " + karacigerPart);
        }

    }
}

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
            // Labellara Click olayı için aynı olay işleyiciyi atayalım
            label1.Text = "Phalangese";
            label2.Text = "Metacarpals";
            label3.Text = "Carpals";
            label4.Text = "Ulna";
            label5.Text = "Radius";
            label6.Text = "Humerus";
            label1.Click += Label_Click;
            label2.Click += Label_Click;
            label3.Click += Label_Click;
            label4.Click += Label_Click;
            label5.Click += Label_Click;
            label6.Click += Label_Click;
            // Diğer labellara da aynı şekilde Click olayı işleyici atanabilir
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;

            if (selectedLabel != null)
            {
                // Tıklanan bölümün adını al ve detaylarını göster
                string armPart = selectedLabel.Text;
                ShowArmPartDetails(armPart);
            }
        }

        private void ShowArmPartDetails(string armPart)
        {
            string details;

            if (armPart == "Phalangese")
            {
                details = "Phalanges (Parmak Kemikleri):\n\n- Parmakları oluşturan kemiklerdir.\n- Her parmakta üç, baş parmakta ise iki adet bulunur.";
            }
            else if (armPart == "Metacarpals")
            {
                details = "Metacarpals (Orta El Kemikleri):\n\n- El bileği ve parmaklar arasındaki kemiklerdir.\n- Toplamda beş adettir.";
            }
            else if (armPart == "Carpals")
            {
                details = "Carpals (El Bileği Kemikleri):\n\n- El bileğini oluşturan küçük kemikler grubudur.\n- Toplamda sekiz adettir.";
            }
            else if (armPart == "Ulna")
            {
                details = "Ulna:\n\n- El bileği ve dirsek arasında bulunan kısa kemiklerden biridir.\n- Radiusun karşısında, elin iç tarafında yer alır.";
            }
            else if (armPart == "Radius")
            {
                details = "Radius:\n\n- El bileği ve dirsek arasında bulunan kısa kemiklerden biridir.\n- Uzun kemiklerden biri olan ulnaya paralel olarak uzanır.";
            }

            else if (armPart == "Humerus")
            {
                details = "Humerus (Üst Kol Kemiği):\n\n- Omuz ve dirsek arasında yer alan en uzun üst kol kemiğidir.\n- Üst kısmında omuz eklemi, alt kısmında dirsek eklemi bulunur.";
            }

            else
            {
                details = "Details for this arm part are not available.";
            }

            // Detayları bir mesaj kutusunda göster
            MessageBox.Show(details, "Arm Part Details");
        }
    }
}
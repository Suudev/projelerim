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
            /*
           label1.Text = "Femur";
           label2.Text = "Patella";
           label3.Text = "Fibula";
           label4.Text = "Tibia";
           label5.Text = "Tarsals";
           label6.Text = "Metatarsals";
           label1.Text = "Phalanges";
           */

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
            if(legPart == "Femur")
            {
                details = "The femur is the longest and strongest bone in the human body.It is located in the thigh and connects the hip to the knee. It plays a crucial role in supporting the body's weight and facilitating movement.";
            }
            else if (legPart == "Patella")
            {
                details = "Patella, diz kapağı olarak da bilinir. Diz eklemi önünde bulunan üçgen bir kıkırdak parçasıdır. Diz hareketini destekler ve korur.";
            }
            else if (legPart == "Fibula")
            {
                details = "Fibula, ince ve uzun bir kemik olup, bacağın yan tarafında bulunur. Tibia ile birlikte bacağın alt kısmını oluşturur.";
            }
            else if (legPart == "Tibia")
            {
                details = "Tibia, kalın ve güçlü bir kemiktir ve bacağın iç kısmında bulunur. Fibula ile birlikte bacağın alt kısmını oluşturur.";
            }
            else if (legPart == "Tarsals")
            {
                details = "Tarsal kemikler, ayak bileğinde bulunan küçük kemiklerdir. Ayak bileğinin dengesini sağlarlar ve ayak hareketlerine destek olurlar.";
            }
            else if (legPart == "Metatarsals")
            {
                details = "Metatarsal kemikler, ayak tabanında bulunan beş uzun kemiktir. Ayak parmaklarını destekler ve yürüme sırasında vücut ağırlığını taşır.";
            }
            else if (legPart == "Phalanges")
            {
                details = "Phalanges, ayak parmaklarında bulunan kemiklerdir. Her ayakta toplam 14 adet phalange bulunur: her bir büyük ayakta iki distal, iki orta ve bir proksimal phalange; her bir küçük ayakta ise üç distal, iki orta ve bir proksimal phalange.";
            }
            else
            {
                details = "Geçersiz bir legPart değeri girildi.";
            }
            MessageBox.Show(details, "leg part details");
        }
       

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

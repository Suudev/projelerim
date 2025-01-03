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
    public partial class FormKalp : Form
    {
        public FormKalp()
        {
            InitializeComponent();
        }

        private void FormKalp_Load(object sender, EventArgs e)
        {
            label1.Click += Label1_Click;
            label2.Click += Label1_Click;
            label3.Click += Label1_Click;
            label4.Click += Label1_Click;
            label5.Click += Label1_Click;
            label6.Click += Label1_Click;
            label7.Click += Label1_Click;
            label8.Click += Label1_Click;
            label9.Click += Label1_Click;
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Label SelectedLabel = sender as Label;
            if (SelectedLabel != null)
            {
                string kalpPart = SelectedLabel.Text;
                ShowKalpPart(kalpPart);
            }
        }
        private void ShowKalpPart(string kalpPart)
        {
            string detail = "";

            if (kalpPart == "Sağ Kulakçık")
            {
                detail = "Sağ kulakçık, kalbin üst kısmında yer alan odacıktır. Akciğerlerden gelen oksijenli kanı sol kulakçığa pompalar.";
            }
            else if (kalpPart == "Ana Toplardamarlar")
            {
                detail = "Ana toplardamarlar, kalbe giren kanı taşıyan büyük damarlardır. Sağ ana toplardamar (vena cava superior) vücudun üst kısmından, sol ana toplardamar (vena cava inferior) ise alt kısmından gelen kanı kalbe taşır.";
            }
            else if (kalpPart == "Sağ Karıncık")
            {
                detail = "Sağ karıncık, kalbin alt sağ kısmında yer alan odacıktır. Akciğerlere giden kanı akciğer atardamarına pompalar.";
            }
            else if (kalpPart == "Aort")
            {
                detail = "Aort, kalpten çıkan büyük atardamardır. Oksijenli kanı vücuda taşır ve vücudun tüm bölgelerine kan pompalar.";
            }
            else if (kalpPart == "Akciğer Atardamarı")
            {
                detail = "Akciğer atardamarı, akciğerlerden gelen oksijenli kanı kalbe taşıyan damardır.";
            }
            else if (kalpPart == "Sol Kulakçık")
            {
                detail = "Sol kulakçık, kalbin üst kısmında yer alan odacıktır. Akciğerlerden gelen oksijenli kanı sol karıncığa pompalar.";
            }
            else if (kalpPart == "Akciğer Toplardamarları")
            {
                detail = "Akciğer toplardamarları, akciğerlerden gelen oksijenli kanı kalbe taşıyan damarlardır.";
            }
            else if (kalpPart == "İkili Kapak")
            {
                detail = "İkili kapak, sağ kulakçık ile sağ karıncık arasında ve sol kulakçık ile sol karıncık arasında bulunan kapaktır. Kanın geriye akışını önler ve kalbin düzenli çalışmasını sağlar.";
            }
            else if (kalpPart == "Sol Karıncık")
            {
                detail = "Sol karıncık, kalbin alt sol kısmında yer alan odacıktır. Vücuda giden oksijenli kanı aorta pompalar. Sol karıncık, vücuda giden kanı en yüksek basınçla pompalar ve vücuda dağıtır.";
            }

            MessageBox.Show(detail, "Kalp Detayları - " + kalpPart);
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}

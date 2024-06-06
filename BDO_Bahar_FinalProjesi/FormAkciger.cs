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
    public partial class FormAkciger : Form
    {
        public FormAkciger()
        {
            InitializeComponent();
        }

        private void FormAkciger_Load(object sender, EventArgs e)
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
                string akcigerPart = SelectedLabel.Text;
                ShowAkcigerPart(akcigerPart);
            }
        }
        private void ShowAkcigerPart(string akcigerPart)
        {
            string details = "";

            if (akcigerPart == "Trakea")
            {
                details = "Trakea, soluk borusu olarak da bilinir. Bu yapı, soluk borusunun hava akışını sağlamak için tasarlanmıştır.";
            }
            else if (akcigerPart == "Sol ve Sağ Ana Bronşlar")
            {
                details = "Sol ve sağ ana bronşlar, trakeanın bölünmesiyle oluşan büyük hava yollarıdır. Akciğerlere hava taşımakla görevlidirler.";
            }
            else if (akcigerPart == "Bronş")
            {
                details = "Bronşlar, sol ve sağ ana bronşların daha küçük dallarıdır. Bunlar akciğerlerin içine giren havayı taşır.";
            }
            else if (akcigerPart == "Bronşiol")
            {
                details = "Bronşiyoller, bronşların daha küçük dallarıdır. Akciğerlerin içine giren havayı alveollere taşırlar.";
            }
            else if (akcigerPart == "Alveoller")
            {
                details = "Alveoller, akciğerlerin en küçük hava kesecikleridir. Burada gaz değişimi gerçekleşir; oksijen kana geçer ve karbondioksit havaya.";
            }
            else if (akcigerPart == "Diafram")
            {
                details = "Diafram, göğüs boşluğunu karın boşluğundan ayıran kaslı bir yapıdır. Solunum sırasında kasılıp gevşeyerek akciğerlere hava çekilmesini ve havanın dışarı verilmesini sağlar.";
            }

            MessageBox.Show(details, "Akciğer Detayları - " + akcigerPart);
        }

    }
}

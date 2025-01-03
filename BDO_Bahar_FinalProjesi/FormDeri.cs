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
    public partial class FormDeri : Form
    {
        public FormDeri()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormDeri_Load);
        }

        private void FormDeri_Load(object sender, EventArgs e)
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
            label15.Click += Label_Click;
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                string deriPart = selectedLabel.Text;
                ShowDeriPartDetails(deriPart);
            }


        }
        private void ShowDeriPartDetails(string deriPart)
        {
            string details = " ";

            if(deriPart == "Epidermis")
            {
                details = "Yerleşim: Derinin en üst katmanıdır.\r\nFonksiyon: Vücudu dış etkenlere karşı korur, su geçirmezlik sağlar ve enfeksiyonlara karşı bir bariyer oluşturur.\r\nYapı: Ölü keratinize hücrelerden oluşan çok katmanlı epitel dokudur";
            }
            else if(deriPart == "Derma")
            {
                details = "Yerleşim: Epidermisin hemen altındaki katmandır.\r\nFonksiyon: Destek ve besleme sağlar, esneklik ve dayanıklılık kazandırır.\r\nYapı: Bağ dokusundan oluşur, kollajen ve elastin lifler içerir, kan damarları, sinirler, kıl folikülleri ve bezler bulunur.";
            }
            else if (deriPart == "Hypodermis")
            {
                details = "Yerleşim: Derma katmanının altında yer alır.\r\nFonksiyon: Vücudu ısı kaybına karşı izole eder, darbelerden korur ve enerji depolar.\r\nYapı: Gevşek bağ dokusu ve yağ hücrelerinden oluşur.";
            }
            else if (deriPart == "Muscle Layer")
            {
                details = "Muscle Layer (Kas Tabakası)\r\nYerleşim: Hipodermisin altında, deri altı dokularının derininde yer alır.\r\nFonksiyon: Vücut hareketlerini sağlar, pozisyonunu korur ve vücut ısısını düzenler.\r\nYapı: Kas liflerinden oluşur, iskelet kaslarını içerir ve bağ dokusu ile çevrelenmiştir.";
            }
            else if (deriPart == "Muscle")
            {
                details = "Muscle (Kas)\r\nYerleşim: Hipodermis ve kas tabakaları arasında bulunur.\r\nFonksiyon: Hareketi sağlar, vücut ısısını düzenler.\r\nYapı: Kas liflerinden oluşur.";
            }
            else if (deriPart == "Hair Bulb")
            {
                details = "Hair Bulb (Kıl Soğanı)\r\nYerleşim: Kıl folikülünün en alt kısmında bulunur.\r\nFonksiyon: Kıl büyümesini sağlar.\r\nYapı: Hücrelerin hızla bölündüğü bir yapıdan oluşur, kıl kökünü içerir.";
            }
            else if (deriPart == "Pore")
            {
                details = "Pore (Gözenek)\r\nYerleşim: Epidermisin yüzeyinde bulunur.\r\nFonksiyon: Terin ve sebumun (yağ) dışarı atılmasını sağlar.\r\nYapı: Epidermisin yüzeyine açılan küçük deliklerdir";
            }
            else if (deriPart == "Hair")
            {
                details = "Yerleşim: Vücudun hemen her yerinde epidermis tabakasında yer alır.\r\nFonksiyon: Isı kaybını önler, cildi korur ve duyu organı olarak işlev görür.\r\nYapı: Keratin proteinlerinden oluşur, kıl folikülünden çıkar.";
            }
            else if (deriPart == "Sweat Pore")
            {
                details = "Yerleşim: Epidermisin yüzeyinde bulunur.\r\nFonksiyon: Terin dışarı atılmasını sağlar, vücut ısısını düzenler.\r\nYapı: Epidermis yüzeyine açılan küçük deliklerdir, ter bezleri ile bağlantılıdır.";
            }
            else if (deriPart == "Vein")
            {
                details = "Yerleşim: Dermis ve hipodermis tabakalarında bulunur.\r\nFonksiyon: Karbon dioksit ve atık maddeleri taşıyan kanı kalbe geri götürür.\r\nYapı: İnce kas ve bağ dokusu tabakalarından oluşur, kapakçıklara sahiptir.";
            }
            else if (deriPart == "Sebaceous Gland")
            {
                details = "Sebaceous Gland (Yağ Bezi)\r\nYerleşim: Kıl foliküllerine bağlı olarak dermis tabakasında bulunur.\r\nFonksiyon: Sebum üretir, cildi ve saçı nemlendirir ve korur.\r\nYapı: Salgı yapan hücrelerden oluşur, kıl foliküllerine açılır.";
            }
            else if (deriPart == "Sweat Gland")
            {
                details = "Sweat Gland (Ter Bezi)\r\nYerleşim: Derinin dermis tabakasında bulunur.\r\nFonksiyon: Ter üretir, vücut ısısını düzenler ve toksinlerin atılmasına yardımcı olur.\r\nYapı: Spiral yapıda tübüler bezlerdir.";
            }
            else if (deriPart == "Nerve")
            {
                details = "Yerleşim: Derinin dermis ve hipodermis tabakalarında yaygındır.\r\nFonksiyon: Duyu alır ve beyine iletir, motor fonksiyonları düzenler.\r\nYapı: Sinir liflerinden oluşur, duyu reseptörleri içerir.";
            }
            else if (deriPart == "Artery")
            {
                details = "Artery (Atardamar)\r\nYerleşim: Dermis ve hipodermis tabakalarında bulunur.\r\nFonksiyon: Oksijenli kanı dokulara taşır.\r\nYapı: Kalın kas ve bağ dokusu tabakalarından oluşur";
            }
            else if (deriPart == "Adipose Tissue")
            {
                details = "Adipose Tissue (Yağ Dokusu)\r\nYerleşim: Hipodermis tabakasında yoğun olarak bulunur.\r\nFonksiyon: Enerji depolar, ısı yalıtımı sağlar ve mekanik darbelere karşı koruma sağlar.\r\nYapı: Yağ hücrelerinden (adipositler) oluşur.";
            }
            else
            {
                details = "Belirtilen burun bölümü hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Deri Bölümleri Detayları");

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

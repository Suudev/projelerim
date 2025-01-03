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
    public partial class FormMide : Form
    {
        public FormMide()
        {
            InitializeComponent();
        }

        private void FormMide_Load(object sender, EventArgs e)
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
            label10.Click += Label1_Click;
            label11.Click += Label1_Click;

        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Label SelectedLabel = sender as Label;
            if (SelectedLabel != null)
            {
                string midePart = SelectedLabel.Text;
                ShowMidePart(midePart);
            }
        }
        private void ShowMidePart(string midePart)
        {
            string details = " ";
            if (midePart == "Fundus")
            {
                details = "Hareketli ve genişlemeye müsait, midenin en üst kısmıdır. Üstünde diyafram, solunda dalak bulunur. Fundusun alt kenarı, gastroözofagiel bileşke (GE junction) hizasındadır. Buradan sonra korpus başlar.";
            }
            if (midePart == "Mide Duvarlarını Oluşturan\r\n Kas Tabakaları")
            {
                details = "Mide duvarlarını oluşturan kas tabakaları, sindirim sisteminin önemli bir parçası olan midenin yapısını destekler ve işlevini yerine getirmesine yardımcı olur.Kas tabakası, mide duvarının en kalın tabakasıdır ve mide hareketlerini sağlar. Üç farklı tabakadan oluşur: uzunlamasına, dairesel ve çapraz kaslar. Bu kaslar, mide içeriğini karıştırmak ve sindirim sürecini kolaylaştırmak için peristaltik hareketler gerçekleştirir.";
            }
            if (midePart == "Korpus")
            {
                details = "Mide korpus bölümü, midenin ana gövde kısmını oluşturan ve genellikle gövdenin orta kısmında bulunan bir anatomik yapıdır. Korpus, mide bezlerinin bulunduğu ve sindirim enzimlerinin üretildiği önemli bir bölgedir. Bu bölüm, mide suyunun üretildiği ve mide asidinin salınımının gerçekleştiği yerdir. Ayrıca, korpus bölümü, besinlerin mekanik olarak karıştırıldığı ve sindirildiği önemli bir noktadır. Midenin bu kısmı, mukozal katmanı sayesinde asit ve mukus üretimi arasında dengeli bir ortam sağlar. Sindirim sürecinde kritik bir rol oynayan korpus bölümü, sindirim sisteminin sağlıklı işleyişi için hayati öneme sahiptir.";
            }
            if (midePart == "Büyük Kurvatur")
            {
                details = "Midedeki büyük kurvatur bölümü, mide duvarının dış yüzeyinde bulunan ve mideyi diğer organlarla ilişkilendiren önemli bir anatomik yapıdır. Bu bölüm, mide duvarının genellikle kavisli ve büyük olan dış kenarını ifade eder. Büyük kurvatur, mide içeriğinin hareketini ve sindirim sürecini yönlendiren önemli kas tabakalarını içerir. Sindirilmiş besinlerin depolanması ve karıştırılması gibi işlevleri yerine getirmek için peristaltik hareketlerin gerçekleştiği bir alan olarak bilinir. Ayrıca, büyük kurvatur bölgesi, mideyi diğer komşu organlarla bağlayan bağ dokusundan oluşur ve mide hareketlerinin düzenlenmesine yardımcı olur. Bu bölge, sindirim sisteminin işlevselliği için kritik bir rol oynar ve sindirim sürecinin düzenlenmesine katkı sağlar.";
            }
            if (midePart == "Midenin Mukoza Kıvrımları")
            {
                details = "Midenin mukoza kıvrımları, sindirim sisteminin önemli bir parçası olan mide duvarının iç yüzeyini kaplayan ve sindirim sürecini destekleyen belirgin yapısal özelliklerdir. Bu kıvrımlar, mide iç yüzeyini artırarak emilim ve sindirim süreçlerini optimize eder. Mukoza kıvrımları, vücudun besinlerle temasını artırarak sindirim enzimlerinin ve asitlerinin besinlere etkili bir şekilde ulaşmasını sağlar. Ayrıca, bu kıvrımlar mide içeriğinin karışmasını artırarak besinlerin daha homojen bir şekilde sindirilmesine yardımcı olur. Mukoza kıvrımları, mide duvarının iç yüzeyini korurken aynı zamanda besinlerin geçişini kontrol eder. Bu yapısal özellikler, mide fonksiyonlarının düzenlenmesinde ve sindirim sürecinin etkin bir şekilde gerçekleşmesinde önemli bir rol oynar.";

            }
            if (midePart == "Pilor")
            {
                details = "Midedeki pilor, mide ile onikiparmak bağırsağı arasında yer alan ve sindirim sürecinde önemli bir rol oynayan bir yapıdır. Anatomik olarak, pilor mide çıkışını kontrol eden bir kaslı kapaktır. Besinlerin mideye girişini ve mide asidinin onikiparmak bağırsağına geçişini düzenler. Pilor kasılmaları, mide içeriğinin onikiparmak bağırsağına kontrollü bir şekilde bırakılmasını sağlar, bu da sindirim sürecinin düzenlenmesine yardımcı olur. Ayrıca, pilor, mide içeriğinin geriye doğru onikiparmak bağırsağına kaçmasını engeller, bu da sindirim sisteminin işlevselliği için önemlidir. Pilorun bu regülatör rolü, besinlerin sindirilmesi ve emilim sürecinin etkili bir şekilde gerçekleşmesini sağlar.";
            }
            if (midePart == "Pilor Kanalı")
            {
                details = "Midedeki pilor kanalı, mide ile onikiparmak bağırsağı arasındaki geçiş bölgesini oluşturan önemli bir yapıdır. Bu kanal, mide pilorunun alt kısmından başlar ve onikiparmak bağırsağının ilk kısmına kadar uzanır. Pilor kanalı, mide içeriğinin sindirilmiş besinlerinin onikiparmak bağırsağına geçişini düzenler. Besinlerin mideyi terk etmesini kontrol ederken aynı zamanda sindirim sürecinin devamını sağlar. Pilor kanalı, kasların koordineli kasılmasıyla açılıp kapanabilir. Besinlerin sindirim sürecinin uygun hızda gerçekleşmesini sağlamak için bu kasılma ve gevşeme dengesi kritiktir.";
            }
            if (midePart == "Pilor\r\nSfinkteri")
            {
                details = "Midedeki pilor sfinkteri, mide ve onikiparmak bağırsağı arasında yer alan bir kas yapısıdır ve sindirim sürecinde önemli bir rol oynar. Bu sfinkter, mide pilorunun altında bulunur ve mide içeriğinin onikiparmak bağırsağına geçişini kontrol eder. Normalde, pilor sfinkteri sıkıca kapalıdır ve mide içeriğinin onikiparmak bağırsağına geçişini engeller. Ancak, sindirim sürecinin belirli aşamalarında, mide içeriğinin onikiparmak bağırsağına aktarılması gerektiğinde, pilor sfinkteri gevşer ve içeriğin geçişine izin verir. Bu, sindirim sürecinin düzenlenmesinde kritik bir rol oynar ve besinlerin sindirilmesi ve emilim sürecinin sağlıklı bir şekilde gerçekleşmesini sağlar. Ayrıca, pilor sfinkteri, mide içeriğinin onikiparmak bağırsağına geri kaçmasını önler, sindirim sisteminin işlevselliği için önemli bir koruyucu mekanizmadır.";
            }
            if (midePart == "Küçük \r\nKurvatur")
            {
                details = "Mide anatomisinde, mide duvarının iç yüzeyinde bulunan ve mide boşluğuna doğru kavisli olan kısmına \"küçük kurvatur\" denir. Küçük kurvatur, mide duvarının iç kısmında yer aldığı için mide içeriğine daha yakın bir konumdadır. Bu bölge genellikle mide asidinin ve sindirim enzimlerinin salgılandığı ve sindirim sürecinin gerçekleştiği yerdir. Aynı zamanda, besinlerin mide boşluğunda karıştırıldığı ve önceden sindirilmeye hazırlanıldığı bir alan olarak da bilinir. ";
            }
            if (midePart == "Kardia")
            {
                details = "Kardia, mide anatomisindeki önemli bir yapıdır ve sindirim sisteminin işlevselliğini sağlayan temel bir unsurdur. Anatomik olarak mide fundusunun altında yer alır ve gastroözofageal geçişin bir parçası olarak görev yapar. Kardia, mide ile yemek borusunun birleşim noktasını oluşturur ve bu noktada yer alan sfinkter mekanizması, mide içeriğinin geri kaçmasını engeller. Bu sfinkter mekanizması, mide asidinin ve sindirim enzimlerinin yemek borusuna reflü yapmasını önleyerek, gastrik içeriğin sindirim kanalı boyunca doğru yönde ilerlemesini sağlar. Kardia, gastroözofageal reflü hastalığı gibi durumların önlenmesinde kritik bir rol oynar ve sindirim sisteminin sağlıklı işleyişini korur. Bu nedenle, kardianın anatomik ve fizyolojik özelliklerinin anlaşılması, sindirim sistemi hastalıklarının tanı ve tedavisinde önemli bir yere sahiptir.";
            }
            if (midePart == "Yemek Borusu")
            {
                details = "Yemek borusu veya özofagus, faringeal geçiş bölgesinden başlayarak karın boşluğunda yer alan bir tüp şeklindeki yapıdır. Stratifike yassı epitel hücrelerinden oluşan mukozası, yutma işlemi sırasında mekanik ve kimyasal travmalara karşı koruyucu bir bariyer sağlar. Peristaltik hareketler ve sfinkter mekanizmaları, yemek borusunun içeriğini mideye doğru iterek sindirim sürecine katkıda bulunurken, aynı zamanda geri kaçmayı önler. Yemek borusunun mukozal tabakasının altında yer alan submukozal tabaka, kan damarları ve lenfatik damarlar gibi yapısal destek sağlar. Ayrıca, yemek borusu çevresindeki sinir ağı, yutma reflekslerinin düzenlenmesinde önemli rol oynar. Yemek borusu, gastrointestinal sistemdeki diğer yapılarla koordineli bir şekilde çalışarak sindirim işlevinin sağlıklı bir şekilde gerçekleştirilmesini sağlar.";
            }
            MessageBox.Show(details, "Mide Bölümleri");
        }

        

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

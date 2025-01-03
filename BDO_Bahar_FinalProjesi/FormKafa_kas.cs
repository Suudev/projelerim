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
    public partial class FormKafa_kas : Form
    {
        public FormKafa_kas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormKafa_kas_Load(object sender, EventArgs e)
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
            if (SelectedLabel != null)
            {
                string KafaKasPart = SelectedLabel.Text;
                ShowKafaKasPart(KafaKasPart);
            }
        }
        private void ShowKafaKasPart(string KafaKasPart)
        {
            string details = " ";
            if (KafaKasPart == "Orbicularis Oculi")
            {
                details = "Orbicularis Oculi, göz çevresinde bulunan ve göz kapağının açılması ve kapanmasını sağlayan bir yüz kasıdır. Latince adı \"musculus orbicularis oculi\" olan bu kas, göz kapağının çevresini saran halka şeklindeki kas liflerinden oluşur. Anatomik olarak, göz kapağının derisi ve altında bulunan orbiküleris oculi kası arasında bir bağlantı sağlar. Göz kapağının kapanması sırasında bu kasın kontraksiyonuyla gözler korunur ve dış etkenlere karşı bir savunma mekanizması oluşturulur. Ayrıca, göz kırpması sırasında gözyaşı bezlerinin göz yüzeyine göz yaşını yaymasına yardımcı olur, böylece gözün nemli kalmasını sağlar ve gözlerin kurumasını engeller. Bununla birlikte, bu kasın kontrolsüz kasılmaları veya spazmları, blefarospazm adı verilen bir duruma neden olabilir, bu da göz kapağının istemsiz olarak kapanmasına yol açabilir ve görsel işlevler üzerinde olumsuz etkilere sahip olabilir.";
            }
            else if (KafaKasPart == "Orbicularis Oris")
            {
                details = "Orbicularis Oris, ağız çevresinde bulunan ve dudakların kapanmasını sağlayan bir yüz kasıdır. Latince adı \"musculus orbicularis oris\" olan bu kas, dudakların etrafında halka şeklinde bir yapı oluşturur ve dudakların şeklini ve pozisyonunu kontrol eder. Ayrıca, konuşma ve yüz ifadelerinin oluşumunda önemli bir role sahiptir. Orbicularis Oris, dudakların kapanması, öpücük gönderme gibi işlevlerin yanı sıra, yiyeceklerin ağızdan içeri alınması ve emilmesi süreçlerinde de etkilidir. Ayrıca, bu kasın kontraksiyonuyla dudaklar şekil alır ve çeşitli mimikler oluşturulur. Yüz ifadelerinin ve duyguların iletilmesinde önemli bir rol oynar. Bu kasın zayıf veya kontrolsüz kontraksiyonları, dudakların istemsiz hareketlerine veya düzensiz bir dudak kapanmasına yol açabilir, bu da konuşma ve yeme işlevlerini etkileyebilir. Orbicularis Oris kasının etkili bir şekilde çalışması, sağlıklı bir yüz ifadesi ve dudak fonksiyonu için önemlidir.";
            }
            else if (KafaKasPart == "Temporalis")
            {
                details = "Temporal kas olarak da bilinen musculus temporalis, çiğneme kaslarından biridir. İnsanlarda, başın her iki yanında geniş, yelpaze şeklinde yakınsak bir kas olup, fossa temporalis'i doldurur ve temporal kemiğin çoğunu kaplar. \"Temporal\" ifadesi, şakak bölgesini ifade etmektedir. Bu kas, çiğneme işlemi sırasında çene hareketlerini kontrol eder ve çenenin kafaya doğru hareket etmesini sağlar. Ayrıca, çiğneme sırasında çene hareketlerini optimize ederek, yiyeceklerin etkili bir şekilde parçalanmasını sağlar.\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (KafaKasPart == "Zygomaticus")
            {
                details = "Zygomaticus, yüz kasları arasında yer alan ve özellikle gülümseme gibi pozitif duygusal ifadelerin oluşumunda kritik bir rol oynayan bir kas grubudur. Latince adı \"musculus zygomaticus\" olan bu kas, yanaklardan ağız kenarlarına uzanır ve dudakların yukarı kalkmasını ve yanakların yukarı doğru çekilmesini sağlayarak gülümsemeyi destekler. Bu kasın aktivitesi, duygusal durumun ifadesinde ve sosyal etkileşimlerde önemli bir rol oynar. Ancak, zygomaticus kasının zayıf veya kontrolsüz kasılmaları, yüz ifadelerinde asimetriye veya düzensizliklere neden olabilir, bu da doğru iletişimi engelleyebilir ve sosyal etkileşimlerde uygun yanıt verme yeteneğini etkileyebilir. Bu nedenle, zygomaticus kasının sağlıklı işlevi, duygusal ifadelerin doğru bir şekilde iletilmesi ve sosyal etkileşimlerde uygun şekilde yanıt verilmesi açısından kritik öneme sahiptir.\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (KafaKasPart == "Masseter")
            {
                details = "Masseter kası, çiğneme fonksiyonunun temel kası olup, çene hareketlerini kontrol eden önemli bir yüz kasıdır. Anatomik olarak, çene ekleminin ön kısmından başlayıp çene kemiği üzerinde ve çene köşesine kadar uzanır. Bu kas, çene ekleminin stabilitesini sağlar ve çene hareketlerini koordine eder. Çiğneme sırasında aktif bir rol oynar, alt çene kemiğini yukarıya ve öne doğru çeken hareketler gerçekleştirir ve yiyeceklerin etkili bir şekilde parçalanmasını sağlar. Masseter kasının sağlıklı işlevi, çiğneme fonksiyonunun korunması ve çene sağlığının sürdürülmesi açısından hayati öneme sahiptir. Ancak, bu kasın disfonksiyonu veya aşırı kasılmaları, çene hareketlerinde kısıtlamalara, çene ekleminde ağrıya ve çiğneme güçlüğüne neden olabilir, bu da kişinin yaşam kalitesini olumsuz etkileyebilir.";
            }
            else if (KafaKasPart == "Buccinator")
            {
                details = "Buccinator kası, yüz anatomisinde önemli bir kas olup, yanakların iç kısmında bulunur ve ağız hareketlerini kontrol eder. Latince adı \"musculus buccinator\" olan bu kas, yanakların şişirilmesi ve içindeki yiyeceklerin dil ve dişlere doğru itilmesi gibi fonksiyonlarda önemli rol oynar. Ayrıca, bu kas yüz ifadelerini oluştururken yanakların pozisyonunu ayarlar. Buccinator kası, konuşma ve yutma gibi temel fonksiyonlarda yardımcı olurken, çiğneme sırasında yiyeceklerin doğru yönde hareket etmesini sağlayarak sindirim sürecine katkıda bulunur. Bu kasın sağlıklı işlevi, ağız ve çevresindeki yapıların uygun hareketini ve işlevselliğini sağlar, ancak disfonksiyonu veya zayıf kasılmaları, yutma güçlüğü, konuşma problemleri ve yanakların düzensiz hareketleri gibi sorunlara yol açabilir.";
            }
            else if (KafaKasPart == "Sternocleidomastoid")
            {
                details = "Sternocleidomastoid kası, boyun anatomisinde bulunan ve birçok önemli fonksiyonu olan bir kas olup, latince adı \"musculus sternocleidomastoideus\" dur. Başın yan hareketlerini ve dönmesini sağlar, başın eğilmesini kolaylaştırır ve boyun kaslarının stabilitesini sağlar. Boyundaki yaralanmalarda ve boyun omurgasında meydana gelen patolojilerde, sternocleidomastoid kasının tutulumu sıkça gözlemlenir. Bu kasın fonksiyonlarının yanı sıra, klinik muayenede boyun hareketliliğinin değerlendirilmesinde ve boyun bölgesindeki sorunların tanısında önemli bir işlevi vardır. Ayrıca, sternocleidomastoid kasının disfonksiyonu, tortikolis gibi durumlara yol açabilir, bu da başın anormal bir pozisyonda sabitlenmesine ve boyun hareketlerinin kısıtlanmasına neden olabilir. Bu nedenle, sternocleidomastoid kasının sağlıklı işlevi, boyun hareketliliğinin ve postürünün korunması için kritik öneme sahiptir.";
            }
            else
            {
                details = "bu bölümle ilgili bilgi mevcut değil";
            }
            MessageBox.Show(details, "Kafa Bölümündeki Kaslar");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

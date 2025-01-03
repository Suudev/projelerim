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
    public partial class FormKol_kas : Form
    {
        public FormKol_kas()
        {
            InitializeComponent();
        }

        private void FormKol_kas_Load(object sender, EventArgs e)
        {
            label1.Click += Label1_Click;
            label2.Click += Label1_Click;
            label3.Click += Label1_Click;
            label4.Click += Label1_Click;
            label5.Click += Label1_Click;
            label6.Click += Label1_Click;
            label7.Click += Label1_Click;
            label8.Click += Label1_Click;
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Label SelectedLabel = sender as Label;
            if (SelectedLabel != null)
            {
                string KolKasPart = SelectedLabel.Text;
                ShowKolKasPart(KolKasPart);
            }
        }
        private void ShowKolKasPart(string KolKasPart)
        {
            string details = "";
            if (KolKasPart == "Extensor Digiti Minimi")
            {
                details = "Extensor Digiti Minimi, Latince adıyla \"musculus extensor digiti minimi\", el anatomisinde bulunan ve küçük parmağın uzatılmasını sağlayan bir kas olarak bilinir. Bu kas, ön kolun arka kısmında yer alır ve başparmağın uzatılmasını sağlayan diğer kaslarla birlikte çalışarak elin hareketlerini koordine eder. Anatomik olarak, ekstensor digiti minimi, üç farklı başlangıç noktasına sahiptir: biri üst kol kemiğinin (humerus) arka yüzeyinden, diğeri dirsek kemiğinin (radius) arka kenarından ve sonuncusu da dirseğin bağlandığı kemik (ulna) arka kenarından başlar. Bu başlangıç noktalarından kas lifleri, küçük parmağın uzatılmasını sağlayan tendonlara bağlanır. Fonksiyonel olarak, extensor digiti minimi kası, küçük parmağın metakarpofalangeal ve interfalangeal eklemlerini uzatır ve bu sayede parmağın hareketliliğini artırır. Bu kasın sağlıklı işlevi, elin normal hareketliliğinin korunması ve küçük parmağın fonksiyonlarının sağlıklı bir şekilde gerçekleştirilmesi için kritik öneme sahiptir. Extensor digiti minimi kasının disfonksiyonu veya yaralanması, küçük parmak hareketlerinde kısıtlamalara ve güçsüzlüğe neden olabilir, bu da elin fonksiyonlarını etkileyebilir ve günlük yaşam aktivitelerini kısıtlayabilir. Bu nedenle, bu kasın anatomisi ve fonksiyonları, el cerrahisi ve rehabilitasyonunda önemli bir rol oynar.";
            }
            else if (KolKasPart == "extensor Carpi Ulnaris")
            {
                details = "El bileği ve ön kol anatomisinde bulunan extensor carpi ulnaris, önemli bir kas olup, Latince adı \"musculus extensor carpi ulnaris\" dir. Bu kas, ön kolun arka kısmında yer alır ve el bileği hareketlerini kontrol eder. Üst kol kemiği (humerus) ve dirsek kemiği (radius) arasında bulunan bir kas tabanından başlar ve el bileğinin dış tarafındaki bir kemik olan ulna'ya uzanır. Fonksiyonel olarak, extensor carpi ulnaris, el bileği tarafından abdüksiyon ve ekstansiyon hareketlerini gerçekleştirir, böylece el bileğinin dışa doğru bükülmesini ve parmakların yukarı kaldırılmasını sağlar. Bu kas aynı zamanda, el bileği hareketlerinde stabilizasyon sağlar. Extensor carpi ulnaris kasının sağlıklı işlevi, el bileği hareketlerinin koordinasyonu ve stabilize edilmesi için önemlidir. Kasın disfonksiyonu, el bileği hareketlerinde kısıtlamalara ve güçsüzlüğe yol açabilir, bu da günlük aktiviteleri etkileyebilir. Bu nedenle, extensor carpi ulnaris kasının anatomisi ve fonksiyonları, tıbbi açıdan önemlidir.";
            }
            else if (KolKasPart == "Extensor Digitorum")
            {
                details = "Extensor Digitorum, Latince adıyla \"musculus extensor digitorum\", ön kolun arka kısmında bulunan ve parmakların uzatılmasını sağlayan bir kas olarak bilinir. Bu kas, üst kol kemiğinin (humerus) arka yüzeyinden, dirsek kemiğinin (radius) arka kenarından ve dirseğin bağlandığı kemik (ulna) arka kenarından başlar. Parmaklara uzanan uzun tendonları aracılığıyla parmakların metakarpofalangeal ve interfalangeal eklemlerini uzatır. Fonksiyonel olarak, extensor digitorum, parmakların düzleşmesini ve uzamasını sağlar, bu sayede günlük yaşam aktivitelerinde önemli olan işlevlerin gerçekleşmesini sağlar. Aynı zamanda, bu kas, el bileği hareketlerini destekleyerek elin genel stabilitesine katkıda bulunur. Extensor digitorum kasının sağlıklı işlevi, elin normal hareketliliğinin korunması ve parmak fonksiyonlarının sağlıklı bir şekilde gerçekleştirilmesi için önemlidir. Kasın disfonksiyonu, parmak hareketlerinde kısıtlamalara ve güçsüzlüğe neden olabilir, bu da günlük aktiviteleri etkileyebilir. Bu nedenle, extensor digitorum kasının anatomisi ve fonksiyonları, tıbbi açıdan önemlidir.";
            }
            else if (KolKasPart == "Brachioradialis")
            {
                details = "Brachioradialis, Latince adıyla \"musculus brachioradialis\", ön kolun dış tarafında bulunan ve önemli bir kas olup, dirseğin dış kısmında yer alır. Üst kol kemiği (humerus) ve ön kol kemiği (radius) arasında yer alan bir kas tabanından başlar ve dirsek eklemine bağlanır. Bu kasın fonksiyonu, dirsek ekleminin fleksiyonu ve pronasyonu ile ilgilidir. Brachioradialis kası, dirsek fleksiyonu sırasında ön kolun dış yönünde bir kuvvet oluşturur ve bu sayede dirsek hareketlerinin kontrol edilmesine yardımcı olur. Ayrıca, bu kas, dirsek ekleminin pronasyonunda da rol oynar, yani elin dışa doğru dönmesine yardımcı olur. Brachioradialis kası, günlük yaşam aktiviteleri ve spor performansı için önemlidir. Kasın sağlıklı işlevi, dirsek hareketlerinin koordinasyonu ve stabilitesi için kritik öneme sahiptir.";
            }
            else if (KolKasPart == "Triceps Brachii")
            {
                details = "Triceps Brachii, Latince adıyla \"musculus triceps brachii\", üst kolun arka kısmında yer alan ve önemli bir kas olup, dirseği düzleştiren ve kolun uzatılmasını sağlayan üç kısmı olan bir kas grubunu ifade eder. Bu kas, üst kol kemiğinin (humerus) arka yüzeyinden ve dirsek kemiğinin (ulna) arka kenarından başlar. Triceps brachii, üç kısmı olan başları sayesinde dirsek ekleminin uzanmasına ve kolun düzeltilmesine yardımcı olur. Bu başlar; uzun kafa (caput longum), dış kafa (caput laterale), iç kafa (caput mediale) olarak adlandırılır. Fonksiyonel olarak, triceps brachii, dirseğin ekstansiyonu ve kolun düzeltilmesi işlevlerini yerine getirir. Ayrıca, bu kas, üst kolun stabilizasyonuna ve kol hareketlerinin kontrol edilmesine de yardımcı olur. Triceps brachii kası, günlük yaşam aktivitelerinde ve spor performansında önemli bir rol oynar. Kasın sağlıklı işlevi, kolun hareketliliğinin korunması ve güçlendirilmesinde önemli rol oynar. Triceps brachii kasının disfonksiyonu veya yaralanması, dirsek hareketlerinde kısıtlamalara, güçsüzlüğe ve ağrıya neden olabilir, bu da günlük aktiviteleri ve spor performansını etkileyebilir. Bu nedenle, triceps brachii kasının anatomisi ve fonksiyonları, tıbbi açıdan önemlidir.";
            }
            else if (KolKasPart == "Biceps Brachii")
            {
                details = "Biceps Brachii, Latince adıyla \"musculus biceps brachii\", ön kolun ön kısmında bulunan ve önemli bir kas olup, dirseği bükülmesini ve kolun kaldırılmasını sağlayan bir kas olarak bilinir. Üst kol kemiğinin (humerus) ön yüzeyinden başlar ve ön kol kemiğinin (radius) üzerindeki bir çıkıntıya, özellikle radiusun tuberositasına, bağlanır. Biceps brachii, iki kafaya (baş) sahiptir: uzun kafa (caput longum) ve kısa kafa (caput breve). Bu iki kafa, dirsek fleksiyonu, ön kol supinasyonu ve omuz fleksiyonu gibi hareketlerde sinerjik olarak çalışır. Fonksiyonel olarak, biceps brachii, dirseğin bükülmesi ve kola kuvvet uygulanması işlevlerini yerine getirir. Ayrıca, bu kas, ön kolun supinasyonu (dışa doğru dönmesi) hareketini destekler. Biceps brachii kası, günlük yaşam aktivitelerinde ve spor performansında önemli bir rol oynar. Kasın sağlıklı işlevi, kolun hareketliliğinin korunması ve güçlendirilmesi için kritik öneme sahiptir. ";
            }
            else if (KolKasPart == "Brachialis")
            {
                details = "Brachialis kası, insan vücudunun ön kolunda bulunan bir kas türüdür. Bu kas, üst kol kemiğinin (humerus) ön kısmından başlar ve ön kol kemiğinin (radius) çıkıntılı kısmına bağlanır. Brachialis kası, dirseğin bükülmesini sağlayan önemli bir rol oynar. Özellikle günlük yaşamda sıkça kullanılan hareketlerde, örneğin bir şey kaldırma veya taşıma sırasında, brachialis kası etkin bir şekilde çalışır. Bu kas, ön kolun hareketlerini güçlendirir ve stabilize eder. Brachialis kasının sağlıklı işlevi, dirsek hareketlerinin koordinasyonu ve güçlendirilmesi için kritik öneme sahiptir. Yaralanma veya disfonksiyon durumunda, dirsek hareketlerinde kısıtlamalara ve güçsüzlüğe neden olabilir.";
            }
            else if (KolKasPart == "Deltoid")
            {
                details = "Deltoid kası, insan vücudunda omuz bölgesinde bulunan ve omuzu çevreleyen üç parçalı bir kas grubunu ifade eder. Bu kas, üst kol kemiğinin (humerus) dış kısmından başlar ve omuzun üst kısmında yer alan omuz kemikçiklerine (akromion ve köprücük kemiği) bağlanır. Deltoid kası, omzun hareketlerini sağlar ve kolların kaldırılması, yan kollara hareket ettirilmesi ve döndürülmesi gibi bir dizi hareketten sorumludur. Ayrıca, deltoid kası, omuz eklemine stabilite sağlar ve omuzun şeklini korur. ";
            }
            else
            {
                details = "Böyle Bir Bölüm Bulunmamakta";
            }

            MessageBox.Show(details, "Kol Bölümündeki Kaslar");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

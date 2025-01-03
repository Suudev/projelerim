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
    public partial class FormBobrek : Form
    {
        public FormBobrek()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormBobrek_Load);
        }

        private void FormBobrek_Load(object sender, EventArgs e)
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
                string bobrekPart = SelectedLabel.Text;
                ShowBobrekPart(bobrekPart);
            }
        }
        private void ShowBobrekPart(string bobrekPart)
        {
            string details = " ";
            if (bobrekPart == "Kabuk")
            {
                details = "Kabuk bölgesi, bezin yaşamsal önem taşıyan katmanıdır. Bu yapıdan hipofiz bezinden salgılanan adenokortikotropik hormon (ACTH) hormonunun etkisiyle başta kortizol olmak üzere çok sayıda hormon salgılanır. Kortizol salgılanma düzeni gün içinde gösterdiği değişiklikler açısından ilginç bir özellik taşır. Gün boyunca değişen derişimlerle kana salgılanan kortizol, akşam sıralarında ve uykuya dalıştan hemen sonraki saatlerde en az düzeydeyken, sabah kalkmadan önceki saatlerde ise en yüksek düzeydedir. Böbrek üstü bezlerinden salgılanan öteki kabuk hormonları da kortizole benzer değişiklikler gösterir. Bu değişkenliğin nedeni, hipotalamustaki CRH salgılanmasına bağlı olan ACTH salgılanımının, aydınlık/karanlık döngüsüne ilişkin bilginin retinadan hipotalamusta bulunan çifte çekirdeklere (suprachiasmatic nuclei) iletilmesine bağlı olmasıdır. Ön görülebileceği gibi, koma, körlük ya da sürekli ışığa ya da karanlığa maruz kalma durumlarında bu değişkenlik de ortadan kalkar.";
            }
            else if (bobrekPart == "Nefron")
            {
                details = "Nefron, böbreğin en küçük yapısal birimidir. Nefron, böbrekte idrarın yapıldığı morfolojik üniteyi oluşturur. Bir böbrekteki nefron sayısı 1-2 milyon arasındadır. Nefronlar ortak açılma kanalları ile böbrek papillaları üzerindeki deliklere açılırlar. Böylece oluşan idrar ilk olarak kalikslerde ve dolayısıyla havuzcukta biriktirilmiş olur. Sağ ve sol böbreklere gelen günlük kan akımı 1,5 tonu bulur. Nefronlarda gerçekleşen süzme (filtrasyon), salgılama (sekresyon) ve geri emilme (reabsorpsiyon) aşamalarından sonra idrar şeklinde atılan miktar 1,5 litre kadardır. Ayrıca içindeki süzücü kanallar kanı temizlemekte yardımcıdır. Bir nefronda; Bowman kapsülü, glomerulusa kan getiren afferent damar, glomerulustan kanı uzaklaştıran efferent damar, glomerulus ve tübüller bulunmaktadır.";
            }

            else if (bobrekPart == "Öz")
            {
                details = "Böbrek üstü bezlerinin öz katmanı, özerk sinir sisteminin sempatik bölümünün bir sinir düğümüdür (ganglion). Sinir düğümü öncesi nöronların gövdeleri omuriliğin göğüs bölgesinde bulunmaktadır. Bu nöronların aksonları büyük splanknik sinirden geçerek böbrek üstü bezinin öz bölgesine ulaşıp ve kromafin hücrelerle sinir bağlantısı yaparak asetilkolin salgılarlar. Asetilkolin, sinir düğümü sonrasındaki nöronların nikotinik reseptörlerini etkinleştirir. Kromafin hücreler bunun üzerine dolaşıma adrenalin (epinefrin) ve noradrenalin (norepinefrin) salgılar. Sinir düğümü sonrasındaki nöronlar genellikle noradrenalin salgılarken, böbrek üstü bezlerinin öz bölgesi çoğunlukla (%80) adrenalin ve ancak %20 oranında noradrenalin salgılar. Bunun nedeni, öz bölgede feniletanolamin-N-metiltransferaz (PNMT) enziminin bulunması ve bu enzimin sempatik sinir düğümü sonrası nöronlarda bulunmamasıdır (bu enzim noradrenalini adrenaline dönüştüren kimyasal tepkimeyi tetikler). Noradrenalinden adrenalin sentezini sağlayan kortizoldür. Kabuk bölgesinde sentezlenen kortizol, bu bölgeden ayrılan toplar damarlar aracılığıyla öz bölgeye ulaşır ve bu tepkimeyi tetikler.";
            }

            else if (bobrekPart == "Böbrek Atar Damarı")
            {
                details = "Böbrek atardamarı (renal arter), aorta'nın alt kısmından doğar ve böbrek kapısına (hilus) doğru ilerler. Böbrek kapısına ulaştığında, renal arter böbreğe girer ve arterial ağaç yapısına dallanır. Burada, ana renal arterden ayrılan üç büyük dal vardır: superior, inferior ve anterior segmental arterler. Bu arterler böbreğin içine doğru dallanarak renal korteks ve medulla'ya kan sağlar. Daha küçük arterler, kortikal ve medüller arteriyollara ayrılır. Son olarak, arteriyoller glomerulusları besleyen ve nefronların işlevlerine katkıda bulunan afferent arteriyollara dönüşür.";
            }

            else if (bobrekPart == "Böbrek Toplar Damarı")
            {
                details = "Böbrek toplar damarı (renal ven), böbrekten venöz kanı taşıyan ana damardır. İçerisindeki kan, böbrekten toplanan filtratı ve atıkları taşır ve inferior vena cava'ya boşalır. Böbrek toplar damarı, böbreğin arteriyel kan akışı ile benzer bir yol izler. Küçük toplar damarlar, kortikal ve medüller venüllere dönüşür. Bunlar daha sonra interlobar venlere dönüşür ve böbrek korteksini ve medullasını saran venöz ağaçlara katılır. Son olarak, bu venler renal venöz kaviteye (böbrek veni) dökülür.";
            }
            else if (bobrekPart == "Üreter")
            {
                details = "Üreterler (idrar borusu), insan anatomisinde, idrarı böbreklerden idrar torbasına taşır. Üreterler kaslı borulardır ve bu nedenle idrarı peristaltik hareketler ile ileri itebilirler. Böbreklerde biriken idrar bu kanallarla böbreklerden uzaklaştırılmış olur. Böbrek havuzundan ayrılan idrar, üreterler aracılığıyla karın üst bölümünden kasıklara doğru ilerleyip mesane içine boşalır. Yetişkinlerde, üreterler genellikle yaklaşık 26–28 cm boyunda olup yaklaşık 5 mm'lik çapa sahiptir. Üreter karın içine doğru ilerlerken üç farklı darlığa sahiptir: 1) böbrekten çıkış yeri, 2) karın orta bölümünde büyük damarı çaprazladığı yer, 3) mesane içine giriş yeri.";
            }


            MessageBox.Show(details, "Böbrek bölümleri");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

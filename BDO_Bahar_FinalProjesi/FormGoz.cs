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
    public partial class FormGoz : Form
    {
        public FormGoz()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormGoz_Load);
        }
        private void FormGoz_Load(object sender ,EventArgs e)
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
            label16.Click += Label_Click;
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                string eyePart = selectedLabel.Text;
                ShowEyePartDetails(eyePart);
            }
        }
        private void ShowEyePartDetails(string eyePart)
        {
            string details = " ";

            if(eyePart == "Kirpiksi Yapı")
            {
                details = "Yerleşim: Kirpiksi bölge (corpus ciliare), gözün ön kısmında, iris ile retina arasında yer alır.\r\n\r\nYapı: Kirpiksi bölge, kirpiksi cisim (corpus ciliare) ve kirpiksi kaslar (musculus ciliaris) olmak üzere iki ana yapıdan oluşur.\r\n\r\nKirpiksi Kaslar: Kirpiksi kaslar, göz merceğinin şeklini değiştirmek için kasılarak ve gevşeyerek odaklanmayı (akomodasyon) sağlar.\r\n\r\nKirpiksi Çıkıntılar: Kirpiksi cisim üzerinde, göz içi sıvısını (aköz hümör) üreten küçük çıkıntılar bulunur. Bu sıvı, göz içi basıncını düzenler ve gözün beslenmesini sağlar.\r\n\r\nLensin Asılması: Kirpiksi bölgedeki lifler (zonül lifleri), göz merceğini yerinde tutar ve lensin konumunu ayarlar.";
            }
            else if(eyePart == "Asıcı Bağlar")
            {
                details = "Yerleşim: Asıcı bağlar, kirpiksi cisimden (corpus ciliare) çıkar ve göz merceğine (lens) bağlanır.\r\n\r\nFonksiyon: Asıcı bağlar, lensi yerinde tutar ve kirpiksi kasların kasılmasıyla lensin şeklini değiştirir. Bu, gözün odaklanma yeteneğini (akomodasyon) sağlar.\r\n\r\nOdaklanma: Kirpiksi kaslar kasıldığında, asıcı bağlar gevşer ve lens daha küresel bir şekil alır, bu da yakın mesafedeki nesneleri net görmek için gereklidir. Kirpiksi kaslar gevşediğinde, asıcı bağlar gerilir ve lens daha düz bir şekil alır, bu da uzak mesafedeki nesneleri net görmek için gereklidir.\r\n\r\nYapı: Asıcı bağlar ince, esnek ve güçlü liflerden oluşur, bu da onların lensi güvenli bir şekilde yerinde tutmasını ve lensin şeklini etkin bir şekilde değiştirmesini sağlar.";
            }
            else if (eyePart =="Kornea")
            {
                details = "Yapı: Kornea, beş tabakadan oluşur:\r\n\r\nEpitel: Kornea yüzeyini kaplayan dış tabaka.\r\nBowman Tabakası: Epitelin altında bulunan ince ve güçlü bir tabaka.\r\nStroma: Kornea kalınlığının büyük bir kısmını oluşturan orta tabaka.\r\nDescemet Zarı: Stroma altında bulunan ince bir tabaka.\r\nEndotel: Kornea iç yüzeyini kaplayan tek hücre tabakası.\r\nŞeffaflık: Kornea, şeffaf ve damarsız bir yapıdadır, bu da ışığın doğrudan geçişini sağlar. Şeffaflığını korumak için özel bir hücresel yapı ve düzenleme vardır.\r\n\r\nKırıcılık: Kornea, gözün en güçlü kırıcı ortamıdır ve ışığın gözün içine doğru doğru bir şekilde odaklanmasına yardımcı olur. Bu, görme keskinliğinde önemli bir rol oynar.\r\n\r\nKoruma: Kornea, gözün iç yapısını dış etkenlerden (toz, mikroorganizmalar, kimyasallar) korur. Ayrıca, gözyaşı tabakasıyla birlikte nemli kalır ve bu da korneanın sağlığını ve işlevini sürdürmesine yardımcı olur.\r\n\r\nHassasiyet: Kornea, sinir uçları açısından zengin bir yapıya sahiptir, bu da onu çok hassas hale getirir. Bu hassasiyet, gözün herhangi bir yaralanma veya tahrişten korunmasına yardımcı olur. ";
            }
            else if (eyePart == "Göz Bebeği")
            {
                details = "Yerleşim: Göz bebeği, iris adı verilen renkli göz tabakasının ortasında yer alır.\r\n\r\nFonksiyon: Göz bebeği, gözün içine giren ışık miktarını kontrol eder. Bu, aydınlık ve karanlık ortamlarda net bir şekilde görmeyi sağlar.\r\n\r\nBüyüklük Ayarı: Göz bebeğinin büyüklüğü, irisin kasları tarafından kontrol edilir:\r\n\r\nMiyozis: Parlak ışıkta göz bebeği küçülür (büzülür) ve ışık miktarını azaltır.\r\nMidriyazis: Karanlıkta göz bebeği büyür (genişler) ve daha fazla ışık girmesini sağlar.\r\nRefleks: Göz bebeği ışık refleksi, beynin kontrolünde gerçekleşir. Işık göze girdiğinde, sinir sinyalleri beyne iletilir ve göz bebeğinin daralmasını sağlar. Bu refleks, gözün kendini koruma mekanizmalarından biridir. ";
            }
            else if (eyePart == "Humor Aqueaus")
            {
                details = "Yerleşim: Humor Aqueous, gözün ön segmentinde, ön ve arka kamaralarında bulunur.\r\n\r\nFonksiyon: Humor Aqueous, göz içi basıncını düzenler ve gözün şeklini korumasına yardımcı olur. Ayrıca, gözün iç yapılarının beslenmesini sağlar ve atık ürünlerin uzaklaştırılmasına yardımcı olur.\r\n\r\nÜretim ve Drenaj: Humor Aqueous sıvısı, kirpiksi cisimde üretilir ve Schlemm kanalı aracılığıyla drenaj edilir:\r\n\r\nÜretim: Kirpiksi cisimdeki hücreler tarafından sürekli olarak üretilir.\r\nDrenaj: Schlemm kanalı aracılığıyla gözden dışarı atılır, bu da göz içi basıncının dengede kalmasını sağlar.\r\nBeslenme: Humor Aqueous, damarsız yapıların ihtiyaç duyduğu oksijen ve besin maddelerini sağlar. Kornea ve lens gibi yapılar bu sıvıdan beslenir.\r\n\r\nSağlık ve Hastalık: Humor Aqueous sıvısının dengesiz üretimi veya drenajındaki sorunlar, glokom gibi ciddi göz hastalıklarına yol açabilir. ";
            }
            else if (eyePart == "Iris")
            {
                details = "Yerleşim: Iris, gözün ön kısmında, kornea ile lens arasında yer alır ve göz bebeğini çevreler.\r\n\r\nFonksiyon: Iris, gözün içine giren ışık miktarını kontrol eder. Bu, göz bebeğinin büyüklüğünü ayarlayarak yapılır ve aydınlık ile karanlık ortamlarda net görmeyi sağlar.\r\n\r\nRenk: Iris, gözün renkli kısmıdır ve melanin pigmentinin miktarına bağlı olarak farklı renklerde olabilir (mavi, yeşil, kahverengi vb.).\r\n\r\nKas Yapısı: Iris, iki ana kas grubundan oluşur:\r\n\r\nSfinkter Kasları: Parlak ışıkta kasılarak göz bebeğinin küçülmesini (miyozis) sağlar.\r\nDilatatör Kasları: Karanlıkta genişleyerek göz bebeğinin büyümesini (midriyazis) sağlar.\r\nIşık Refleksi: Iris, ışık refleksi ile göz bebeğinin anında daralmasını veya genişlemesini kontrol eder. Bu refleks, gözün kendini parlak ışıktan korumasını sağlar. ";
            }
            else if (eyePart == "Lens")
            {
                details = "Yerleşim: Lens, iris ve göz bebeğinin arkasında, vitreous humorun önünde yer alır.\r\n\r\nFonksiyon: Lens, ışığı kırarak retinaya odaklar ve net bir görüntü oluşturur. Bu, gözün farklı mesafelerdeki nesnelere odaklanmasını sağlar.\r\n\r\nEsneklik: Lens, yaşla birlikte esnekliğini kaybetse de, genç yaşlarda oldukça esnektir ve bu esneklik gözün odaklanma yeteneğini (akomodasyon) sağlar. Yakın nesnelere odaklanmak için kalınlaşır, uzak nesnelere odaklanmak için ise incelir.\r\n\r\nYapı: Lens, şeffaf ve avasküler (damarsız) bir yapıdır. Protein ve su içerir ve kapsül adı verilen ince bir zarla çevrilidir. İçindeki lifler düzenli bir şekilde dizilmiştir, bu da şeffaflığını sağlar.\r\n\r\nOdaklanma (Akomodasyon): Kirpiksi kaslar lensin şeklini değiştirerek odaklanmayı sağlar. Kaslar kasıldığında lens kalınlaşır ve yakın nesneler net görülür. Kaslar gevşediğinde lens incelir ve uzak nesneler net görülür.\r\n\r\nSağlık ve Hastalık: Lensin bulanıklaşması katarakt olarak bilinir ve görme kaybına yol açabilir. Katarakt, genellikle yaşlanma ile ilişkilidir ancak travma, bazı hastalıklar veya genetik faktörlerle de ortaya çıkabilir. ";
            }
            else if (eyePart == "Vitreous Humor")
            {
                details = "Yerleşim: Vitreous humor, lensin arkasında ve retinanın önünde bulunan büyük, jel benzeri bir yapıdadır. Gözün arka bölümünü doldurur.\r\n\r\nFonksiyon: Vitreous humor, göz küresinin şeklini korur ve retinayı yerine sabitler. Aynı zamanda ışığın retinaya geçişini sağlar ve göz içi basıncını düzenler.\r\n\r\nYapı: Vitreous humor, %98-99 oranında sudan oluşan, şeffaf ve jelatinimsi bir maddedir. İçinde kolajen lifler ve hiyaluronik asit bulunur. Bu yapı, vitreous humorun jel benzeri kıvamını sağlar.\r\n\r\nGörme Sağlığı: Vitreous humorun şeffaflığı, ışığın retinaya doğru bir şekilde ulaşmasını sağlar. Vitreous humorun opaklaşması veya içinde yüzen partiküllerin bulunması (floaters) görme bozukluklarına yol açabilir.\r\n\r\nYaşlanma: Yaşla birlikte vitreous humorun yapısı değişebilir. Vitreus jelinin büzülmesi ve retinadan ayrılması (vitreus dekolmanı) yaygın bir durumdur. Bu genellikle ciddi değildir ancak retina yırtılması veya dekolmanı riski oluşturabilir.\r\n\r\nSağlık ve Hastalık: Vitreous humor ile ilgili sorunlar, göz travmaları, enfeksiyonlar veya vitreoretinal hastalıklar nedeniyle ortaya çıkabilir. Bu tür durumlar, genellikle bulanık görme, ışık çakmaları veya görme kaybına yol açabilir. ";
            }
            else if (eyePart == "Sclera")
            {
                details = "Yerleşim: Sclera, göz küresinin dış tabakasını oluşturan beyaz, sert ve opak bir yapıdır. Gözün ön kısmında kornea ile birleşir ve gözün geri kalanını sarar.\r\n\r\nFonksiyon: Sclera, göz küresinin şeklini korur ve iç yapıları dış etkenlerden korur. Aynı zamanda kasların göz küresine tutunmasına ve hareket etmesine yardımcı olur.\r\n\r\nYapı: Sclera, yoğun bağ dokusundan oluşur ve yüksek kolajen içeriği sayesinde dayanıklı ve serttir. Üç ana katmandan oluşur: episclera, scleral stroma ve lamina fusca. Bu katmanlar, sclera'nın kalınlığını ve dayanıklılığını sağlar.\r\n\r\nKoruma: Sclera, gözün dış kısmını kaplayarak mekanik yaralanmalara karşı koruma sağlar. Ayrıca, ışığın gereksiz yere göz içine girmesini engeller ve bu sayede görme fonksiyonunu destekler.\r\n\r\nBağlantılar: Sclera, kornea, iris ve optik sinirle bağlantılıdır. Optik sinir, gözün arka kısmında sclera'dan geçerek beyne ulaşır. Bu bağlantılar, gözün anatomik bütünlüğünü ve işlevselliğini sağlar.\r\n\r\nRenk: Sclera genellikle beyaz renklidir, ancak bazı durumlarda (örneğin, sarılık veya belirli hastalıklar) renk değişiklikleri gösterebilir. Bebeklerde sclera daha ince ve mavimsi görünebilir.\r\n\r\nSağlık ve Hastalık: Sclera ile ilgili sorunlar arasında sklerit (sclera iltihabı) ve episklerit (episclera iltihabı) bulunur. Bu durumlar, genellikle ağrı, kızarıklık ve görme bozukluklarına yol açabilir. ";
            }
            else if (eyePart == "Choroid")
            {
                details = "Yerleşim: Choroid, göz küresinin orta tabakasında yer alır ve sclera ile retina arasında bulunur. Gözün arka kısmının büyük bir bölümünü kaplar.\r\n\r\nFonksiyon: Choroid, gözün retina tabakasına oksijen ve besin sağlar. Aynı zamanda göz içindeki sıcaklık ve basıncı düzenler. Choroid, retina hücrelerinin sağlıklı kalması için gerekli olan kan akışını sağlar.\r\n\r\nYapı: Choroid, yüksek düzeyde damar içerir ve pigmentli hücrelerle kaplıdır. Bu pigmentler, ışığın göz içine yayılmasını engelleyerek görüntülerin net olmasını sağlar. Choroid, dört ana katmandan oluşur: Bruch membranı, kılcal damar tabakası, damar tabakası ve suprakoroid.\r\n\r\nPigment: Choroid, melanin pigmenti açısından zengindir. Melanin, ışığı emerek göz içindeki yansımaları ve parlamaları azaltır. Bu da, görsel netliği artırır ve gözün ışığa karşı duyarlılığını kontrol eder.\r\n\r\nKan Akışı: Choroid, gözdeki en yüksek kan akış hızına sahip yapıdır. Bu, retina hücrelerinin sürekli olarak oksijen ve besin almasını sağlar ve retina metabolizmasının sürdürülmesine yardımcı olur.\r\n\r\nSağlık ve Hastalık: Choroid ile ilgili yaygın hastalıklar arasında koroidit (choroid iltihabı) ve yaşa bağlı makula dejenerasyonu (AMD) bulunur. Bu durumlar, genellikle görme kaybı, bulanık görme ve görsel bozukluklara yol açabilir. Ayrıca, koroid tümörleri ve vasküler anomaliler de gözlemlenebilir.\r\n\r\nYaşlanma: Yaşlandıkça, choroid tabakasında değişiklikler meydana gelebilir. Choroid'in incelmesi ve kan akışının azalması, yaşa bağlı görme sorunlarına katkıda bulunabilir. ";
            }
            else if (eyePart == "Pigment Tabakası")
            {
                details = "Yerleşim: Pigment tabakası, gözün retina tabakasının altında, choroid ile retina arasında bulunur. Retina pigment epiteli (RPE) olarak da bilinir ve retinanın dış kısmını oluşturur.\r\n\r\nFonksiyon: Pigment tabakası, retina hücrelerini korur ve destekler. Işığı emer, fotoreseptör hücrelerin dış segmentlerini fagosite eder ve retina metabolizmasını düzenler. Ayrıca, gözdeki ışık yansımalarını ve parlamaları azaltarak net görme sağlar.\r\n\r\nYapı: Pigment tabakası, melanin pigmenti içeren hücrelerden oluşur. Bu hücreler, fotoreseptörlerin dış segmentlerini çevreler ve besler. Pigment tabakası, fotoreseptörlerin sağlıklı çalışmasını destekleyen, kan-retina bariyerini oluşturur ve retina hücrelerine oksijen ve besin sağlar.\r\n\r\nPigment: Pigment tabakası, yüksek miktarda melanin pigmenti içerir. Melanin, ışığı emerek göz içindeki yansımaları ve parlamaları azaltır. Bu, görsel netliği artırır ve gözün ışığa karşı duyarlılığını kontrol eder.\r\n\r\nKan Akışı: Pigment tabakası, choroid tabakasından gelen kan akışı ile beslenir. Bu, pigment hücrelerinin ve retina fotoreseptör hücrelerinin sürekli olarak oksijen ve besin almasını sağlar ve retina metabolizmasının sürdürülmesine yardımcı olur.\r\n\r\nSağlık ve Hastalık: Pigment tabakası ile ilgili yaygın hastalıklar arasında yaşa bağlı makula dejenerasyonu (AMD), retinitis pigmentosa ve Stargardt hastalığı bulunur. Bu durumlar, genellikle görme kaybı, gece körlüğü ve renk görme bozukluklarına yol açabilir.\r\n\r\nYaşlanma: Yaşlandıkça, pigment tabakasında değişiklikler meydana gelebilir. Melanin pigmentinin azalması, hücrelerin işlevselliğinin bozulması ve retina hücrelerinin yenilenme kapasitesinin düşmesi, yaşa bağlı görme sorunlarına katkıda bulunabilir. ";
            }
            else if (eyePart == "Retina")
            {
                details = "Yerleşim: Retina, gözün en iç tabakasıdır ve göz küresinin arka kısmında yer alır. Retina, vitreus adı verilen jel benzeri madde ile lens arasında bulunur ve choroid ile doğrudan temas halindedir.\r\n\r\nFonksiyon: Retina, görme işlevi için kritik olan ışığı algılayan hücreler (fotoreseptörler) içerir. Işığı elektrik sinyallerine dönüştürür ve bu sinyalleri optik sinir aracılığıyla beyne ileterek görsel bilgiyi oluşturur. Retina, hem merkezi hem de periferik görmeyi sağlar ve renkli görme ile detaylı görme için farklı fotoreseptör tiplerine sahiptir.\r\n\r\nYapı: Retina, birçok katmandan oluşur. Başlıca katmanlar arasında fotoreseptör hücre tabakası (rod ve kon hücreleri), bipolar hücreler, ganglion hücreleri ve iç nükleer tabaka bulunur. Retina, ışığın sinir sinyallerine dönüştürülmesi ve bu sinyallerin beyne iletilmesi sürecinde yer alan karmaşık bir sinir ağına sahiptir.\r\n\r\nPigment: Retina pigment epiteli (RPE), retina tabakasının bir parçasıdır ve melanin pigmenti içerir. Bu pigment, ışığı emerek retina içindeki yansımaları ve parlamaları azaltır, böylece görsel netliği artırır ve gözün ışığa karşı duyarlılığını kontrol eder.\r\n\r\nKan Akışı: Retina, zengin bir kan akışına sahiptir ve iki ana kaynak tarafından beslenir: choroid tabakasından gelen kan damarları ve retina arterleri. Bu, retina hücrelerinin sürekli olarak oksijen ve besin almasını sağlar ve retina metabolizmasının sürdürülmesine yardımcı olur.\r\n\r\nSağlık ve Hastalık: Retina ile ilgili yaygın hastalıklar arasında retinitis pigmentosa, diyabetik retinopati, yaşa bağlı makula dejenerasyonu (AMD), retina dekolmanı ve retina damar tıkanıklıkları bulunur. Bu durumlar, genellikle görme kaybı, bulanık görme ve görsel bozukluklara yol açabilir.\r\n\r\nYaşlanma: Yaşlandıkça, retina tabakasında değişiklikler meydana gelebilir. Retina hücrelerinin yenilenme kapasitesinin azalması, pigment tabakasının incelmesi ve kan akışının azalması, yaşa bağlı görme sorunlarına katkıda bulunabilir. Yaşa bağlı makula dejenerasyonu, yaşlılarda yaygın bir retina hastalığıdır ve merkezi görmenin kaybına yol açabilir. ";
            }
            else if (eyePart == "Sarı Nokta")
            {
                details = "**Yerleşim**: Sarı nokta (makula), retina tabakasının merkezinde yer alır ve fovea olarak bilinen küçük bir çukur içerir. Bu bölge, gözün arka kısmında, optik sinirin hemen yanında bulunur.\r\n\r\n**Fonksiyon**: Sarı nokta, merkezi görmeyi sağlayan retina bölgesidir. Renkli görme ve ince detayları ayırt etme yeteneği için kritiktir. Fovea, en yüksek yoğunlukta kon hücrelerine sahip olduğundan, en keskin görmeyi sağlar.\r\n\r\n**Yapı**: Sarı nokta, yüksek yoğunlukta fotoreseptör hücreler (özellikle kon hücreleri) içerir. Bu hücreler, ışığı elektrik sinyallerine dönüştürerek görme sinirlerine iletir. Sarı nokta ayrıca, kan damarları ve pigment epitel hücreleri ile desteklenir.\r\n\r\n**Pigment**: Sarı nokta, lutein ve zeaksantin gibi sarı pigmentler içerir. Bu pigmentler, mavi ışığı emerek retina hücrelerini korur ve görsel netliği artırır. Aynı zamanda oksidatif stresi azaltarak hücre sağlığını korur.\r\n\r\n**Kan Akışı**: Sarı nokta, merkezi retinal arter ve koroidal damarlar tarafından beslenir. Bu damarlar, sarı nokta hücrelerine gerekli oksijen ve besinleri sağlar. Yüksek kan akışı, hücre metabolizmasının sürdürülmesine yardımcı olur.\r\n\r\n**Sağlık ve Hastalık**: Sarı nokta ile ilgili yaygın hastalıklar arasında yaşa bağlı makula dejenerasyonu (AMD), makula deliği ve makula ödemi bulunur. AMD, merkezi görme kaybına yol açabilir ve genellikle ileri yaşlarda ortaya çıkar. Makula ödemi, diyabet veya retina damar tıkanıklıkları nedeniyle oluşabilir.\r\n\r\n**Yaşlanma**: Yaşlandıkça, sarı nokta hücrelerinde değişiklikler meydana gelebilir. Pigment epitel hücrelerinin dejenerasyonu ve fotoreseptör hücre kaybı, yaşa bağlı makula dejenerasyonu gibi hastalıklara katkıda bulunabilir. Bu durum, merkezi görme kaybına ve detaylı görme yeteneğinin azalmasına yol açabilir. ";
            }
            else if (eyePart == "Kör Nokta")
            {
                details = "Yerleşim: Kör nokta (optik disk veya optik papilla), retina tabakasının arka kısmında, optik sinirin gözden çıktığı bölgede yer alır. Kör nokta, makulanın nazal (burna yakın) tarafında bulunur.\r\n\r\nFonksiyon: Kör nokta, optik sinir liflerinin ve retina damarlarının gözden çıkış noktasıdır. Görme işlevi yoktur çünkü burada fotoreseptör hücreler bulunmaz. Kör nokta, retinadan gelen sinir sinyallerinin beyne iletilmesi için bir geçiş noktasıdır.\r\n\r\nYapı: Kör nokta, fotoreseptör hücreler (rod ve kon hücreleri) içermeyen tek retina bölgesidir. Optik sinir lifleri ve kan damarlarının yoğun olduğu bir bölgedir. Optik sinir, bu noktadan çıkarken beyne görsel bilgi taşır.\r\n\r\nPigment: Kör noktada pigment bulunmaz, çünkü burada fotoreseptör hücreler yoktur. Bu nedenle, kör nokta görme işlevine katkıda bulunmaz ve görsel algıda bir boşluk oluşturur.\r\n\r\nKan Akışı: Kör nokta, merkezi retinal arter ve venler tarafından beslenir. Bu damarlar, retina hücrelerine gerekli oksijen ve besinleri sağlar. Optik disk çevresindeki damarlar, kan akışının düzenlenmesinde önemli bir rol oynar.\r\n\r\nSağlık ve Hastalık: Kör nokta ile ilgili yaygın hastalıklar arasında optik nöropati, optik disk ödemi (papil ödem) ve optik disk drusen bulunur. Bu durumlar, optik sinir fonksiyonunu etkileyebilir ve görme kaybına yol açabilir. Optik nörit, optik sinirin iltihaplanmasıdır ve genellikle ağrılı görme kaybına neden olabilir.\r\n\r\nYaşlanma: Yaşlanma süreci, kör nokta üzerinde doğrudan etkili olmasa da, optik sinir sağlığı ve kan akışını etkileyebilir. Yaşla birlikte optik sinir liflerinin dejenerasyonu ve kan akışının azalması, görme fonksiyonunda bozulmalara yol açabilir.\r\n\r\nKör nokta, gözün yapısal ve işlevsel bir parçasıdır, ancak görsel algıda bir boşluk oluşturur. Normalde, beyin bu boşluğu doldurarak kişinin kör noktasını fark etmesini engeller. ";
            }
            else if (eyePart == "Optik Sinir")
            {
                details = "**Yerleşim**: Optik sinir (nervus opticus), retinadan başlayarak beynin görme merkezine kadar uzanır. Retina ile beyin arasındaki görsel bilgiyi ileten bir kablo gibidir. Göz küresinin arka kısmından çıkar ve beyne doğru ilerler.\r\n\r\n**Fonksiyon**: Optik sinir, retina tarafından algılanan ışık bilgilerini elektrik sinyallerine dönüştürerek beyne iletir. Bu sinir, görsel bilgiyi beyne taşıyan ana yol olarak işlev görür ve böylece görme yeteneği sağlanır. Optik sinir, her iki gözden gelen bilgileri beyin tarafından birleştirilip işlenmesi için taşır.\r\n\r\n**Yapı**: Optik sinir, yaklaşık 1.2 milyon sinir lifi içerir. Bu lifler, retina ganglion hücrelerinin aksonlarından oluşur ve miyelin kılıfı ile kaplıdır. Optik sinir, gözden çıktıktan sonra optik kanala girer ve optik kiazmada kısmen çaprazlaşarak beyne doğru devam eder. Optik sinir, beyne ulaştığında lateral genikulat nükleus (LGN) ve ardından görsel kortekse ulaşır.\r\n\r\n**Pigment**: Optik sinir, retina pigment epitelindeki melanin pigmentini içermez. Pigmentlerin işlevi retina ile sınırlıdır ve optik sinirde doğrudan bir rolü yoktur.\r\n\r\n**Kan Akışı**: Optik sinir, optik disk çevresindeki kan damarları tarafından beslenir. Optik sinirin kan akışı, merkezi retinal arter ve koroidal damarlar tarafından sağlanır. Bu damarlar, sinir hücrelerinin ihtiyaç duyduğu oksijen ve besinleri sağlar.\r\n\r\n**Sağlık ve Hastalık**: Optik sinir ile ilgili yaygın hastalıklar arasında optik nörit, glokom, optik sinir atrofisi ve optik disk ödemi (papil ödem) bulunur. Optik nörit, genellikle multipl skleroz gibi otoimmün hastalıklarla ilişkilidir ve ağrılı görme kaybına yol açabilir. Glokom, optik sinire zarar vererek görme kaybına neden olur. Optik sinir atrofisi, sinir liflerinin dejenerasyonu ve görme fonksiyonunun azalmasıyla sonuçlanır.\r\n\r\n**Yaşlanma**: Yaşlandıkça, optik sinir liflerinde dejenerasyon meydana gelebilir ve sinir fonksiyonu azalabilir. Bu durum, görme keskinliğinin ve görsel algının bozulmasına yol açabilir. Glokom gibi hastalıklar, yaşlılarda daha yaygındır ve optik sinir hasarına neden olabilir.\r\n\r\nOptik sinir, görme işlevi için hayati öneme sahip bir yapıdır ve retina ile beyin arasındaki bağlantıyı sağlar. Sağlıklı bir optik sinir, net ve keskin görme için gereklidir. ";
            }
            else if (eyePart == "Central Artery")
            {
                details = "**Yerleşim**: Merkezi retinal arter (central retinal artery), optik sinirin içinde ilerleyen ve gözün arka kısmında retina tabakasına giren ana arterdir. Bu arter, göz küresine girdikten sonra optik diskten retinaya dallar verir ve retinanın iç katmanlarını besler.\r\n\r\n**Fonksiyon**: Merkezi retinal arter, retina hücrelerine gerekli oksijen ve besinleri sağlar. Retina, görsel bilgiyi işlemek için yüksek enerjiye ihtiyaç duyan bir yapıdır ve merkezi retinal arter, bu enerjinin sağlanmasında kritik bir rol oynar. Arter, retina içindeki metabolik faaliyetleri destekler ve retina hücrelerinin sağlıklı kalmasını sağlar.\r\n\r\n**Yapı**: Merkezi retinal arter, oftalmik arterin bir dalıdır. Optik sinirin ortasından geçerek retinaya ulaşır. Retinaya girdikten sonra, üst ve alt dallara ayrılarak retinanın dört ana bölgesine (superior temporal, superior nasal, inferior temporal, inferior nasal) kan sağlar. Bu dallar, retina boyunca daha küçük arteriyollere ve kapillerlere ayrılır.\r\n\r\n**Pigment**: Merkezi retinal arter, melanin veya diğer pigmentleri içermez. Ancak, retina pigment epitelinde bulunan pigmentler, retina damarlarının işlevini ve retina hücrelerinin sağlığını dolaylı olarak etkileyebilir.\r\n\r\n**Kan Akışı**: Merkezi retinal arter, retinaya düzenli ve yeterli kan akışını sağlamak için kritik öneme sahiptir. Bu arter, yüksek basınç altında kan taşır ve retina hücrelerine oksijen ve besinleri ulaştırır. Merkezi retinal arterin sağladığı kan akışı, retina metabolizmasının ve görsel işlevin devamlılığını sağlar.\r\n\r\n**Sağlık ve Hastalık**: Merkezi retinal arter ile ilgili yaygın hastalıklar arasında merkezi retinal arter tıkanıklığı (CRAO) ve retinal arter embolisi bulunur. CRAO, aniden gelişen ve genellikle ağrısız olan ani görme kaybına neden olur. Retinal arter tıkanıklığı, arterdeki bir pıhtı veya plak nedeniyle kan akışının durması sonucu oluşur ve hızlı müdahale gerektirir. Bu durum, retinal iskemiye ve kalıcı görme kaybına yol açabilir.\r\n\r\n**Yaşlanma**: Yaşlandıkça, merkezi retinal arterdeki damar duvarlarında değişiklikler meydana gelebilir. Arterioskleroz (damar sertliği) gibi durumlar, arterin esnekliğini azaltabilir ve kan akışını olumsuz etkileyebilir. Yaşlı bireylerde merkezi retinal arter tıkanıklığı riski artar ve bu durum, görme kaybına yol açabilir.\r\n\r\nMerkezi retinal arter, retina sağlığı ve görme işlevi için hayati bir rol oynar. Sağlıklı bir merkezi retinal arter, retinanın düzgün çalışması ve net görme için gereklidir. ";
            }
            else
            {
                details = "Belirtilen göz parçası hakkında bilgi bulunmamaktadır.";
            }
            MessageBox.Show(details, "Göz Bölümleri Detayları");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void FormGoz_Load_1(object sender, EventArgs e)
        {

        }
    }
}

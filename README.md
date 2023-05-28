# MetaLand-Simulation-Game

I. AC¸IKLAMA :


Kocaeli Universitesi Bilgisayar Muhendisligi Programlama 
Labaratuvarı 2 3.proje hakkında rapor yazısı.
II. OZET: 

A. Proje Acıklaması
Kullanıcıların emlak alabildigi is kurabildigi calısabildi gi,
kendi icinde ekonomik bir sistemi olan bazı kurallara dayalı
metaland oyunu.Oyuncular belirtilen bolge icindeki bos arazi
leri satın alabilir,buradaki menkullerin tipini degisebilir bu
radan ilan acabilir,bu ilan uzerinden kullanıcıları ise alabilir
belirli bir gelir karsılıgında belirli bir sure calıstırabilir.Ayrıca
menkul satabilir veya satın alabilir.Haritanın bir de yoneticisi
vardır.Yonetici istedigi boyutta harita olusturabilir, bu harita
uzerinde bir cok yetkiye sahiptir kullanıcıların yemek esya 
ve paralarını manipule edebilir.Ayrıca kullanıcıların yemek, 
esya ve paraları biterse oyunu kaybederler ve bir daha eris¸m
saglayamazlar. 
B. Gelistirme Sureci :

Oncellikle bizden istenen metaland simulasyonu oyunu icin 
c kullandıkC kullanmamızdaki temel etken bizden istenenleri
rahatlıkla karsılaması, windows form uygulaması kullanımının
visual studio uzerinden kullanılmasının kolay olması ve daha 
oncesinde c diline asina olmamız oldu.Ayrıca bizden istenen
veri tabanı islemleri icin mssql server kullandık, mssql kullanımızdaki temel etkense hem daha oncesinde kullanımına 
asina olmamız hem de mssqlin arayuz ve kullanımının bize 
sunulan diger secenekler olan mysql ve postgresql’den daha 
kolay olması oldu.

Tasarladıgımız Metaland platformunda bulunan kullanıcılar 
icin tasarlanacak olan veritabanı, varlıklar ve islemlerle ilgili bilgilerin duzenli bir sekilde yonetilmesine yardımcı ola- 
caktır. Bu sayede kullanıcılar, ihtiyac¸ duydukları bilgilere
daha kolay bir sekilde ulasabileceklerdir.Veritabanı tabloları
olusturulurken bizden istendigi sekilde 3nf normalizasyonuna ˘
uygun olmasına dikkat ettik.

Olusturdugumuz windows form uygulamasında tek bir 
form uzerinden tum islemleri kontrol etmek icin Usercontrol 
sınıflarıyla calıstık . Usercontrol sınıfı form classı uzerine teti
lenen ve uzerinde yeniden kullanılmasına olanak saglayacak 
sekilde form1 classı uzerine gerekli durumlar olustugunda
cagırılmaktadır.Bu controller hem kod yazımını daha duzenli
ve verimli hale getirmektedir hem de kullanıcı icin daha
duzenli bir arayuz sunmaktadır. 

Projede olusturdugumuz ER diyagramı mssql’in 
bize sundugu veritabanı diagramı goruntuleme ozelligi
kullanarak elde edilmis¸tir. Aynı zamanda bizden
istenen UML diyagramı icinse c gelis¸irmek icin
kullandıgımız ortam olan visual studio’nun sınıf 
goruntuleyicisi  ozelli  ginebas¸vurulmustur. [htbp] ˘
III. YONTEM ¨

A. Giris¸

Giris¸ ekranında giris¸ yapan kisiden yonetici girisi mi 
kullanıcı girisi mi yapmak istedgine gore sectirilir.Veya 
kayıt olma ekranına gidilir.Yaptıgı secenege gore ekran- 
lara yonlendirilir yonlendirilen ekranda isim ve sifre is-
tenir.Ardından bu degerler kontrol edilir  eger oyuncu veya ˘,
yonetici tabloları kontrol edilir eger kullanıcı varsa giris¸ yapılır ˘
yoksa islem basarısız olur.Ayrıca burada oyuncunun kaynakları
kontrol edilir eger tukenmisse giris¸ yapmasına izin verilmez. 

B. Kayıt Olma

Kayıt olma ekranında kullanıcıdan bilgiler alınır.Ardından
metaLand adlı Db de kullanıcı tablosuna kaydedilir.Ve kul-
lanıcıya kayıt olusturuldu bilgisi verilir.

C. kullanıcı panel

Burada yoneticiye harita id sorulur.Ve Secilen harita 
ekrana verilir.Kontrol ekranında yonetici harita numarasını 
ve boyutunu girerek harita olusturabilir.Haritaya kayıtlı
olanları sorgular ve gun sonunu verir.Oyuncu panelinden 
farkı kontrol kısmıdır.Menkullerim kısmında kullanıcıya
ait menkuller bilgileriyle birlikte verilir.Ve bu ekranda
kisi menkul secip satabilir.Ayrıca burada menkul insa
edilebilir.Varlıklar kısmında kisinin yemek para ve
esya miktarı gosterilir. 
Is¸ talebi kısmında isilanları
gorunt  ulenebilir uygunsa kabul edilebilir degilse pazarlık
yapılabilir.Pazar kısmında satılıktaki menkuller satın alınabilir.

D. harita-oyun

Harita uzerinde gezinme yapılabili, begenilen ya da secilen bir.
’turVer’ adlı yontem, ’alanNo’ adlı bir tamsayı parametresi ¨
alır. Saglanan baglantı dizesini kullanarak bir SQL verita- ˘
banına baglanır, bir baglantı acar ve ’alaninfo’ adlı bir tablodan ˘
veri secmek icin bir SQL komutu calıstırır. Komut, ’alanharita’
alanının degeri ’singleton.haritaID’ de ˘ giskeninin de ˘ gerieit ˘
ve ’alanno’ alanının degeri saglanan ’alanNo’ parametresine ˘
esit olan tum verileri secer. ¨
Tabloda eslesen bir kayıt bulunursa, yontem kayıttan ¨
’alanturu alanının degerini alır, bir dizeye donustuur ve 
’returnValue’ adlı bir degiskene atar. Son olarak, veritabanı 
baglantısını kapatır ve ’returnValue’ degerini dondurur. 
’fiyatver’ methodu bir tamsayı ve bir dize parametresi alır.
Baglantı dizesini kullanarak bir SQL veritabanına baglanır, 
bir baglantı acar ve ’alanTur’ parametresinin degerine gore 
’magaza’ veya ’market’ tablosundan verisecmek icin bir SQL
komutu calıstırır. Komut, ’magazaharita’ veya ’marketharita’
alanının degeri ’singleton.haritaID’ degis¸keninin degerine esit 
ve ’magazano’ veya ’marketno’ alanının degeri saglanan 
’alanNo’ parametresine esit olan tum verileri secer. 
Tabloda eslesen bir kayıt bulunursa, yontem kayıttan ’mag- 
azaucret’ veya ’market ¨ ucretalanının degerini alır, bir diz- 
eyedonusturur ve ’returnValue’ adlı bir degiskene atar. Son 
olarak, veritabanı baglantısını kapatır ve ’returnValue’ degerini 
dondurur. ¨

Yani bu method, saglanan ’alanNo’ parametresine ve
’alanTur’ parametresine baglı olarak bir SQL veritabanı ˘
tablosundan fiyat degerini alır. ’yoneticibilgiver’ methodu 
’talepbilgi’ adlı bir dize parametresi alır ve kullanıcının
’esyamiktarı’ veya ’yemekmiktarı’ degerlerini donndurur. 
Baglantı dizesini kullanarak bir SQL veritabanına baglanır 
ve ’kullanıcıinfo’ tablosundan ’kullanıcıadı’ alanı ’singleton.oyuncuAd’ degiskeninin degerine esit olan verileri secmek 
icin bir SQL komutu calıstırır.
Eger ’talepbilgi’ degeri ’esya’ ise, SQL komutu ’esyamik- 
tarı alanının degerini secer; eger ’talepbilgi’ degeri ’yemek’ 
ise, SQL komutu ’yemekmiktarı’ alanının degerini secer. 
Daha sonra, SQLDataReader nesnesi ile kayıtlar okunur ve
bulunan kayıtlarda ’esyamiktarı’ veya ’yemekmiktarı’ degeri 
’returnValue’ degiskenine atanır. Bu deger son olarak bir 
tamsayıya donusturulur ve ’returnValue’ olarak dondurulur. 
Son olarak, veritabanı baglantısı kapatılır. 
Bu method, kullanıcının esya veya yemek miktarını
dondurur ve bu bilgilerin diger islemlerde kullanılması icin 
kullanılabilir.

”yoneticiParaAzalt()” methodu,  oncelikle bir SqlConnec- 
tion objesi olusturur ve baglantı dizesini kullanarak bir SQL 
veritabanına baglanır. Daha sonra, ”yoneticiParaBul()” adlı  
baska bir method kullanarak yoneticinin parasını bulur ve bir
degiskene atar. Ardından, kullanıcının sectigi urun adetini ve 
fiyatını kullanarak hesaplayarak, kullanıcının parasını azaltır
ve veritabanına kaydeder.

”yoneticiParaBul()” methodu ise, bir tamsayı degeri 
dondurur ve bir SqlConnection objesi olusturur. Daha sonra, 
baglantı dizesini kullanarak bir SQL veritabanına baglanır ve 
bir SQL komutu calıstırarak yoneticinin parasını bulur. Bu 
degeri bir degiskene atar, veritabanı baglantısını kapatır ve 
degiskeni dondurur. 

Bu iki method birlikte calısarak, kullanıcının urun satın 
alma islemleri sırasında, yoneticinin parasını azaltmaktadır. Bu 
sayede, kullanıcıların alısveris¸ yaparken yeterli miktarda para
olup olmadıgını kontrol etmek icin bu method kullanılabilir. 
Yoneticinin parasını azaltmak icin kullanılan bu method, 
diger islemler icin de kullanılabilir.  Ornegin, yoneticinin para 
miktarını kontrol etmek icin ”yoneticiParaBul()” methodu kul- 
lanılabilir. Bu sayede, yoneticinin para miktarı degistiginde, 
diger islemlerde bu degisiklikten yararlanılabilir. 

Overall, bu method, kullanıcının urun satın alma islemleri 
sırasında yoneticinin parasını azaltmak icin kullanılabilir 
ve yoneticinin para miktarını kontrol etmek icin de diger 
islemlerde kullanılabilir. Bu sayede, daha iyi bir alısveris¸
deneyimi saglanabilir ve islemler daha akıcı hale getirilebilir. 
’sahiparaartır’ methodu bir kullanıcının veya yoneticinin 
parasını artırmak icin tasarlanmıstır. Method, ”sahipBul()” adlı
bir method kullanarak oncelikle kullanıcının veya yoneticinin 
kimligini belirler ve bir degiskene atar. Daha sonra, kul- 
lanıcının sectigi˘ urun adetini ve fiyatını kullanarak hesapla- 
yarak, kullanıcının parasını arttırır ve veritabanına kaydeder.
Bu method, kullanıcının veya yoneticinin parasını arttırmak 
icin kullanılabilir ve bu bilgilerin diger islemlerde kullanılması 
icin kullanılabilir. Yonetici veya kullanıcı kimligine baglı 
olarak, ”yoneticiinfo” veya ”kullanıcıinfo” tablolarından il- 
gili alanlar secilir ve kullanıcının parası ”paramiktarı” veya
”yoneticipara” alanına kaydedilir. 

Overall, bu method, kullanıcının veya yoneticinin parasını 
arttırmak icin kullanılabilir ve diger islemlerde kullanılabilir. 
Bu sayede, daha iyi bir alısveris deneyimi saglanabilir ve 
islemler daha akıcı hale getirilebilir.
’kullanıcıparabul’ methodu, veritabanında kullanıcı adı
’alanSahip.Text’ olan kullanıcının para miktarını dondurur. 
Veritabanına baglanarak, ’kullanıcıinfo’ tablosundan kul- 
lanıcının para miktarını secer ve bir degiskene atar. Bu
degisken son olarak bir tamsayıya donusturulur ve ’return- 
Value’ olarak dondurulur. 
Bu method, kullanıcının para miktarını kontrol etmek icin
kullanılabilir ve diger islemlerde de kullanılabilir. ˘ Ornegin, 
kullanıcının para miktarına baglı olarak, kullanıcının ala- 
bilecegi urunlerin sayısı kontrol edilebilir. Bu sayede, daha 
iyi bir alısveris deneyimi saglanabilir ve islemler daha akıcı 
hale getirilebilir.

‘sahipBul()‘ methodu, veritabanında yonetici adı 
’alanSahip.Text’ olan yoneticinin veya kullanıcının kimligini 
belirler ve bir dize olarak dondurur. Baglantı dizesini 
kullanarak bir SQL veritabanına baglanır ve ’yoneticiinfo’ 
tablosundan ’yoneticiad’ alanı saglanan ’alanSahip.Text’ 
degerine esit olan verileri secmek icin bir SQL komutu 
calıstırır. ’COUNT(*)’ fonksiyonu kullanılarak kayıtlar sayılır
ve sayı degeri bir degiskene atanır. Eger kayıt sayısı 0’dan 
buyukse, yonetici kimligi belirlenir ve ’yonetici’ dizesi 
dondurulur; aksi takdirde, kullanıcı kimligi belirlenir ve 
’kullanıcı’ dizesi dondurulur. 

Bu method, kullanıcının veya yoneticinin kimligini belir- 
lemek icin kullanılabilir ve diger islemlerde de kullanılabilir. 
Ornegin, yonetici veya kullanıcı kimligine baglı olarak, 
yonetici veya kullanıcı  ozelliklerine erisim kontrol edilebilir. 
Bu sayede, daha iyi bir kullanıcı deneyimi saglanabilir ve 
islemler daha akıcı hale getirilebilir.
’ur¨ unalclick’ methodu, kullanıcının ¨ ur¨ un satın alma 
islemlerindeki temel islevleri gerceklestirir. Oncelikle, kul- 
lanıcının sectigiurun turune (magaza ya da market) ve adetine 
gore, kullanıcının parasını azaltır ve urun miktarını artırır. 
Bu islem, oncelikle ‘yoneticiBilgiVer()‘ methodunu kul- 
lanarak, kullanıcının sectigi urunun fiyatını ve turunu
belirler. Daha sonra, kullanıcının parasını azaltmak icin
‘yoneticiParaAzalt()‘ methodunu cagırır ve kullanıcının 
parasını gunceller. 
Ardından, kullanıcının sectigiurun miktarını ‘ urunAdet‘ 
parametresinde belirleyerek, ‘kullanıcıinfo‘ tablosundaki
‘esyamiktarı‘ veya ‘yemekmiktarı‘ alanını gunceller. Bu 
islem, ‘Update‘ SQL komutunu kullanarak gerceklestirilir.
Son olarak, kullanıcının parasını artırmak icin ‘sahipParaArtır()‘ methodunu cagırır ve islemin basarılı oldugunu 
belirten bir mesaj kutusu goruntuler. 
Bu method, kullanıcının urun satın alma islemlerini 
gerceklestirmesini saglayarak, alısveris¸ deneyimini daha iyi 
hale getirir ve islemleri daha akıcı hale getirir. Ayrıca,
yoneticinin parasını kontrol etmek icin ‘yoneticiParaBul()‘ 
methodu ve kullanıcının para miktarını kontrol etmek icin
‘kullanıcıParaKontrol()‘ methodu gibi diger methodlarla bir- 
likte kullanılabilir.

Overall, bu method, bir alısveris¸ islemi sırasında gereken
temel islevleri yerine getirerek, kullanıcıların daha iyi bir
alısveris¸ deneyimi yasamasını saglar ve islemlerin daha hızlı 
ve akıcı bir sekilde gerceklestirilmesini saglar. 
’isbasvuruonaylaclick’ methodu, bir is bas¸vurusu bilgisi
olusturmak icin kullanılır. ˙Is basvuruları, ”basvuruinfo” adlı
bir tabloda saklanır ve bu method, saglanan parametreleri 
kullanarak yeni bir is basvurusu kaydı olusturur.
Oncelikle, SqlConnection nesnesi olusturulur ve baglantı 
dizesi kullanılarak bir SQL veritabanına baglanılır. Daha 
sonra, ”basvuruinfo” tablosuna yeni bir kayıt eklemek icin bir
SQL INSERT komutu calıstırılır.

Komut, saglanan parametreleri kullanarak, ”basvuruno”, 
”basvuruisim”, ”basvurusaat”, ”basvuruucret”,
”basvurualansahip”, ”basvurualanno” ve ”basvurualanharita”
alanlarını doldurur.
Son olarak, SqlCommand nesnesi kullanılarak komut
calıstırılır ve islem basarılı oldugunda bir mesaj kutusu 
goruntulenir. 

Bu method, yeni bir isbasvurusu kaydı olusturmak icin kullanılır. ˙Isbas¸vuruları, ”basvuruinfo” adlı bir tabloda saklanır
ve bu method, saglanan parametreleri kullanarak yeni bir is
basvurusu kaydı olusturur.

E. UML diyagramı :<img src="http://url/to/img.png" alt="alt text" width="320" height="180">

F. ER diyagramı :

REFERENCES
[1] https://www.youtube.com/watch?v=2EkMrrX9sYY&t=8038s
[2] https://www.youtube.com/watch?v=L86eqtdC2as&t=3633s
[3] https://learnsql.com/blog/sql-basics-cheat-sheet/
[4] https://www.youtube.com/watch?v=q F4PyW8GTg
[5] https://dotnet.microsoft.com/en-us/learn/csharp
[6] https://learn.microsoft.com/en-us/dotnet/csharp/
[7] https://www.youtube.com/watch?v=UMc1HLyBHSQ
[8] https://www.youtube.com/watch?v=PzP8mw7JUzI
[9] https://www.youtube.com/watch?v=qLNLWw82NeE&list=
PLyQXlWxYAh8-TkeUrN8viS8K69lNK1pDn
[10] https://www.youtube.com/watch?v=oSeYvMEH7jc
[11] https://www.youtube.com/watch?v=QXQN8NkINfw&list=
PLAeYh-ds6kE-VvUUziIn7 pPnwUxcsteF
[12] https://www.youtube.com/watch?v=vYDyGxoq9JU
[13] https://www.youtube.com/watch?v=HXV3zeQKqGY
[14] https://www.youtube.com/watch?v=iiQPXcQHaz8&list=
PLi1BmHvgBkxI4uBS5vjfhqhAUWPnRL73
[15] https://www.youtube.com/watch?v=GHVkRo3CRo4
[16] https://www.phind.com
[17] https://bard.google.com/?hl=en
[18] https://chat.openai.com

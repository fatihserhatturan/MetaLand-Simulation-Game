# MetaLand-Simulation-Game

I. AC¸IKLAMA
Kocaeli Universitesi Bilgisayar M ¨ uhendisli ¨ gi Programlama ˘
Labaratuvarı 2 3.proje hakkında rapor yazısı.
II. O¨ ZET
A. Proje Ac¸ıklaması
Kullanıcıların emlak alabildigi is¸ kurabildi ˘ gi c¸alıs¸abildi ˘ gi, ˘
kendi ic¸inde ekonomik bir sistemi olan bazı kurallara dayalı
metaland oyunu.Oyuncular belirtilen bolge ic¸indeki bos¸ arazi- ¨
leri satın alabilir,buradaki menkullerin tipini degis¸ebilir bu- ˘
radan ilan ac¸abilir,bu ilan uzerinden kullanıcıları is¸e alabilir ¨
belirli bir gelir kars¸ılıgında belirli bir s ˘ ure c¸alıs¸tırabilir.Ayrıca ¨
menkul satabilir veya satın alabilir.Haritanın bir de yoneticisi ¨
vardır.Yonetici istedi ¨ gi boyutta harita olus¸turabilir, bu harita ˘
uzerinde bir c¸ok yetkiye sahiptir kullanıcıların yemek es¸ya ¨
ve paralarını manipule edebilir.Ayrıca kullanıcıların yemek, ¨
es¸ya ve paraları biterse oyunu kaybederler ve bir daha eris¸im
saglayamazlar. ˘
B. Gelis¸tirme Sureci ¨
Oncellikle bizden istenen metaland sim ¨ ulasyonu oyunu ic¸in ¨
c kullandık.C kullanmamızdaki temel etken bizden istenenleri
rahatlıkla kars¸ılaması, windows form uygulaması kullanımının
visual studio uzerinden kullanılmasının kolay olması ve daha ¨
oncesinde c diline as¸ina olmamız oldu.Ayrıca bizden istenen ¨
veri tabanı is¸lemleri ic¸in mssql server kullandık, mssql kullanımızdaki temel etkense hem daha oncesinde kullanımına ¨
as¸ina olmamız hem de mssqlin arayuz ve kullanımının bize ¨
sunulan diger sec¸enekler olan mysql ve postgresql’den daha ˘
kolay olması oldu.
Tasarladıgımız Metaland platformunda bulunan kullanıcılar ˘
ic¸in tasarlanacak olan veritabanı, varlıklar ve is¸lemlerle ilgili bilgilerin duzenli bir s¸ekilde y ¨ onetilmesine yardımcı ola- ¨
caktır. Bu sayede kullanıcılar, ihtiyac¸ duydukları bilgilere
daha kolay bir s¸ekilde ulas¸abileceklerdir.Veritabanı tabloları
olus¸turulurken bizden istendigi s¸ekilde 3nf normalizasyonuna ˘
uygun olmasına dikkat ettik.
Olus¸turdugumuz windows form uygulamasında tek bir ˘
form uzerinden t ¨ um is¸lemleri kontrol etmek ic¸in Usercontrol ¨
sınıflarıyla c¸alıs¸tık . Usercontrol sınıfı form classı uzerine tetk- ¨
lenen ve uzerinde yeniden kullanılmasına olanak sa ¨ glayacak ˘
s¸ekilde form1 classı uzerine gerekli durumlar olus¸tu ¨ gunda ˘
c¸agırılmaktadır.Bu controller hem kod yazımını daha d ˘ uzenli ¨
ve verimli hale getirmektedir hem de kullanıcı ic¸in daha
duzenli bir aray ¨ uz sunmaktadır. ¨
Projede olus¸turdugumuz ER diyagramı mssql’in ˘
bize sundugu veritabanı diagramı g ˘ or¨ unt ¨ uleme ¨ ozelli ¨ gi˘
kullanarak elde edilmis¸tir. Aynı zamanda bizden
istenen UML diyagramı ic¸inse c gelis¸tirmek ic¸in
kullandıgımız ortam olan visual studio’nun sınıf ˘
gor¨ unt ¨ uleyicisi ¨ ozelli ¨ gine bas¸vurulmus¸tur. [htbp] ˘
III. YONTEM ¨
A. Giris¸
Giris¸ ekranında giris¸ yapan kis¸iden yonetici giris¸i mi ¨
kullanıcı giris¸i mi yapmak istedgine g ˘ ore sec¸tirilir.Veya ¨
kayıt olma ekranına gidilir.Yaptıgı sec¸ene ˘ ge g ˘ ore ekran- ¨
lara yonlendirilir.y ¨ onlendirilen ekranda isim ve s¸ifre is- ¨
tenir.Ardından bu degerler kontrol edilir e ˘ ger oyuncu veya ˘
yonetici tabloları kontrol edilir e ¨ ger kullanıcı varsa giris¸ yapılır ˘
yoksa is¸lem bas¸arısız olur.Ayrıca burada oyuncunun kaynakları
kontrol edilir eger t ˘ ukenmis¸se giris¸ yapmasına izin verilmez. ¨
B. Kayıt Olma
Kayıt olma ekranında kullanıcıdan bilgiler alınır.Ardından
metaLand adlı Db de kullanıcı tablosuna kaydedilir.Ve kul-
lanıcıya kayıt olus¸turuldu bilgisi verilir.
C. kullanıcı panel
Burada yoneticiye harita id sorulur.Ve Sec¸ilen harita ¨
ekrana verilir.Kontrol ekranında yonetici harita numarasını ¨
ve boyutunu girerek harita olus¸turabilir.Haritaya kayıtlı
olanları sorgular ve gun sonunu verir.Oyuncu panelinden ¨
farkı kontrol kısmıdır.Menkullerim kısmında kullanıcıya
ait menkuller bilgileriyle birlikte verilir.Ve bu ekranda
kis¸i menkul sec¸ip satabilir.Ayrıca burada menkul ins¸a
edilebilir.Varlıklar kısmında kis¸inin yemek para ve
es¸ya miktarı gosterilir. ¨
˙Is¸ talebi kısmında is¸ ilanları
gor¨ unt ¨ ulenebilir uygunsa kabul edilebilir de ¨ gilse pazarlık ˘
yapılabilir.Pazar kısmında satılıktaki menkuller satın alınabilir.
D. harita-oyun
Harita uzerinde gezinme yapılabili, be ¨ genilen ya da sec¸ilen ˘
yerlerin satın alımı yapılabilir is bas¸vurusunda bulunulabilir.
’turVer’ adlı y ¨ ontem, ’alanNo’ adlı bir tamsayı parametresi ¨
alır. Saglanan ba ˘ glantı dizesini kullanarak bir SQL verita- ˘
banına baglanır, bir ba ˘ glantı ac¸ar ve ’alaninfo’ adlı bir tablodan ˘
veri sec¸mek ic¸in bir SQL komutu c¸alıs¸tırır. Komut, ’alanharita’
alanının degeri ’singleton.haritaID’ de ˘ gis¸keninin de ˘ gerine es¸it ˘
ve ’alanno’ alanının degeri sa ˘ glanan ’alanNo’ parametresine ˘
es¸it olan tum verileri sec¸er. ¨
Tabloda es¸les¸en bir kayıt bulunursa, yontem kayıttan ¨
’alantur¨ u’ alanının de ¨ gerini alır, bir dizeye d ˘ on¨ us¸t ¨ ur¨ ur ve ¨
’returnValue’ adlı bir degis¸kene atar. Son olarak, veritabanı ˘
baglantısını kapatır ve ’returnValue’ de ˘ gerini d ˘ ond ¨ ur¨ ur. ¨
’fiyatver’ methodu bir tamsayı ve bir dize parametresi alır.
Baglantı dizesini kullanarak bir SQL veritabanına ba ˘ glanır, ˘
bir baglantı ac¸ar ve ’alanT ˘ ur’ parametresinin de ¨ gerine g ˘ ore ¨
’magaza’ veya ’market’ tablosundan veri sec¸mek ic¸in bir SQL
komutu c¸alıs¸tırır. Komut, ’magazaharita’ veya ’marketharita’
alanının degeri ’singleton.haritaID’ de ˘ gis¸keninin de ˘ gerine es¸it ˘
ve ’magazano’ veya ’marketno’ alanının degeri sa ˘ glanan ˘
’alanNo’ parametresine es¸it olan tum verileri sec¸er. ¨
Tabloda es¸les¸en bir kayıt bulunursa, yontem kayıttan ’mag- ¨
azaucret’ veya ’market ¨ ucret’ alanının de ¨ gerini alır, bir diz- ˘
eye don¨ us¸t ¨ ur¨ ur ve ’returnValue’ adlı bir de ¨ gis¸kene atar. Son ˘
olarak, veritabanı baglantısını kapatır ve ’returnValue’ de ˘ gerini ˘
dond ¨ ur¨ ur. ¨
Yani bu method, saglanan ’alanNo’ parametresine ve ˘
’alanTur’ parametresine ba ¨ glı olarak bir SQL veritabanı ˘
tablosundan fiyat degerini alır. ’y ˘ oneticibilgiver’ methodu ¨
’talepbilgi’ adlı bir dize parametresi alır ve kullanıcının
’esyamiktarı’ veya ’yemekmiktarı’ degerlerini d ˘ ond ¨ ur¨ ur. ¨
Baglantı dizesini kullanarak bir SQL veritabanına ba ˘ glanır ˘
ve ’kullanıcıinfo’ tablosundan ’kullanıcıadı’ alanı ’singleton.oyuncuAd’ degis¸keninin de ˘ gerine es¸it olan verileri sec¸mek ˘
ic¸in bir SQL komutu c¸alıs¸tırır.
Eger ’talepbilgi’ de ˘ geri ’esya’ ise, SQL komutu ’esyamik- ˘
tarı’ alanının degerini sec¸er; e ˘ ger ’talepbilgi’ de ˘ geri ’yemek’ ˘
ise, SQL komutu ’yemekmiktarı’ alanının degerini sec¸er. ˘
Daha sonra, SQLDataReader nesnesi ile kayıtlar okunur ve
bulunan kayıtlarda ’esyamiktarı’ veya ’yemekmiktarı’ degeri ˘
’returnValue’ degis¸kenine atanır. Bu de ˘ ger son olarak bir ˘
tamsayıya don¨ us¸t ¨ ur¨ ul¨ ur ve ’returnValue’ olarak d ¨ ond ¨ ur¨ ul¨ ur. ¨
Son olarak, veritabanı baglantısı kapatılır. ˘
Bu method, kullanıcının es¸ya veya yemek miktarını
dond ¨ ur¨ ur ve bu bilgilerin di ¨ ger is¸lemlerde kullanılması ic¸in ˘
kullanılabilir.
”yoneticiParaAzalt()” methodu, ¨ oncelikle bir SqlConnec- ¨
tion objesi olus¸turur ve baglantı dizesini kullanarak bir SQL ˘
veritabanına baglanır. Daha sonra, ”y ˘ oneticiParaBul()” adlı ¨
bas¸ka bir method kullanarak yoneticinin parasını bulur ve bir ¨
degis¸kene atar. Ardından, kullanıcının sec¸ti ˘ gi˘ ur¨ un adetini ve ¨
fiyatını kullanarak hesaplayarak, kullanıcının parasını azaltır
ve veritabanına kaydeder.
”yoneticiParaBul()” methodu ise, bir tamsayı de ¨ geri ˘
dond ¨ ur¨ ur ve bir SqlConnection objesi olus¸turur. Daha sonra, ¨
baglantı dizesini kullanarak bir SQL veritabanına ba ˘ glanır ve ˘
bir SQL komutu c¸alıs¸tırarak yoneticinin parasını bulur. Bu ¨
degeri bir de ˘ gis¸kene atar, veritabanı ba ˘ glantısını kapatır ve ˘
degis¸keni d ˘ ond ¨ ur¨ ur. ¨
Bu iki method birlikte c¸alıs¸arak, kullanıcının ur¨ un satın ¨
alma is¸lemleri sırasında, yoneticinin parasını azaltmaktadır. Bu ¨
sayede, kullanıcıların alıs¸veris¸ yaparken yeterli miktarda para
olup olmadıgını kontrol etmek ic¸in bu method kullanılabilir. ˘
Yoneticinin parasını azaltmak ic¸in kullanılan bu method, ¨
diger is¸lemler ic¸in de kullanılabilir. ˘ Orne ¨ gin, y ˘ oneticinin para ¨
miktarını kontrol etmek ic¸in ”yoneticiParaBul()” methodu kul- ¨
lanılabilir. Bu sayede, yoneticinin para miktarı de ¨ gis¸ti ˘ ginde, ˘
diger is¸lemlerde bu de ˘ gis¸iklikten yararlanılabilir. ˘
Overall, bu method, kullanıcının ur¨ un satın alma is¸lemleri ¨
sırasında yoneticinin parasını azaltmak ic¸in kullanılabilir ¨
ve yoneticinin para miktarını kontrol etmek ic¸in de di ¨ ger ˘
is¸lemlerde kullanılabilir. Bu sayede, daha iyi bir alıs¸veris¸
deneyimi saglanabilir ve is¸lemler daha akıcı hale getirilebilir. ˘
’sahiparaartır’ methodu bir kullanıcının veya yoneticinin ¨
parasını artırmak ic¸in tasarlanmıs¸tır. Method, ”sahipBul()” adlı
bir method kullanarak oncelikle kullanıcının veya y ¨ oneticinin ¨
kimligini belirler ve bir de ˘ gis¸kene atar. Daha sonra, kul- ˘
lanıcının sec¸tigi˘ ur¨ un adetini ve fiyatını kullanarak hesapla- ¨
yarak, kullanıcının parasını arttırır ve veritabanına kaydeder.
Bu method, kullanıcının veya yoneticinin parasını arttırmak ¨
ic¸in kullanılabilir ve bu bilgilerin diger is¸lemlerde kullanılması ˘
ic¸in kullanılabilir. Yonetici veya kullanıcı kimli ¨ gine ba ˘ glı ˘
olarak, ”yoneticiinfo” veya ”kullanıcıinfo” tablolarından il- ¨
gili alanlar sec¸ilir ve kullanıcının parası ”paramiktarı” veya
”yoneticipara” alanına kaydedilir. ¨
Overall, bu method, kullanıcının veya yoneticinin parasını ¨
arttırmak ic¸in kullanılabilir ve diger is¸lemlerde kullanılabilir. ˘
Bu sayede, daha iyi bir alıs¸veris¸ deneyimi saglanabilir ve ˘
is¸lemler daha akıcı hale getirilebilir.
’kullanıcıparabul’ methodu, veritabanında kullanıcı adı
’alanSahip.Text’ olan kullanıcının para miktarını dond ¨ ur¨ ur. ¨
Veritabanına baglanarak, ’kullanıcıinfo’ tablosundan kul- ˘
lanıcının para miktarını sec¸er ve bir degis¸kene atar. Bu ˘
degis¸ken son olarak bir tamsayıya d ˘ on¨ us¸t ¨ ur¨ ul¨ ur ve ’return- ¨
Value’ olarak dond ¨ ur¨ ul¨ ur. ¨
Bu method, kullanıcının para miktarını kontrol etmek ic¸in
kullanılabilir ve diger is¸lemlerde de kullanılabilir. ˘ Orne ¨ gin, ˘
kullanıcının para miktarına baglı olarak, kullanıcının ala- ˘
bilecegi˘ ur¨ unlerin sayısı kontrol edilebilir. Bu sayede, daha ¨
iyi bir alıs¸veris¸ deneyimi saglanabilir ve is¸lemler daha akıcı ˘
hale getirilebilir.
‘sahipBul()‘ methodu, veritabanında yonetici adı ¨
’alanSahip.Text’ olan yoneticinin veya kullanıcının kimli ¨ gini ˘
belirler ve bir dize olarak dond ¨ ur¨ ur. Ba ¨ glantı dizesini ˘
kullanarak bir SQL veritabanına baglanır ve ’y ˘ oneticiinfo’ ¨
tablosundan ’yoneticiad’ alanı sa ¨ glanan ’alanSahip.Text’ ˘
degerine es¸it olan verileri sec¸mek ic¸in bir SQL komutu ˘
c¸alıs¸tırır. ’COUNT(*)’ fonksiyonu kullanılarak kayıtlar sayılır
ve sayı degeri bir de ˘ gis¸kene atanır. E ˘ ger kayıt sayısı 0’dan ˘
buy¨ ukse, y ¨ onetici kimli ¨ gi belirlenir ve ’y ˘ onetici’ dizesi ¨
dond ¨ ur¨ ul¨ ur; aksi takdirde, kullanıcı kimli ¨ gi belirlenir ve ˘
’kullanıcı’ dizesi dond ¨ ur¨ ul¨ ur. ¨
Bu method, kullanıcının veya yoneticinin kimli ¨ gini belir- ˘
lemek ic¸in kullanılabilir ve diger is¸lemlerde de kullanılabilir. ˘
Orne ¨ gin, y ˘ onetici veya kullanıcı kimli ¨ gine ba ˘ glı olarak, ˘
yonetici veya kullanıcı ¨ ozelliklerine eris¸im kontrol edilebilir. ¨
Bu sayede, daha iyi bir kullanıcı deneyimi saglanabilir ve ˘
is¸lemler daha akıcı hale getirilebilir.
’ur¨ unalclick’ methodu, kullanıcının ¨ ur¨ un satın alma ¨
is¸lemlerindeki temel is¸levleri gerc¸ekles¸tirir. Oncelikle, kul- ¨
lanıcının sec¸tigi˘ ur¨ un t ¨ ur¨ une (ma ¨ gaza ya da market) ve adetine ˘
gore, kullanıcının parasını azaltır ve ¨ ur¨ un miktarını artırır. ¨
Bu is¸lem, oncelikle ‘y ¨ oneticiBilgiVer()‘ methodunu kul- ¨
lanarak, kullanıcının sec¸tigi˘ ur¨ un¨ un fiyatını ve t ¨ ur¨ un¨ u¨
belirler. Daha sonra, kullanıcının parasını azaltmak ic¸in
‘yoneticiParaAzalt()‘ methodunu c¸a ¨ gırır ve kullanıcının ˘
parasını gunceller. ¨
Ardından, kullanıcının sec¸tigi˘ ur¨ un miktarını ‘ ¨ ur¨ unAdet‘ ¨
parametresinde belirleyerek, ‘kullanıcıinfo‘ tablosundaki
‘esyamiktarı‘ veya ‘yemekmiktarı‘ alanını gunceller. Bu ¨
is¸lem, ‘Update‘ SQL komutunu kullanarak gerc¸ekles¸tirilir.
Son olarak, kullanıcının parasını artırmak ic¸in ‘sahipParaArtır()‘ methodunu c¸agırır ve is¸lemin bas¸arılı oldu ˘ gunu ˘
belirten bir mesaj kutusu gor¨ unt ¨ uler. ¨
Bu method, kullanıcının ur¨ un satın alma is¸lemlerini ¨
gerc¸ekles¸tirmesini saglayarak, alıs¸veris¸ deneyimini daha iyi ˘
hale getirir ve is¸lemleri daha akıcı hale getirir. Ayrıca,
yoneticinin parasını kontrol etmek ic¸in ‘y ¨ oneticiParaBul()‘ ¨
methodu ve kullanıcının para miktarını kontrol etmek ic¸in
‘kullanıcıParaKontrol()‘ methodu gibi diger methodlarla bir- ˘
likte kullanılabilir.
Overall, bu method, bir alıs¸veris¸ is¸lemi sırasında gereken
temel is¸levleri yerine getirerek, kullanıcıların daha iyi bir
alıs¸veris¸ deneyimi yas¸amasını saglar ve is¸lemlerin daha hızlı ˘
ve akıcı bir s¸ekilde gerc¸ekles¸tirilmesini saglar. ˘
’isbasvuruonaylaclick’ methodu, bir is¸ bas¸vurusu bilgisi
olus¸turmak ic¸in kullanılır. ˙Is¸ bas¸vuruları, ”basvuruinfo” adlı
bir tabloda saklanır ve bu method, saglanan parametreleri ˘
kullanarak yeni bir is¸ bas¸vurusu kaydı olus¸turur.
Oncelikle, SqlConnection nesnesi olus¸turulur ve ba ¨ glantı ˘
dizesi kullanılarak bir SQL veritabanına baglanılır. Daha ˘
sonra, ”basvuruinfo” tablosuna yeni bir kayıt eklemek ic¸in bir
SQL INSERT komutu c¸alıs¸tırılır.
Komut, saglanan parametreleri kullanarak, ”basvuruno”, ˘
”basvuruisim”, ”basvurusaat”, ”basvuruucret”,
”basvurualansahip”, ”basvurualanno” ve ”basvurualanharita”
alanlarını doldurur.
Son olarak, SqlCommand nesnesi kullanılarak komut
c¸alıs¸tırılır ve is¸lem bas¸arılı oldugunda bir mesaj kutusu ˘
gor¨ unt ¨ ulenir. ¨
Bu method, yeni bir is¸ bas¸vurusu kaydı olus¸turmak ic¸in kullanılır. ˙Is¸ bas¸vuruları, ”basvuruinfo” adlı bir tabloda saklanır
ve bu method, saglanan parametreleri kullanarak yeni bir is¸ ˘
bas¸vurusu kaydı olus¸turur.
E. UML diyagramı :
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

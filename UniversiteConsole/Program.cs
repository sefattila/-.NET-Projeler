/*
 * Bir üniversite uygulaması olsun. Burada öğretmenler ders anlatıyor, öğrenciler ders alıyor ve güvenlikler üniversiteyi koruyor.
 * Bir derste en fazla 10 öğrenci olabilir.
 * Öğrenciler aldıkları dersi zorluk derecesine göre puanlıyor.
 * Her dersin zorluk derecesi öğrencilerin verdiği puanlarla belirleniyor.
 * Öğretmenler ders süresi boyunca başka bir derste bulunamaz ve alanı dışında ders anlatamaz.
 */
 //burda sadece class yapısının doğru çalışıp çalışmadığını kontrol ettik bizim amacımız nesne yapısını yazmaktı main kısmı yapmak değil
using UniversiteClassLibrary.Concrete;
using UniversiteClassLibrary.Enums;

Ders ders = new Ders();
ders.Alan = "matematik";
Ders ders1 = new Ders();
ders1.Alan = "yazılım";


Ogretmen ogretmen = new Ogretmen();
ogretmen.AdSoyad = "Erdinç Hoca";
ogretmen.Alan = "matematik";
ogretmen.Durum = Durum.Müsait;

Ogrenci ogrenci = new Ogrenci();
ogrenci.AdSoyad = "Sefa Attila";
ogrenci.Dersler.Add(ders);
//ogrenci.Dersler.Add(ders1);

ders.Ogretmen = ogretmen;
Console.WriteLine(ders.DersIsle());
Console.WriteLine(ders.DersBitir());

ders1.Ogretmen= ogretmen;
Console.WriteLine(ders1.DersIsle());

ogrenci.DersiPuanla(ders1, 8);



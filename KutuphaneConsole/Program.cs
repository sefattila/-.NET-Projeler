using KutuphaneClassLibrary.Abstract;
using KutuphaneClassLibrary.Concrete;
using KutuphaneClassLibrary.Enums;



Kitap kitap1 = new Kitap("123456", "ATTILA", "John Man", new DateTime(2010, 5, 12));

Kitap kitap2 = new Kitap("13312", "EFSANE", "Man", new DateTime(2000, 5, 12));

Kitap kitap3 = new Kitap("121321", "SEFA", "John", new DateTime(2008, 5, 12));

Kitap kitap4 = new Kitap("1231123", "OD", "Sefa", new DateTime(1998, 5, 12));

Kutuphane kutuphane = new Kutuphane();

Uye uye1 = new Uye();
uye1.UyeID = "111";
uye1.AdSoyad = "Sefa Attila";

Uye uye2 = new Uye();
uye2.UyeID = "111";
uye2.AdSoyad = "Ahmet Yesevi";

kutuphane.Kitaplar.Add(kitap1);
kutuphane.Kitaplar.Add(kitap2);
kutuphane.Kitaplar.Add(kitap3);
kutuphane.Kitaplar.Add(kitap4);
kutuphane.Uyeler.Add(uye1);
kutuphane.Uyeler.Add(uye2);

Console.WriteLine(kutuphane.KitapOduncVer(uye1, kitap1));
Console.WriteLine(uye1.UyeKitaplariGoruntule());
Console.WriteLine(kutuphane.UyeleriGoruntule());
Console.WriteLine(kutuphane.KutuphaneDurumGoruntule());
Console.WriteLine(kutuphane.OduncAlinanKitaplar());

//Console.WriteLine(kutuphane.KutuphaneDurumGoruntule());
//Console.WriteLine(kutuphane.KitapIadeEt(uye1,kitap1));
//Console.WriteLine(kutuphane.KutuphaneDurumGoruntule());
//Console.WriteLine(kutuphane.KitapOduncVer(uye1, kitap2));
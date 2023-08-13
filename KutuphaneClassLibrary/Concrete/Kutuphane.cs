using KutuphaneClassLibrary.Abstract;
using KutuphaneClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClassLibrary.Concrete
{
    public class Kutuphane : IKutuphane
    {
        public List<IUye> Uyeler { get; set; } = new List<IUye>();
        public List<IKitap> Kitaplar { get; set; } = new List<IKitap>();
        public List<ICalisan> Calisanlar { get; set; } = new List<ICalisan>();

        public string UyeleriGoruntule()
        {
            string _uyeler = string.Empty;
            foreach (Uye uye in Uyeler)
            {
                _uyeler += uye.AdSoyad+"\n";
            }
            return "Kayıtlı Üyeler:\n"+_uyeler;
        }

        public string KitapIadeEt(Uye uye, Kitap kitap)
        {
            if (Kitaplar.Contains(kitap))
            {
                uye.OduncAlinanKitaplar.Remove(kitap);
                kitap.Durum = Durum.ÖdünçAlınabilir;
                return $"{uye.AdSoyad} {kitap.KitapAdi} Adlı Kitabı İade Etti";
            }
            else return $"Bu kitap Kütüphaneye Ait Değil";
        }

        public string KitapOduncVer(Uye uye, Kitap kitap)
        {
            if (Uyeler.Contains(uye))
            {
                if (Kitaplar.Contains(kitap))
                {
                    switch (kitap.Durum)
                    {
                        case Durum.ÖdünçAlınabilir:
                            kitap.Durum = Durum.ÖdünçVerildi;
                            uye.OduncAlinanKitaplar.Add(kitap);
                            return $"{kitap.KitapAdi} {uye.AdSoyad} Kişisine Verildi";
                        case Durum.ÖdünçVerildi:
                            return $"{kitap.KitapAdi} Adlı Kitap Başka Bir Üyede";
                        default:
                            throw new Exception("Kitap Durumu Hatası");
                    }

                }
                else return "Kitap Mevcut Değil";
            }
            else return "Kütüphaneye Üye Değilsin. Kitap Alamazsın";
        }

        public string KutuphaneDurumGoruntule()
        {
            string _kitaplar = string.Empty;
            foreach (Kitap kitap in Kitaplar)
            {
                _kitaplar += $"{kitap.KitapAdi} {kitap.Durum}\n";
            }
            return "Kütüphanedeki Kitaplar:\n" + _kitaplar;
        }
        public string OduncAlinanKitaplar()
        {
            string _oduncVerilenKitaplar = string.Empty;
            if (Kitaplar.Count > 0)
            {
                foreach (Kitap kitap in Kitaplar)
                {
                    if (kitap.Durum == Durum.ÖdünçVerildi)
                    {
                        _oduncVerilenKitaplar += $"{kitap.KitapAdi}\n";
                    }
                }
            }
            else return "Ödünç Verilen Kitap Yoktur";
            return "Ödünç Verilen Kitaplar:\n" + _oduncVerilenKitaplar;
        }
    }
}
















//public string UyeKitaplariGoruntule(Uye uye)
//{
//    string _uyeKitaplari = string.Empty;
//    foreach (Kitap kitap in uye.OduncAlinanKitaplar)
//    {
//        _uyeKitaplari += $"{kitap.KitapAdi}\n";
//    }
//    return $"{uye.AdSoyad} Adlı Kişinin Aldığı Kitaplar:\n" + _uyeKitaplari;
//}
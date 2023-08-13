using KutuphaneClassLibrary.Abstract;
using KutuphaneClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClassLibrary.Concrete
{
    public class Kitap:IKitap
    {
        public Kitap(string ıSBN, string kitapAdi, string yazar, DateTime yayinYili)
        {
            this.ISBN = ıSBN;
            this.KitapAdi = kitapAdi;
            this.Yazar = yazar;
            this.YayinYili = yayinYili;
            this.Durum = Durum.ÖdünçAlınabilir;
        }

        public string ISBN { get ; set ; }
        public string KitapAdi { get ; set ; }
        public string Yazar { get ; set ; }
        public DateTime YayinYili { get ; set ; }
        public Durum Durum { get ; set ; }

        //public Durum KitapDurumKontrol()
        //{
        //    switch (Durum)
        //    {
        //        case Durum.ÖdünçAlınabilir:
        //            return Durum.ÖdünçAlınabilir;
        //        case Durum.ÖdünçVerildi:
        //            return Durum.ÖdünçVerildi;
        //        case Durum.MevcutDeğil:
        //            return Durum.MevcutDeğil;
        //        default:
        //            throw new Exception("Hata");
        //    }
        //}
    }
}

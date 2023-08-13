using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteClassLibrary.Abstract;
using UniversiteClassLibrary.Enums;

namespace UniversiteClassLibrary.Concrete
{
    public class Ogretmen : BaseKisi, ICalisan
    {
        public DateTime IseGirisTarihi { get; set; }
        public decimal Maas { get; set; }
        public Durum Durum { get; set; }
        public string Alan { get; set; }

        public string DersVer()
        {
            this.Durum = Durum.Meşgul;
            return  $"{base.AdSoyad} {this.Alan} Dersini Anlatmaktadır.";
        }
        public string DersiBitir()
        {
            this.Durum = Durum.Müsait;
            return $"{base.AdSoyad} {this.Alan} Dersini Anlattı.";
        }

        public bool MusaitMi()
        {
            return this.Durum == Durum.Müsait ? true : false;
        }
    }
}

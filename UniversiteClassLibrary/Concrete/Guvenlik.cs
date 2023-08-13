using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteClassLibrary.Abstract;

namespace UniversiteClassLibrary.Concrete
{
    public class Guvenlik : BaseKisi, ICalisan
    {
        public DateTime IseGirisTarihi { get ; set ; }
        public decimal Maas { get ; set ; }

        public string Koru()
        {
            return $"{AdSoyad} Korudu";
        }
    }
}

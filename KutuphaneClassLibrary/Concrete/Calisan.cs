using KutuphaneClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClassLibrary.Concrete
{
    public class Calisan:BaseKisi,ICalisan
    {
        public decimal Maas { get; set; }
        public DateTime İseGirisTarihi { get; set; }
    }
}

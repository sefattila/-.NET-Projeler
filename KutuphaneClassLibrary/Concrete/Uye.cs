using KutuphaneClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClassLibrary.Concrete
{
    public class Uye :BaseKisi, IUye
    {
        public string UyeID { get ; set ; }
        public List<IKitap> OduncAlinanKitaplar { get ; set ; }=new List<IKitap>();

        public string UyeKitaplariGoruntule()
        {
            string _uyeKitaplari = string.Empty;
            foreach (Kitap kitap in OduncAlinanKitaplar)
            {
                _uyeKitaplari += $"{kitap.KitapAdi}\n";
            }
            return $"{AdSoyad} Adlı Kişinin Aldığı Kitaplar:\n" + _uyeKitaplari;
        }
    }
}

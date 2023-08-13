using KutuphaneClassLibrary.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClassLibrary.Abstract
{
    public interface IKutuphane
    {
        List<IUye> Uyeler { get; set; }
        List<IKitap> Kitaplar { get; set; }

        string UyeleriGoruntule();
        string KitapIadeEt(Uye uye, Kitap kitap);
        string KitapOduncVer(Uye uye, Kitap kitap);
        string KutuphaneDurumGoruntule();
        string OduncAlinanKitaplar();
        //string UyeKitaplariGoruntule(Uye uye);
    }
}

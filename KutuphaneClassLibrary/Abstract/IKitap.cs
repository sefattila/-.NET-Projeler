using KutuphaneClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClassLibrary.Abstract
{
    public interface IKitap
    {
        string ISBN { get; set; }
        string KitapAdi { get; set; }
        string Yazar { get; set; }
        DateTime YayinYili { get; set; }
        Durum Durum { get; set; }

    }
}

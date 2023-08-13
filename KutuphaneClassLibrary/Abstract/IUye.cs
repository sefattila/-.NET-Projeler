using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClassLibrary.Abstract
{
    public interface IUye
    {
        string AdSoyad { get; set; }
        string UyeID { get; set; }
        List<IKitap> OduncAlinanKitaplar { get; set; }
    }
}

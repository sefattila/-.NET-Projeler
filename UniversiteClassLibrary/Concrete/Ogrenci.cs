using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteClassLibrary.Abstract;

namespace UniversiteClassLibrary.Concrete
{
    public class Ogrenci:BaseKisi
    {
        public string OkulNo { get; set; }
        public List<Ders> Dersler { get; set; } = new List<Ders>();

        public void DersAl(Ders ders)
        {
            if (ders.DerseOgrEkle(this))
            {
                this.Dersler.Add(ders);
            }
            else throw new Exception("Ogrenci Dersi Alamadı Ders Dolu");
        }
        public void DersiPuanla(Ders ders,int puan)
        {
            if (Dersler.Contains(ders))
            {
                ders.ZorlukDerecesiHesapla(puan);
            }
            else throw new Exception("Öğrenci almadığı dersi puanlayamaz");
        }
    }
}

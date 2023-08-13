using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteClassLibrary.Enums;

namespace UniversiteClassLibrary.Concrete
{
    public class Ders
    {
        private double _toplamPuan;
        private int _ogrSayisi;
        public Ogretmen Ogretmen { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
        public int ZorlukDerecesi { get; private set; }
        public string Alan { get; set; }

        public bool DerseOgrEkle(Ogrenci ogrenci)
        {
            if (Ogrenciler.Count < 10)
            {
                Ogrenciler.Add(ogrenci);
                return true;
            }
            else return false;
        }
        public string DersIsle()
        {
            string dersDurumu=string.Empty;
            if (Ogretmen.Alan == this.Alan && Ogretmen.MusaitMi())
            {
                dersDurumu = Ogretmen.DersVer();

            }
            else return "Öğretmen müsait değil veya istenilen ders alan dersi değil";
            return dersDurumu;
        }

        public string DersBitir()
        {
            return Ogretmen.DersiBitir();
        }
        public void ZorlukDerecesiHesapla(int puan)
        {
            _toplamPuan += puan;
            _ogrSayisi++;
            ZorlukDerecesi = (int)_toplamPuan / _ogrSayisi;
        }
    }
}

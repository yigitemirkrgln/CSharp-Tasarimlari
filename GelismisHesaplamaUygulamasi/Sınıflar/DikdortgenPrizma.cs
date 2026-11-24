using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanCevreClass.Sınıflar
{
    public class DikdortgenPrizma
    {
        public double yukseklik, genislik, uzunluk;

        public DikdortgenPrizma(double a, double b, double h)
        {
            uzunluk = a;
            genislik = b;
            yukseklik = h;
        }

        public double HacimHesapla()
        {
            return uzunluk * genislik * yukseklik;
        }

        public double YuzeyAlaniHesapla()
        {
            return 2 * ((uzunluk * genislik) + (uzunluk * yukseklik) + (genislik * yukseklik));
        }

        public double AyritToplamlariHesapla()
        {
            return 4 * (uzunluk + genislik + yukseklik);

        }
    }
}

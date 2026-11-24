using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanCevreClass.Sınıflar
{
    public class UcgenPrizma
    {
        public double k1, k2, k3, taban, yukseklik, prizmaYuksekligi;

        public UcgenPrizma(double kenar1, double kenar2, double kenar3, double tabanKenar, double tabanYukseklik, double hPrizma)
        {
            k1 = kenar1;
            k2 = kenar2;
            k3 = kenar3;
            taban = tabanKenar;
            yukseklik = tabanYukseklik;
            prizmaYuksekligi = hPrizma;
        }

        public double TabanAlaniHesapla()
        {
            return (taban * yukseklik) / 2.0;
        }

        public double YanalAlanHesapla()
        {
            double tabanCevresi = k1 + k2 + k3;
            return tabanCevresi * prizmaYuksekligi;
        }

        public double YuzeyAlaniHesapla()
        {
            return (2 * TabanAlaniHesapla()) + YanalAlanHesapla();
        }

        public double HacimHesapla()
        {
            return TabanAlaniHesapla() * prizmaYuksekligi;
        }
    }
}

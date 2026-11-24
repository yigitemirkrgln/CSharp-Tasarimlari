using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanCevreClass.Sınıflar
{
    public class Ucgen
    {
        public double k1, k2, k3, taban, yukseklik;

        public Ucgen(double a, double b, double c, double h, double p)
        {
            k1 = a; 
            k2 = b; 
            k3 = c;
            taban = p;
            yukseklik = h;

        }

        public double CevreHesapla()
        {
            return k1 + k2 + k3;
        }

        public double AlanHesapla(double taban, double yukseklik)
        {
            return (taban * yukseklik) / 2.0;
        }
    }
}

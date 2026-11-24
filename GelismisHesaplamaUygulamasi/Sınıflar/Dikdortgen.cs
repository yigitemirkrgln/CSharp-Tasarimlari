using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanCevreClass.Sınıflar
{
    public class Dikdortgen
    {
        public double kisaKenar, uzunKenar;

        public Dikdortgen(double kisa,double uzun)
        {
            kisaKenar = kisa;
            uzunKenar = uzun;
        }

        public double CevreHesapla()
        {
            return 2 * (kisaKenar + uzunKenar);
        }

        public double AlanHesapla()
        {
            return kisaKenar * uzunKenar;
        }
    }
}

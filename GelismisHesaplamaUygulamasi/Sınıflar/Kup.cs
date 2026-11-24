using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanCevreClass.Sınıflar
{
    public class Kup
    {
        public double ayrit;

        public Kup(double a)
        {
            ayrit = a;
        }

        public double HacimHesapla()
        {
            return Math.Pow(ayrit, 3);
        }

        public double YuzeyAlaniHesapla()
        {
            return 6*Math.Pow(ayrit, 2);
        }

        public double AyritToplamiHesapla()
        {
            return 12 * ayrit;
        }

        public double YuzeyKosegeniHesapla()
        {
            return ayrit * Math.Sqrt(2);
        }

        public double CisimKosegeniHesapla()
        {
            return ayrit * Math.Sqrt(3);
        }
    }
}

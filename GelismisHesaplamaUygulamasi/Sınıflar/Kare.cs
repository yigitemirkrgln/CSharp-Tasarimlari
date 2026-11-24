using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanCevreClass.Sınıflar
{
    public class Kare
    {
        public double kenar;

        public Kare(double a)
        {
            kenar = a;
        }

        public double CevreHesapla()
        {
            return kenar * 4;
        }

        public double AlanHesapla()
        {
            return kenar * kenar;
        }

        public double KosegenHesapla()
        {
            return kenar * Math.Sqrt(2);
        }
    }
}

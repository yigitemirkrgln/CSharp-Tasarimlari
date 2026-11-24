    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanCevreClass.Sınıflar
{
    public class Daire
    {
        public double yaricap;

        public Daire(double r)
        {
            yaricap = r;
        }

        public double CevreHesapla()
        {
            return 2*Math.PI*yaricap;
        }

        public double AlanHesapla()
        {
            return Math.PI*Math.Pow(yaricap, 2);
        }
    }
}

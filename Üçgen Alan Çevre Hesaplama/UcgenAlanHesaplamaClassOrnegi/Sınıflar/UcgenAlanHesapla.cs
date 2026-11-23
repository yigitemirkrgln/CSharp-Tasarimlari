using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenAlanHesaplamaClassOrnegi.Sınıflar
{
    public class UcgenAlanHesapla
    {
        public int _taban;
        public int _yukseklik;

        public int AlanHesabi()
        {
            return (_taban * _yukseklik) / 2;
        }
    }
}

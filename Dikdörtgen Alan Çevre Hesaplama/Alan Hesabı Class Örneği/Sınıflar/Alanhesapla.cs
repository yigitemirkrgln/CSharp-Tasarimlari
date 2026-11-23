using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesabı_Class_Örneği.Sınıflar
{
    public class DikdortgenAlan
    {
        public int KisaKenar;
        public int UzunKenar;

        public int AlanHesapla()
        {
            return UzunKenar * KisaKenar;
        }
    }
}

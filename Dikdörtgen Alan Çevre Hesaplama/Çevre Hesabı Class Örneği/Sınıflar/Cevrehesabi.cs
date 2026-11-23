using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çevre_Hesabı_Class_Örneği.Sınıflar
{
    public class Cevrehesabi
    {
        public int UzunKenar;
        public int KisaKenar;

        public int Cevre()
        {
            return 2 * (KisaKenar + UzunKenar);
        }
    }
}

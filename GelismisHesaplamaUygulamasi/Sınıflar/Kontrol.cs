using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KareAlanCevreClass.Sınıflar
{
    public class Kontrol
    {
        public bool Bosluk(string metin)
        {
            return string.IsNullOrWhiteSpace(metin);
        }

        public bool PozitifSayi(string metin)
        {
            if (Bosluk(metin))
            {
                return false;
            }
            try
            {
                double sayi = Convert.ToDouble(metin);

                if (sayi > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool RakamKontrol(string metin)
        {
            if (Bosluk(metin))
            {
                return false;
            }

            for (int i = 0; i < metin.Length; i++)
            {
                char karakter = metin[i];

                if (!char.IsDigit(karakter))
                {
                    return false;
                }

            }
            return true;
        }

        public bool KenarKontrol(double kisakenar, double uzunkenar)
        {
            if (kisakenar < uzunkenar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UcgenKenarKontrol(double kenar1, double kenar2, double kenar3)
        {
            if ((kenar1 + kenar2 > kenar3) && (kenar1 + kenar3 > kenar2) && (kenar2 + kenar3 > kenar1))
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal class EskenarUcgen
    {
        int kenar;

        EskenarUcgen(int kenar)
        {
            this.kenar = kenar;
        }

        public static void soru()
        {
            Console.WriteLine("1-) Alan Hesapla\n2-) Çevre Hesapla\n3-) Çiz\n4-) Kenar Değiştir\n5-) Karakter Değiştir.\n6-) Dolumu Değiştir \n7-) Bilgileri Yazdır \n8-) Üst Menü\n9-) Çıkış");
        }

        public static int AlanHesapla(int kenar)
        {
            int sonuc = (kenar * kenar) / 2;
            return sonuc;
        }
        public static int CevreHesapla(int kenar)
        {
            return 3 * kenar;
        }

        public static void OzellikYazdir(int kenar)
        {
            Console.WriteLine("Eşkenar Üçgen \n kenar:{0} ",kenar);
        }

        public static void Ciz(char sembol, int kenar)
        {
            for (int i = 0; i < kenar; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(sembol);
                }
                Console.WriteLine();
            }
        }
    }
}

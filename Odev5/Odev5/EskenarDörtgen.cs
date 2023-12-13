using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal class EskenarDörtgen
    {
        int kenar;

        EskenarDörtgen(int kenar)
        {
            this.kenar = kenar;
        }

        public static int AlanHesapla(int kenar)
        {
            return kenar * kenar;
        }

        public static int CevreHesapla(int kenar)
        {
            return 4 * kenar;
        }

        public static void OzellikYazdir(int kenar)
        {
            Console.WriteLine("Eşkenar Dörtgen \n Kenar:{0} ",kenar);
        }
        public static void Ciz(char sembol, int kenar)
        {
            char[,] dizi = new char[kenar, kenar];
            for (int i = 0; i < kenar; i++)
            {
                for (int j = 0; j < kenar; j++)
                {
                    Console.Write(sembol + " ");
                }
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal class Dikdörtgen
    {
        int genislik;
        int yukseklik;

      

       Dikdörtgen(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }

        public static void Soru()
        {
            Console.WriteLine("1-) Alan Hesapla\n2-) Çevre Hesapla\n3-) Çiz\n4-) Genişlik Değiştir\n5-) Uzunluk Değiştir\n6-) Karakter Değiştir.\n7-) Dolumu Değiştir \n8-) Bilgileri Yazdır\n9-) Üst Menü \n 10-çıkış");
        }
        public static int AlanHesapla(int genislik, int yukseklik)
        {     
            return genislik*yukseklik;
        }
        public static int CevreHesapla(int genislik, int yukseklik)
        {
            int sonuc = (2 * genislik) + (2 * yukseklik);
            return sonuc;
        }

        public static void OzellikYazdir(int genislik, int yukseklik)
        {
            Console.WriteLine("Dikdörtgen \n Genişliği: {0} \n Yüksekliği: {1}",genislik, yukseklik);
            
        }
        public static void Ciz(char sembol, int genislik, int yukseklik)
        {
            char[,] dizi = new char[yukseklik, genislik];

            for(int i = 0; i < yukseklik; i++)
            {
                for(int j = 0; j < genislik; j++)
                {
                    Console.Write(sembol+" ");
                }
                Console.WriteLine();
            }
        }
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Hoşgeldiniz!");
            Console.WriteLine("lütfen seçiniz...");

            menu:

            Console.WriteLine("1-Dikdörtgen" + "\n" + "2-Eşkenar üçgen" + "\n" + "3-Eşkenar Dörtgen" + "\n" + "4-çıkış");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1: //dikdörtgen seçimi
                    Console.WriteLine("Dikdörtgenin genişliğini giriniz: ");
                    int genislik = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Dikdörtgenin yüksekliğini giriniz: ");
                    int yukseklik = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("şeklin karakterini giriniz: ");
                    char sekil = Convert.ToChar(Console.ReadLine());
                    DikdEtiket:
                    Dikdörtgen.Soru();
                    int DikdSecim = Convert.ToInt16(Console.ReadLine());

                    switch (DikdSecim)
                    {
                        case 1:
                            Console.WriteLine("ALAN: "+Dikdörtgen.AlanHesapla(genislik,yukseklik));
                            goto DikdEtiket;
                        case 2:
                            Console.WriteLine("ÇEVRE: "+Dikdörtgen.CevreHesapla(genislik, yukseklik));
                            goto DikdEtiket;
                        case 3:
                            Dikdörtgen.Ciz(sekil, genislik, yukseklik);
                            goto DikdEtiket;
                        case 4:
                            Console.WriteLine("Genişliği değiştirin: ");
                            genislik = Convert.ToInt16(Console.ReadLine());
                            goto DikdEtiket;
                        case 5:
                            Console.WriteLine("Yüksekliği değiştirin: ");
                            yukseklik = Convert.ToInt16(Console.ReadLine());
                            goto DikdEtiket;
                        case 6:
                            sekil = Convert.ToChar(Console.ReadLine());
                            goto DikdEtiket;
                        case 7:
                            goto DikdEtiket;
                        case 8:
                            Dikdörtgen.OzellikYazdir(genislik, yukseklik);
                            goto DikdEtiket;
                        case 9:
                            goto menu;
                        case 10:
                            break;
                           
                    }
                    break; // case-1 yani dikdörtgen seçiminin bittiği yer

                case 2://eşkenar üçgen seçimi
                    Console.Write("eşkenar üçgenin kenar uzunluğunu giriniz: ");
                    int kenar = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("şeklin karakterini giriniz: ");
                    char Ucgsembol = Convert.ToChar(Console.ReadLine());
                UcgEtiket:
                    EskenarUcgen.soru();
                    
                    int UcgSecim = Convert.ToInt16(Console.ReadLine());

                    switch (UcgSecim)
                    {
                        case 1:
                            Console.WriteLine("ALAN: " + EskenarUcgen.AlanHesapla(kenar));
                            goto UcgEtiket;
                        case 2:
                            Console.WriteLine("ÇEVRE: " + EskenarUcgen.CevreHesapla(kenar));
                            goto UcgEtiket;
                        case 3:
                            EskenarUcgen.Ciz(Ucgsembol,kenar);
                            goto UcgEtiket;
                        case 4:
                            Console.WriteLine("yeni kenar değerini giriniz: ");
                            kenar = Convert.ToInt16(Console.ReadLine());
                            goto UcgEtiket;
                        case 5:
                            Ucgsembol = Convert.ToChar(Console.ReadLine());
                            goto UcgEtiket;
                        case 6:
                            goto UcgEtiket;
                        case 7:
                            EskenarUcgen.OzellikYazdir(kenar);
                            goto UcgEtiket;
                        case 8:
                            goto menu;
                        case 9:
                            break;

                    }

                    break; // case 2nin yani eşkenar üçgenin bittiği yer

                case 3://eşkenar dörtgen seçimi
                    Console.Write("Eşkenar dötgenin kenarını giriniz: ");
                    int DortgenKenar = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("şeklin karakterini giriniz: ");
                    char Dortgensembol = Convert.ToChar(Console.ReadLine());
                DortgenEtiket:
                    EskenarUcgen.soru();// soruyu tekrar yazmamak için metodumu kullanıyorum.
                    int DortgenSecim = Convert.ToInt16(Console.ReadLine());
                    switch (DortgenSecim)
                    {
                        case 1:
                            Console.Write("ALAN: " + EskenarDörtgen.AlanHesapla(DortgenKenar));
                            goto DortgenEtiket;
                        case 2:
                            Console.Write("ÇEVRE: " + EskenarDörtgen.CevreHesapla(DortgenKenar));
                            goto DortgenEtiket;
                        case 3:
                            EskenarDörtgen.Ciz(Dortgensembol, DortgenKenar);
                            goto DortgenEtiket;
                        case 4:
                            Console.Write("Yeni kenar değerini giriniz: ");
                            DortgenKenar = Convert.ToInt16(Console.ReadLine());
                            goto DortgenEtiket;
                        case 5:
                            Dortgensembol = Convert.ToChar(Console.ReadLine());
                            goto DortgenEtiket;
                        case 6:
                            goto DortgenEtiket;
                        case 7:
                            EskenarDörtgen.OzellikYazdir(DortgenKenar);
                            goto DortgenEtiket;
                        case 8:
                            goto menu;
                        case 9:
                            break;
                        
                    }
                    break;
                case 4:
                    break;
                    
            }
            Console.ReadLine();  
          
        }
        
    }
}

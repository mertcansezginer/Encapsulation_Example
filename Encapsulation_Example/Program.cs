using System;

namespace Encapsulation_Example
{

    class Program
    {
        static void Main(string[] args)
        {
            // BankaHesabi sınıfından bir nesne oluşturduk
            BankaHesabi HesapBilgileri = new BankaHesabi(hesapNumarasi: "41406123", bakiye: 3000);

            
            Console.WriteLine($"Hesap numarası: {HesapBilgileri.HesapNumarasiAl()}");  // Hesap bilgileri yazdırma işlemi
            Console.WriteLine($"Bakiye: {HesapBilgileri.Bakiye} TL");

            
            HesapBilgileri.ParaYatir(400);   // Para yatırma işlemi 

            
            HesapBilgileri.ParaCek(500);     // Para çekme işlemi 

           
            Console.WriteLine($"Yeni bakiye: {HesapBilgileri.Bakiye} TL");  // Yeni bakiye bilgisi yazdırma işlemi
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    internal class BankKontoMenu
    {
        private Kontoinhaber inhaber;

        public BankKontoMenu(Kontoinhaber inhaber)
        {
            this.inhaber = inhaber;
            controller();
        }
        public void controller()
        {
            if (inhaber.Count == 1) EingabeMenu();
            else if (inhaber.Count > 1) RecherMenu();
        }
        public void EingabeMenu()
        {
            Console.Clear();
            Console.WriteLine("=========================================================================");
            Console.WriteLine($"=========              hosgeldiniz sayin {inhaber.Username}    =========");
            Console.WriteLine("\nHesabinizi tamamalamak icin bazi bigilere ihtiyacimiz var");
            Console.WriteLine("\nLütfen adinizi giriniz");string vorname=Console.ReadLine();
            Console.WriteLine("\nLütfen soadinizi giriniz");string nachname=Console.ReadLine();
            Console.WriteLine("\nLütfen email giriniz");string email=Console.ReadLine();
            Console.WriteLine("\nLütfen adress giriniz");string adresse=Console.ReadLine();
            Console.WriteLine("\nLütfen telefon numarasini giriniz");string phone=Console.ReadLine();
            Console.WriteLine("\nLütfen hesap türünü (bireysel, ticari, ögrenci) giriniz");string kontoType=Console.ReadLine();
            vorname = inhaber.Vorname;
            nachname = inhaber.Nachname;
            email = inhaber.Email;
            adresse = inhaber.Adres;
            kontoType = inhaber.KontoType;
            phone = inhaber.Phone;  
            inhaber.Count++;

            Console.WriteLine("Hesabiniz tamamlaniyor...");
            Thread.Sleep(1000);

            Console.WriteLine("Hesabiniz olusturuldu artik islem yapabilirsiniz...");

            Console.WriteLine(inhaber.ToString());
            Thread.Sleep(1000);
            RecherMenu();


        }
        public void RecherMenu()
        {
            
            Console.Clear();
            Console.WriteLine("=========================================================================");
            Console.WriteLine($"=========              hosgeldiniz sayin {inhaber.Username}    =========");
            string menu = $"username\t:{inhaber.Username}\t\t\t\thesap türü\t:{inhaber.KontoType} \n" +
                          $"vorname \t:{inhaber.Vorname}\t\t\t\tadress\t:{inhaber.Adres} \n" +
                          $"Email   \t:{inhaber.Email}\t\t\t\tphone\t:{inhaber.Phone} \n";
            Console.WriteLine(menu);
            Console.WriteLine($"{inhaber.Vorname} {inhaber.Nachname} {inhaber.Email} {inhaber.Adres} {inhaber.Phone} {inhaber.KontoType}");
        }
       

    }
}

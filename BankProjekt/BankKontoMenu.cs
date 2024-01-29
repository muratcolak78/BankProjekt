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
            Console.WriteLine($"=========             welcome  {inhaber.Username}    =========");
            Console.WriteLine("\nWe need some information to complete your account");
            Console.WriteLine("\nPlease enter your name");string vorname=Console.ReadLine();
            Console.WriteLine("\nPlease enter your surname");string nachname=Console.ReadLine();
            Console.WriteLine("\nPlease enter email");string email=Console.ReadLine();
            Console.WriteLine("\nPlease enter address");string adresse=Console.ReadLine();
           
           
            vorname = inhaber.Vorname;
            nachname = inhaber.Nachname;
            email = inhaber.Email;
            adresse = inhaber.Adres;        
            inhaber.Count++;

            Console.WriteLine("Ihr Konto wird gerade fertiggestellt...");
            Thread.Sleep(1000);

            Console.WriteLine("Ihr Konto wurde erstellt und Sie können nun Transaktionen vornehmen...");

            Console.WriteLine(inhaber.ToString());
            Thread.Sleep(1000);
            RecherMenu();


        }
        public void RecherMenu()
        {
            
            Console.Clear();
            Console.WriteLine("=========================================================================");
            Console.WriteLine($"=========              Willkommen  {inhaber.Username}    =========");
            string menu = $"username\t:{inhaber.Username}\t\t\t\thesap türü\t:{inhaber.KontoType} \n" +
                          $"vorname \t:{inhaber.Vorname}\t\t\t\tadress\t:{inhaber.Adres} \n" +
                          $"Email   \t:{inhaber.Email} \n";
            Console.WriteLine(menu);
            Console.WriteLine($"{inhaber.Vorname} {inhaber.Nachname} {inhaber.Email} {inhaber.Adres}  {inhaber.KontoType}");
        }
       

    }
}

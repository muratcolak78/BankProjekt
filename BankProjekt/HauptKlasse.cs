using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    internal static class HauptKlasse
    {
        
        public static void menu()
        {
            
            while (true)
            {

                AlleListe.machBeispielList();
                AlleListe.zeighAlleUser();
                Kontoinhaber einhaber;
                BankKontoMenu menu;

                Console.Clear();
                Console.WriteLine("1. Kayit\t\t2. Giris\t\t3. Cikis");
                string wahl = Console.ReadLine();
                if (wahl != "3")
                {
                    if (wahl == "1")
                    {
                        Console.WriteLine("Kullanici adi:");
                        string eingabeUsername = Console.ReadLine().ToLower();

                        if (eingabeUsername == null || eingabeUsername.Length! < 5)
                        {
                            Console.WriteLine("kullanici adi kismi bos biraklilamaz en az 5 karakter olmalidir\n");
                            Thread.Sleep(1000);

                        }
                        else
                        {
                            if (!AlleListe.IstUserNameInDerListe(eingabeUsername))// eger kullanici adi listede yoksa sifre siteyecek. kontrol edilecek bir liste gerekiyor  (IstUserNameInDerListe(sting Username)) )
                            {
                                bool exit = false;
                                while (!exit)
                                {
                                    Console.WriteLine("Sifre:");
                                    string eingabePassword = Console.ReadLine().ToLower();

                                    if (eingabePassword != "3")
                                    {
                                        if (eingabePassword == "" || eingabePassword.Length < 6)// eger sifre sartlari karsiliyorsa sifre olusturma sarlari belirlenecek (IstPasswordPass(srting Password))
                                        {
                                            Console.WriteLine("\nsifre en az 6 karakter, en az bir harf ve en az bir rakam icermelidir (3. Cikis)\n");
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            if (IstPasswordPass(eingabePassword))
                                            {
                                                List<string> user = new List<string>() { eingabeUsername, eingabePassword };
                                                AlleListe.addUserNamePasswordList(user);
                                                AlleListe.addUserKontoinhaberList(new Kontoinhaber(eingabeUsername));

                                                Console.WriteLine("kullanic adi ve sifre basariyla kaydedildi.\n");
                                                Console.WriteLine("yeni kullanici hesabi olusturuldu\n");
                                               
                                                Thread.Sleep(2000);
                                               
                                                exit = true;

                                            }
                                            else Console.WriteLine("\nsifre en az 6 karakter, en az bir harf ve en az bir rakam icermelidir (3. Cikis)\n");
                                            Thread.Sleep(1000);
                                        }
                                    }
                                    else exit = true;
                                }

                            }
                            else Console.WriteLine("\nbu adda zaten bir kullanici mevcut lütfen baska bir kullanici adi giriniz.\n");
                            Console.ReadKey();

                        }

                    }
                    else if (wahl == "2")
                    {
                        Console.WriteLine("Kullanici adi:");
                        string eingabeUsername = Console.ReadLine().ToLower();

                        if (eingabeUsername != null || eingabeUsername.Length < 5) // eger kullanici adi bos degilse sifre isteniyor
                        {
                            Console.WriteLine("Sifre:");
                            string eingabePassword = Console.ReadLine().ToLower();
                           
                            if (eingabePassword != null) // eger sifre bos degilse 
                            {
                                if (AlleListe.GibtEsSolcheUser(eingabeUsername, eingabePassword))// ve eger listede bu bilgilerde bi hesap sahibi varsa
                                {
                                    Console.WriteLine("Hosgeldiniz " + eingabeUsername);// kullanbic bilgileri getiriliyor
                                    
                                    einhaber = AlleListe.getKontoinhaber(eingabeUsername);
                                    menu = new BankKontoMenu(einhaber);

                                }
                                else Console.WriteLine("\nboyle bir kullanici bulunmamaktadir lütfen kullanici adini ve sifrenizi kontrol ediniz.\n");
                                Console.ReadKey();
                            }
                            else Console.WriteLine("\nsifre bos birakilamaz\n");
                            Thread.Sleep(1000);
                        }
                        else Console.WriteLine("\nkullanici adi kismi bos biraklilamaz en az 5 karakter olmalidir\n");
                        Thread.Sleep(1000);

                    }
                    else Console.WriteLine("\nlütfen 1,2 veya 3\n");
                    Thread.Sleep(1000);

                }
                else break;
            }

        }

        public static bool IstPasswordPass(string password)
        {
            char[] passwordChar = password.ToCharArray();
            int digitCount = 0, letterCount = 0;

            for (int i = 0; i < passwordChar.Length; i++)
            {
                if (Char.IsDigit(passwordChar[i])) digitCount++;
                if (Char.IsLetter(passwordChar[i])) letterCount++;

            }

            if (digitCount > 0 && letterCount > 0 ) return true;
            else return false;
       }
       

    }
}

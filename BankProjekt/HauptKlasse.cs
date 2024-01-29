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
                Console.ForegroundColor = ConsoleColor.Green;
                AlleListe.machBeispielList();
                Kontoinhaber einhaber;
                BankKontoMenu menu;

                Console.Clear();
                Console.WriteLine("1. Signin\t\t2.Login\t\t3. Exit");
                string wahl = Console.ReadLine();
                if (wahl != "3")
                {
                    if (wahl == "4")
                    {
                        AlleListe.alleIbanList();
                        AlleListe.zeighAlleUser();
                        Console.Read();
                    }
                    else if (wahl == "1")
                    {
                        Console.WriteLine("Username:");
                        string eingabeUsername = Console.ReadLine().ToLower();

                        if (eingabeUsername == null || eingabeUsername.Length! < 5)
                        {
                            Console.WriteLine(" it must be at least 5 characters\n");
                            Thread.Sleep(1000);

                        }
                        else
                        {
                            if (!AlleListe.IstUserNameInDerListe(eingabeUsername))// eger kullanici adi listede yoksa sifre siteyecek. kontrol edilecek bir liste gerekiyor  (IstUserNameInDerListe(sting Username)) )
                            {
                                bool exit = false;
                                while (!exit)
                                {
                                    Console.WriteLine("password:");
                                    string eingabePassword = Console.ReadLine().ToLower();

                                    if (eingabePassword != "3")
                                    {
                                        if (eingabePassword == "" || eingabePassword.Length < 6)// eger sifre sartlari karsiliyorsa sifre olusturma sarlari belirlenecek (IstPasswordPass(srting Password))
                                        {
                                            Console.WriteLine("\npassword must contain at least 6 characters, at least one letter and at least one number (Exit 3)\n");
                                            Thread.Sleep(1000);
                                        }
                                        else
                                        {
                                            if (IstPasswordPass(eingabePassword))
                                            {
                                                string [] user = new string [] { eingabeUsername, eingabePassword };
                                                AlleListe.addUserNamePasswordList(user);
                                                AlleListe.addUserKontoinhaberList(new Kontoinhaber(eingabeUsername));

                                                Console.WriteLine("username and password successfully registered.\n");
                                                Console.WriteLine("new user account created\n");

                                                Thread.Sleep(2000);

                                                exit = true;

                                            }
                                            else Console.WriteLine("\npassword must contain at least 6 characters, at least one letter and at least one number (Exit 3)\n");
                                            Thread.Sleep(1000);
                                        }
                                    }
                                    else exit = true;
                                }

                            }
                            else Console.WriteLine("\nthere is already a user with this name, please enter another username.\n");
                            Console.ReadKey();

                        }

                    }
                    
                    else if (wahl == "2")
                    {
                        Console.WriteLine("username:");
                        string eingabeUsername = Console.ReadLine().ToLower();

                        if (eingabeUsername != null || eingabeUsername.Length < 5) // eger kullanici adi bos degilse sifre isteniyor
                        {
                            Console.WriteLine("password:");
                            string eingabePassword = Console.ReadLine().ToLower();

                            if (eingabePassword != null) // eger sifre bos degilse 
                            {
                                if (AlleListe.GibtEsSolcheUser(eingabeUsername, eingabePassword))// ve eger listede bu bilgilerde bi hesap sahibi varsa
                                {
                                    Console.WriteLine("Welcome " + eingabeUsername);// kullanbic bilgileri getiriliyor

                                    einhaber = AlleListe.getKontoinhaber(eingabeUsername);
                                    menu = new BankKontoMenu(einhaber);

                                }
                                else Console.WriteLine("\nthere is no such user please check your username and password.\n");
                                Console.ReadKey();
                            }
                            else Console.WriteLine("\npassword cannot be left blank\n");
                            Thread.Sleep(1000);
                        }



                    }
                    else Console.WriteLine("\nlplease 1,2 or 3\n");
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

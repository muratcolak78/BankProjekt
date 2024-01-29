using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    static class AlleListe
    {
        private static List<string[]> userNamePassworList;
        private static List<Kontoinhaber> kontoInhaberList;
      
        public static List<string[]> UserNamePassworList { get => userNamePassworList;  }
        public static List<Kontoinhaber> KontoInhaberList { get => kontoInhaberList; }

        public static void machBeispielList()
        {
            userNamePassworList = new List< string[] > ();
            userNamePassworList.Add(new string[] { "murat","12345a"});
            userNamePassworList.Add(new string[] { "fabian","12345a"});
            userNamePassworList.Add(new string[]{ "nadine","12345a"});
            userNamePassworList.Add(new string[]{ "partic","12345a"});
            userNamePassworList.Add(new string[] { "marian", "12345a" });
            userNamePassworList.Add(new string[] { "1", "1" });

            kontoInhaberList = new List<Kontoinhaber>();
            kontoInhaberList.Add(new Kontoinhaber("murat"));
            kontoInhaberList.Add(new Kontoinhaber("fabin"));
            kontoInhaberList.Add(new Kontoinhaber("nadine"));
            kontoInhaberList.Add(new Kontoinhaber("patric"));
            kontoInhaberList.Add(new Kontoinhaber("marian"));
            kontoInhaberList.Add(new Kontoinhaber("1"));

        }

        public static void addUserNamePasswordList(string[] usernamepasword)
        {
           
            userNamePassworList.Add(usernamepasword);
        }
        public static void addUserKontoinhaberList(Kontoinhaber einhaber)
        {
            kontoInhaberList.Add(einhaber);
        }
        public static bool IstUserNameInDerListe(string username)
        {
            int count = 0;
            for (int i=0;i<userNamePassworList.Count;i++)
            {
                if (userNamePassworList[i][0]==username) count++;
                if (count > 0) break;

            }
            if (count > 0) return true;
            else return false;
        }
        public static bool GibtEsSolcheUser(string Username, string Password)
        {
            List<string> user=new List<string>(){Username , Password };
            Console.WriteLine("burasi calisti");

            int count = 0;
            for (int i=0;i<userNamePassworList.Count;i++)
            {
                if (userNamePassworList[i][0] == user[0]&& userNamePassworList[i][1] == user[1]) count++;
                if (count > 0) break;
            }

            if (count > 0) return true;
            else return false;
       
        }
        public static Kontoinhaber getKontoinhaber(string username)
        {
            int count = 0;
            for (int i = 0; i < KontoInhaberList.Count; i++)
            {
                if (KontoInhaberList[i].Username == username)
                {
                    return KontoInhaberList[i];
                } 
            }
            return null;
        }
        public static  void zeighAlleUser()
        {
            Console.WriteLine("username und passwort list");
            foreach (string[] i in userNamePassworList)
            {
                Console.WriteLine(i[0]+" -- " + i[1]);
            }
        }
        public static void alleIbanList()
        {
            Console.WriteLine("Inabn list");
            Kontoinhaber inhaber;
            for(int i = 0; i < KontoInhaberList.Count; i++)
            {
                inhaber = KontoInhaberList[i];
                foreach (var iban in inhaber.KontoList)
                {
                    Console.WriteLine( inhaber.Username+"--"+ iban.IBAN1);
                }
            }
        }

    }
}

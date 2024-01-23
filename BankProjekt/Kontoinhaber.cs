using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    internal class Kontoinhaber
    {
        private int count = 0;
        private string username;
        private string vorname;
        private string nachname;
        private string email;
        private string adres;
        private string phone;
        private string hesapTürü;
        private string kontoType;

        public  int Count { get => count; set => count = value; }
        public string Username { get => username; set => username = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Email { get => email; set => email = value; }
        public string Adres { get => adres; set => adres = value; }
        public string HesapTürü { get => hesapTürü; set => hesapTürü = value; }
        public string KontoType { get => kontoType; set => kontoType = value; }
        public string Phone { get => phone; set => phone = value; }

        public Kontoinhaber(string username) 
        {
            
                this.username = username;
                count++;
           
            
        }

       public string toString()
        {
            return $"count = {Count}    username= {Username}  vorname={Vorname}   nachname={Nachname} Email={Email} Adress={Adres} Phone={Phone}";
        }
    }
}

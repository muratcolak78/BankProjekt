using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
        private string kontoType;
        private double TotalGeld;
        private StandartKonto standartKonto;
        private SchulerKonto schulerKonto;
        private Geschäftskonto geschäftskonto;
        private List<Konto> kontoList;

        public  int Count { get => count; set => count = value; }
        public string Username { get => username; set => username = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Email { get => email; set => email = value; }
        public string Adres { get => adres; set => adres = value; }
       
        public string KontoType { get => kontoType; set => kontoType = value; }
        public double TotalGeld1 { get => TotalGeld; set => TotalGeld = value; }
        public StandartKonto StandartKonto { get => standartKonto; set => standartKonto = value; }
       public List<Konto> KontoList { get => kontoList; set => kontoList = value; }
        public SchulerKonto SchulerKonto { get => schulerKonto; set => schulerKonto = value; }
        public Geschäftskonto Geschäftskonto { get => geschäftskonto; set => geschäftskonto = value; }

        public Kontoinhaber(string username) 
        {
            
                this.username = username;
                standartKonto=new StandartKonto(username, this);
                KontoList = new List<Konto>();
                KontoList.Add(standartKonto);
                count++;
         
        }
        public void makeStandartKonto(string kontoname)
        {
            KontoList.Add(new StandartKonto(kontoname, this));
        }
        public void makeSchulerKonto(string kontoname)
        {
            KontoList.Add(new SchulerKonto(kontoname, this));
        }
        public void makeGeschäftskontoKonto(string kontoname)
        {
            KontoList.Add(new Geschäftskonto(kontoname, this));
        }


    }
}

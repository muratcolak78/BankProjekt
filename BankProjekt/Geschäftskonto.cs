using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    internal class Geschäftskonto:Konto
    {
        public Geschäftskonto(string kontoName, Kontoinhaber inhaber) : base(kontoName, inhaber)
        {
            MaxSaldo = 100000;
            KontoType = "Geschäftskonto";
            IBAN1 = IBANGenerator.genetator();
            Inhaber = inhaber;
        }
    }
}

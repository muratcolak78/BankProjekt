using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    internal class StandartKonto:Konto
    {
        public StandartKonto(string kontoName, Kontoinhaber inhaber) : base(kontoName, inhaber)
        {
            MaxSaldo = 10000;
            KontoType = "StandartKonto";
            IBAN1 = IBANGenerator.genetator();
            Inhaber = inhaber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    internal class SchulerKonto:Konto
    {
        public SchulerKonto(string kontoName,Kontoinhaber inhaber) : base(kontoName, inhaber)
        {
            MaxSaldo = 200;
            KontoType = "SchulerKonto";
            IBAN1 = IBANGenerator.genetator();
            Inhaber = inhaber;

        }
    }
}

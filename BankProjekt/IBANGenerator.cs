using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    internal static class IBANGenerator
    {
        public static int number = 10;

        public static string Iban = "123";

        public static string genetator()
        {
            number++;
            return Iban + number;
        }
          
            

    }
}

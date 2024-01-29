using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt
{
    internal abstract class Konto
    {
        private double maxSaldo;
        private double Saldo;
        private string kontoType;
        private string IBAN;
        private string KontoName;
        private Kontoinhaber inhaber;

        public double MaxSaldo { get => maxSaldo; set => maxSaldo = value; }
        public double Saldo1 { get => Saldo; set => Saldo = value; }
        public string KontoType { get => kontoType; set => kontoType = value; }
        public string IBAN1 { get => IBAN; set => IBAN = value; }
        public string KontoName1 { get => KontoName; set => KontoName = value; }
        internal Kontoinhaber Inhaber { get => inhaber; set => inhaber = value; }

        public Konto(string kontoName, Kontoinhaber inhaber)
    {
        KontoName = kontoName;
        Inhaber = inhaber;
        
    }

    public void ParaYatir(double miktar)
    {
        Saldo += miktar;
        Console.WriteLine($"{miktar} Eur hinterlegt. Neuer Saldo {Saldo} Eur");
    }

    public void ParaCek(double miktar)
    {
        if (Saldo >= miktar)
        {
            Saldo -= miktar;
            Console.WriteLine($"{miktar}Eur  zurückgezogen. Neuer Saldo {Saldo} Eur");
        }
        else
        {
            Console.WriteLine("Unzureichende Mittel. Die Transaktion konnte nicht bearbeitet werden.");
        }
    }

    public void HavaleYap(double miktar, Konto hedefKonto)
    {
        if (Saldo >= miktar)
        {
            Saldo -= miktar;
            hedefKonto.ParaYatir(miktar);
            Console.WriteLine($"{miktar} eur Überweisung erfolgt. Neuer Saldo {Saldo} Eur");
        }
        else
        {
            Console.WriteLine("Unzureichende Mittel. Die Transaktion konnte nicht bearbeitet werden.");
        }
    }
        public override string ToString()
        {
            return $"Konto Tipi: {kontoType}, Konto Adı: {KontoName}, Max Bakiye: {maxSaldo}, Mevcut Bakiye: {Saldo}, IBAN: {IBAN}";
        }
    }
}

using System;
using System.Collections.Generic;
using Grundkurs_i_Programmering__Nybörjare.Affar;

namespace Grundkurs_i_Programmering__Nybörjare.Kund
{
    public class KundInfo
    {
        public string Namn { get; set; }
        public double Saldo { get; set; }
        public List<Produkt> KöptaProdukter { get; set; }

        public KundInfo(string namn, double startSaldo)
        {
            Namn = namn;
            Saldo = startSaldo;
            KöptaProdukter = new List<Produkt>();
        }

        public void VisaSaldo()
        {
            Console.WriteLine($"{Namn}, du har {Saldo} kr kvar.");
        }

        public void VisaKöptaVaror()
        {
            if (KöptaProdukter.Count == 0)
            {
                Console.WriteLine("Du har inte köpt något än.");
            }
            else
            {
                Console.WriteLine("Dina köpta varor:");
                foreach (var produkt in KöptaProdukter)
                {
                    Console.WriteLine($"- {produkt.Namn} ({produkt.Pris} kr)");
                }
            }
        }
    }
}

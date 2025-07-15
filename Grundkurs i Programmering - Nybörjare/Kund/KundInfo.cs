using System;
using System.Collections.Generic;
using Grundkurs_i_Programmering__Nybörjare.Affar;

namespace Grundkurs_i_Programmering__Nybörjare.Kund
{
    public class KundInfo
    {
        public string Namn { get; set; }
        public double Saldo { get; set; }
        public List<VarorInfo> KöptaVaror { get; set; }

        public KundInfo(string namn, double startSaldo)
        {
            Namn = namn;
            Saldo = startSaldo;
            KöptaVaror = new List<VarorInfo>();
        }

        public void VisaSaldo()
        {
            Console.WriteLine($"{Namn}, du har {Saldo} kr kvar.");
        }

        public void VisaKöptaVaror()
        {
            if (KöptaVaror.Count == 0)
            {
                Console.WriteLine("Du har inte köpt något än.");
            }
            else
            {
                Console.WriteLine(" Dina köpta varor:");
                foreach (var vara in KöptaVaror)
                {
                    Console.WriteLine($"- {vara.Namn} ({vara.Pris} kr, Energi: {vara.Energi})");
                }
            }
        }
    }
}

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

        public double Lon { get; set; } = 50;

        public int Hunger { get; set; } = 5;
        public int Torst { get; set; } = 5;
        public int Energi { get; set; } = 5;

        public KundInfo(string namn, double startSaldo)
        {
            Namn = namn;
            Saldo = startSaldo;
            KöptaVaror = new List<VarorInfo>();
        }

        public void GeLon()
        {
            Saldo += Lon;
            Console.WriteLine($"\n {Namn} fick {Lon} kr i veckolön!");
            VisaSaldo();
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

        public void VisaStatus()
        {
            Console.WriteLine($" Hunger: {Hunger} | Törst: {Torst} | Energi: {Energi}");
        }

        public bool ÄrLevande()
        {
            return Hunger > 0 && Torst > 0 && Energi > 0;
        }
    }
}

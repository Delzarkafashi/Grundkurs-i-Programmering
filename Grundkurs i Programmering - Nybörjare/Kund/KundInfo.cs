using System;
using System.Collections.Generic;
using System.IO;
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

        public void SparaData(int vecka)
        {
            string fil = "speldata.txt";
            using (StreamWriter sw = new StreamWriter(fil))
            {
                sw.WriteLine(Namn);
                sw.WriteLine(Saldo);
                sw.WriteLine(vecka);
                sw.WriteLine(Hunger);
                sw.WriteLine(Torst);
                sw.WriteLine(Energi);
            }
        }

        public bool LaddaData(out int vecka)
        {
            string fil = "speldata.txt";
            vecka = 1;

            if (File.Exists(fil))
            {
                string[] rader = File.ReadAllLines(fil);
                if (rader.Length >= 6)
                {
                    Namn = rader[0];
                    Saldo = double.Parse(rader[1]);
                    vecka = int.Parse(rader[2]);
                    Hunger = int.Parse(rader[3]);
                    Torst = int.Parse(rader[4]);
                    Energi = int.Parse(rader[5]);
                    return true;
                }
            }

            return false;
        }
    }
}

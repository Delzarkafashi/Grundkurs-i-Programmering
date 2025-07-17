using System;
using System.IO;
using Grundkurs_i_Programmering__Nybörjare.Kund;
using Grundkurs_i_Programmering__Nybörjare.Affar;

namespace Grundkurs_i_Programmering___Nybörjare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int vecka;
            KundInfo kund = new KundInfo("", 0);

            // Ladda speldata om det finns
            if (kund.LaddaData(out vecka))
            {
                Console.WriteLine($"Välkommen tillbaka, {kund.Namn}! Din data har laddats.");
            }
            else
            {
                Console.Write("Vad heter du? ");
                string namn = Console.ReadLine();
                kund = new KundInfo(namn, 100);
                vecka = 1;
            }

            var affar = new Affar();

            while (true)
            {
                // Visa status
                Console.WriteLine($"\n Vecka {vecka}");
                Console.WriteLine($"Hunger: {kund.Hunger} | Törst: {kund.Torst} | Energi: {kund.Energi}");

                // Kontroll om spelaren lever
                if (kund.Hunger <= 0 || kund.Torst <= 0 || kund.Energi <= 0)
                {
                    Console.WriteLine("Du har dött av utmattning, svält eller uttorkning!");
                    return;
                }

                Console.WriteLine("\n--- MENY ---");
                Console.WriteLine("1. Visa saldo");
                Console.WriteLine("2. Visa affären");
                Console.WriteLine("3. Köp en vara");
                Console.WriteLine("4. Visa köpta varor");
                Console.WriteLine("5. Nästa vecka");
                Console.WriteLine("6. Avsluta (spara)");
                Console.Write("Välj ett alternativ: ");
                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        kund.VisaSaldo();
                        break;
                    case "2":
                        affar.VisaVaror();
                        break;
                    case "3":
                        affar.KöpVara(kund);
                        break;
                    case "4":
                        kund.VisaKöptaVaror();
                        break;
                    case "5":
                        vecka++;
                        kund.GeLon();
                        kund.Hunger--;
                        kund.Torst--;
                        kund.Energi--;
                        break;
                    case "6":
                        kund.SparaData(vecka);
                        Console.WriteLine("Spelet har sparats. Hejdå!");
                        return;
                    default:
                        Console.WriteLine(" Ogiltigt val.");
                        break;
                }
            }
        }
    }
}

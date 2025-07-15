using System;
using Grundkurs_i_Programmering__Nybörjare.Kund;
using Grundkurs_i_Programmering__Nybörjare.Affar;

namespace Grundkurs_i_Programmering___Nybörjare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();

            var kund = new KundInfo(namn, 100);
            var affar = new Affar();

            while (true)
            {
                Console.WriteLine("\n--- MENY ---");
                Console.WriteLine("1. Visa saldo");
                Console.WriteLine("2. Visa affären");
                Console.WriteLine("3. Köp en vara");
                Console.WriteLine("4. Visa köpta varor");
                Console.WriteLine("5. Avsluta");
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
                        Console.WriteLine(" Hejdå!");
                        return;
                    default:
                        Console.WriteLine(" Ogiltigt val.");
                        break;
                }
            }
        }
    }
}

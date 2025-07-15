using System;
using System.Collections.Generic;
using System.Linq;
using Grundkurs_i_Programmering__Nybörjare.Kund;

namespace Grundkurs_i_Programmering__Nybörjare.Affar
{
    public class Affar
    {
        private List<VarorInfo> varor = new List<VarorInfo>();

        public Affar()
        {
            varor.Add(new VarorInfo(1, "Bröd", 15, 5));
            varor.Add(new VarorInfo(2, "Vatten", 10, 3));
            varor.Add(new VarorInfo(3, "Äpple", 5, 2));
        }

        public void VisaVaror()
        {
            Console.WriteLine(" Välkommen till affären!\n");
            foreach (var vara in varor)
            {
                Console.WriteLine(vara.ToString());
            }
        }

        public void KöpVara(KundInfo kund)
        {
            VisaVaror();
            Console.Write("\nAnge ID på varan du vill köpa: ");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var valdVara = varor.FirstOrDefault(p => p.Id == id);

                if (valdVara != null)
                {
                    if (kund.Saldo >= valdVara.Pris)
                    {
                        kund.Saldo -= valdVara.Pris;
                        kund.KöptaVaror.Add(valdVara);
                        Console.WriteLine($" Du köpte {valdVara.Namn} för {valdVara.Pris} kr (Energi +{valdVara.Energi})");
                        kund.VisaSaldo();
                    }
                    else
                    {
                        Console.WriteLine(" Du har inte tillräckligt med pengar!");
                    }
                }
                else
                {
                    Console.WriteLine(" Felaktigt ID.");
                }
            }
            else
            {
                Console.WriteLine(" Du måste skriva ett giltigt nummer.");
            }
        }
    }
}

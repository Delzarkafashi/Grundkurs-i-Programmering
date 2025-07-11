using System;
using System.Collections.Generic;
using System.Linq;
using Grundkurs_i_Programmering__Nybörjare.Kund;

namespace Grundkurs_i_Programmering__Nybörjare.Affar
{
    public class Affar
    {
        private List<Produkt> produkter = new List<Produkt>();

        public Affar()
        {
            produkter.Add(new Produkt(1, "Bröd", 15));
            produkter.Add(new Produkt(2, "Vatten", 10));
            produkter.Add(new Produkt(3, "Äpple", 5));
        }

        public void VisaProdukter()
        {
            Console.WriteLine("🛒 Välkommen till affären!\n");
            foreach (var produkt in produkter)
            {
                Console.WriteLine($"{produkt.Id}. {produkt.Namn} – {produkt.Pris} kr");
            }
        }

        public void KöpVara(KundInfo kund)
        {
            VisaProdukter();
            Console.Write("\nAnge ID på produkten du vill köpa: ");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var valdProdukt = produkter.FirstOrDefault(p => p.Id == id);

                if (valdProdukt != null)
                {
                    if (kund.Saldo >= valdProdukt.Pris)
                    {
                        kund.Saldo -= valdProdukt.Pris;
                        kund.KöptaProdukter.Add(valdProdukt);
                        Console.WriteLine($"Du köpte {valdProdukt.Namn} för {valdProdukt.Pris} kr");
                        kund.VisaSaldo();
                    }
                    else
                    {
                        Console.WriteLine("Du har inte tillräckligt med pengar!");
                    }
                }
                else
                {
                    Console.WriteLine("Felaktigt produkt-ID.");
                }
            }
            else
            {
                Console.WriteLine("Du måste skriva ett giltigt nummer.");
            }
        }
    }
}

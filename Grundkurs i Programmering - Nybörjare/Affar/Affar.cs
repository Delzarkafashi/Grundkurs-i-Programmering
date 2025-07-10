using System;
using System.Collections.Generic;

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
            Console.WriteLine("Välkommen till affären!\n");
            foreach (var produkt in produkter)
            {
                Console.WriteLine($"{produkt.Id}. {produkt.Namn} – {produkt.Pris} kr");
            }
        }
    }
}

namespace Grundkurs_i_Programmering__Nybörjare.Affar
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public double Pris { get; set; }

        public Produkt(int id, string namn, double pris)
        {
            Id = id;
            Namn = namn;
            Pris = pris;
        }
    }
}


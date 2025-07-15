namespace Grundkurs_i_Programmering__Nybörjare.Affar
{
    public class VarorInfo
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public double Pris { get; set; }
        public int Energi { get; set; }

        public VarorInfo(int id, string namn, double pris, int energi)
        {
            Id = id;
            Namn = namn;
            Pris = pris;
            Energi = energi;
        }

        public override string ToString()
        {
            return $"{Id}. {Namn} – {Pris} kr, Energi: {Energi}";
        }
    }
}

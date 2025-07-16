namespace Grundkurs_i_Programmering__Nybörjare.Affar
{
    public class VarorInfo
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public double Pris { get; set; }
        public int Energi { get; set; }
        public int Mat { get; set; }
        public int Dryck { get; set; }

        public VarorInfo(int id, string namn, double pris, int energi, int mat, int dryck)
        {
            Id = id;
            Namn = namn;
            Pris = pris;
            Energi = energi;
            Mat = mat;
            Dryck = dryck;
        }

        public override string ToString()
        {
            return $"{Id}. {Namn} – {Pris} kr, Energi: {Energi}";
        }
    }
}

namespace Grundkurs_i_Programmering__Nybörjare.Kund
{
    public class KundInfo
    {
        public string Namn { get; set; }
        public double Saldo { get; set; }

        public KundInfo(string namn, double startSaldo)
        {
            Namn = namn;
            Saldo = startSaldo;
        }

        public void VisaSaldo()
        {
            Console.WriteLine($"{Namn}, du har {Saldo} kr kvar.");
        }
    }
}

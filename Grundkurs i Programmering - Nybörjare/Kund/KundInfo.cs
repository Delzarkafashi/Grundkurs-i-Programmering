namespace Grundkurs_i_Programmering__Nybörjare.Kund
{
    public class Kund
    {
        public string Namn { get; set; }
        public double Saldo { get; set; }

        public Kund(string namn, double startSaldo)
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

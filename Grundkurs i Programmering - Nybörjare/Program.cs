using Grundkurs_i_Programmering__Nybörjare.Kund;

namespace Grundkurs_i_Programmering___Nybörjare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();

            var kund = new KundInfo(namn, 100);
            kund.VisaSaldo();
        }
    }
}

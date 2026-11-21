namespace Gra
{
    public class Kosc
    {

        public static int koscCount = 0;
        public string[] fileNames = ["kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"];
        public int liczbaOczek = 0;

        public int idPliku;

        public bool avaiable;

        public Kosc(int thrown)
        {
            if(thrown < 1 || thrown > 6)
            {
                thrown = 0;
            }
            liczbaOczek = thrown;
            idPliku = thrown;
            avaiable = true;
            koscCount++;
        }
        public Kosc()
        {
            Random random = new Random();
            liczbaOczek = random.Next(1, 7);
            idPliku = liczbaOczek;
            avaiable = true;
            koscCount++;
        }

        public void Rzut()
        {
            if (!avaiable)
            {
                return;
            }
            else 
            {
            Random random = new Random();
            liczbaOczek = random.Next(1, 7);
            idPliku = liczbaOczek;
            }
        }

        public void Zablokuj()
        {
            avaiable = false;
        }

        public string Oczka()
        {
            switch (liczbaOczek)
            {
                case 1:
                    return "Jeden";
                case 2:
                    return "Dwa";
                case 3:
                    return "Trzy";
                case 4:
                    return "Cztery";
                case 5:
                    return "Pięć";
                case 6:
                    return "Sześć";
                default:
                    return "Nieznana liczba oczek";
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Kosc kosc1 = new Kosc();
            Console.WriteLine($"Liczba instancji klasy Kość: {Kosc.koscCount}");
            Console.WriteLine($"Liczba oczek Kosc 1: {kosc1.liczbaOczek} - {kosc1.Oczka()}");
            Console.WriteLine($"Plik: {kosc1.fileNames[kosc1.idPliku]}");

            Console.WriteLine("Ile oczek ma Kosc 2: ");
            Kosc kosc2 = new Kosc(Console.ReadKey().KeyChar - '0');
            Console.WriteLine($"\nLiczba instancji klasy Kość: {Kosc.koscCount}");
            Console.WriteLine($"Liczba oczek Kosc 2: {kosc2.liczbaOczek} - {kosc2.Oczka()}");
            Console.WriteLine($"Plik: {kosc2.fileNames[kosc2.idPliku]}");
        }
    }
}
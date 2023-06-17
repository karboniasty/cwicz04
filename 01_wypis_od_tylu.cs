namespace _01_wypis_od_tylu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random losowa = new Random();

            int rozmiar = 10;
            int[] tablica = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                tablica[i] = losowa.Next(100);
            }
            //dodaję wypisywanie od początku w celu sprawdzenia
            wypisz_od_poczatku(tablica, rozmiar);
            wypisz_od_tylu(tablica, rozmiar);         

        }

        static void wypisz_od_poczatku(int[] tablica, int rozmiar)
        {
            Console.Write("Wypisanie elementów od poczatku: ");
            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
            return;
        }

        static void wypisz_od_tylu(int[] tablica, int rozmiar)
        {
            Console.Write("Wypisanie elementów od tyłu: ");
            for (int i = rozmiar - 1; i >= 0; i--)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
            return;
        }
    }
}
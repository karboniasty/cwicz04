namespace _02_min_max_tablicy
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

            wypisz_od_poczatku(tablica, rozmiar);            
            Console.WriteLine("Najmniejszy element: " + znajdz_min(tablica, rozmiar));
            Console.WriteLine("Największy element: " + znajdz_max(tablica, rozmiar));

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
                
        static int znajdz_min(int[] tablica, int rozmiar)
        {
            int element = tablica[0];
            for (int i = 1; i < rozmiar; i++)
            {
                if (tablica[i] < element)
                    element = tablica[i];
            }
            return element;
        }

        static int znajdz_max(int[] tablica, int rozmiar)
        {
            int element = tablica[0];
            for (int i = 1; i < rozmiar; i++)
            {
                if (tablica[i] > element)
                    element = tablica[i];
            }
            return element;
        }
    }
}
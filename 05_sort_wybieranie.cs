namespace _05_sort_wybieranie
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
            Console.Write("Wypisanie elementów przed sortowaniem: ");
            wypisz_od_poczatku(tablica, rozmiar);

            for (int i = 0; i < rozmiar; i++)
            {
                int pozycja_min = znajdz_min(tablica, rozmiar, i);
                (tablica[pozycja_min], tablica[i]) = (tablica[i], tablica[pozycja_min]);                
            }

            Console.Write("Wypisanie elementów po sortowaniu: ");
            wypisz_od_poczatku(tablica, rozmiar);

        }

        static void wypisz_od_poczatku(int[] tablica, int rozmiar)
        {            
            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
            return;
        }

        static int znajdz_min(int[] tablica, int rozmiar, int i)
        {
            int element = tablica[i];
            int pozycja = i;
            for (int j = i+1; j < rozmiar; j++)
            {
                if (tablica[j] < element) 
                {
                    element = tablica[j];
                    pozycja = j;
                }
                   
            }
            return pozycja;
        }
    }
}
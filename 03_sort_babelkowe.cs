namespace _03_sort_babelkowe
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
            
            for (int i = 0;i < rozmiar; i++)
            {
                for (int j = 1; j < rozmiar - i; j++)
                {
                   if(tablica[j - 1] > tablica[j])
                        (tablica[j - 1], tablica[j]) = (tablica[j], tablica[j-1]);
                }
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
                    
    }
}
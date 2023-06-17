using System.Globalization;

namespace _04_sort_wstawianie
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

            for (int i = 1;i < rozmiar; i++) 
            {
                int j = i - 1;                
                while (j >= 0 && tablica[i] < tablica[j]) 
                    j--;
                j++;
                while (j<i)
                {
                    (tablica[j], tablica[i]) = (tablica[i], tablica[j]);
                    j++;
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
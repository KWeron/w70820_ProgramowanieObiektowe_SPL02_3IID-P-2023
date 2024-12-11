using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Net;

internal class Program
{
    public class Lab1
    {
        // 1 zadanie
        static void Main(string[] args)
        {
            int opcja;

            while (true)
            {
                Console.WriteLine("Menu: \n 1.Sprawdź czy liczba jest parzysta \n 2.Wypisywanie liczb parzystych" +
                    "\n 3.Obliczanie silni \n 4.Gra - Zgadnij liczbę \n 5.Wyjście");

                Console.WriteLine("Jaką opcje wybierasz? Wpisz numer od 1 do 5");

                if (!int.TryParse(Console.ReadLine(), out opcja) || opcja > 6 || opcja < 1)
                {
                    Console.WriteLine("Wpisałeś niepoprawny numer zadania. Wpisz ponownie.");
                    continue;
                }

                switch (opcja)
                {
                    case 1:
                        Number();
                        break;
                    case 2:
                        WriteEven();

                        break;
                    case 3:
                        Console.WriteLine("Z jakiej liczy chcesz obliczyć silnię?");
                        int siln = int.Parse(Console.ReadLine());
                        Console.WriteLine("Silnia z " + siln + " wynosi " + Silnia(siln));
                        break;
                    case 4:
                        Game();
                        break;
                }
                if (opcja == 5)
                    break;
            }
        }



        static void Number()
        {
            Console.WriteLine("Podaj liczbe:");
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Podana liczba jest liczbą parzystą.");
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine("Podana liczba jest liczbą nieparzystą.");
            }
            else
            {
                Console.WriteLine("Wpisałeś niepoprawną liczbę. Podaj liczbę całkowitą ");
            }


        }

        static void WriteEven()
        {
            Console.WriteLine("Podaj liczbę do której chcesz skończyć odliczanie liczb parzystych: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i <= n; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Wpisałeś niepoprawna liczbę, spróbuj jeszcz raz.");
            }
        }

        static int Silnia(int siln)
        {
            if (siln == 0 || siln == 1)
                return 1;
            else
            {
                return siln * Silnia(siln - 1);
            }
        }

        static void Game()
        {
            Console.WriteLine("Gra na zgadywanie liczby");

            var zliczanie = 0;
            Random random = new Random();
            var liczba = random.Next(1, 21);
            int zgadywana;

            Console.WriteLine("Zgadnij jaką liczbę mam na myśli.");

            do
            {
                zliczanie++;
                Console.WriteLine("Zgadnij liczbę od 1-20");
                zgadywana = int.Parse(Console.ReadLine());

                if (zgadywana > liczba)
                    Console.WriteLine("Liczba, którą próbujesz zgadnąć jest mniejsza");
                if (zgadywana < liczba)
                    Console.WriteLine("Liczba, którą próbujesz zgadnąć jest większa");


            } while (liczba != zgadywana);
            Console.WriteLine("Udało Ci sie zgadnąc za " + zliczanie + " razy");

        }

    }
}
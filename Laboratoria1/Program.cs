using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Net;

internal class Program
{
    // 1 zadanie
    static void Main(string[] args) { 

        Console.WriteLine("Menu: /n");






        Console.WriteLine("Podaj liczbe:");
        var n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Podana liczba jest licbą parzystą.");
        }
        else
        {
            Console.WriteLine("Podana liczba jest liczbą nieparzystą.");
        }



    }

    //zadanie 2
    static void WriteEven()
    {

    Console.WriteLine("Podaj liczbę do której chcesz skończyć odliczanie liczb parzystych: ");
    var n = Convert.ToInt32(Console.ReadLine());


    for (int i = 0; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);

        }
    }
}

static int Silnia(int q)
{
    if (q == 0 || q == 1)
        return 1;
    else
    {
        return (q * Silnia(q - 1));
    }
}

static void Game()
    {
        Console.WriteLine("Gra na zgadywanie liczby");

        var zliczanie = 0;
        Random random = new Random();
        var liczba = random.Next(1,21);
        int zgadywana;

        Console.WriteLine("Zgadnij jaką liczbę mam na myśli.");

        do
        {
            zliczanie++;
            Console.WriteLine("Zgadnij liczbę od 1-20");
            zgadywana = int.Parse(Console.ReadLine());

            if (zgadywana > liczba)
                Console.WriteLine("Liczba, którą probujesz zgadnąć jest miejsza");
            if (zgadywana < liczba)
                 Console.WriteLine();
           

        } while (liczba != zgadywana);
            Console.WriteLine("Udało Ci sie zgadnąc za " + zliczanie + " razy");
        

    }


}
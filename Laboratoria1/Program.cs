﻿using System.Net;

internal class Program
{
    // 1 zadanie
    static void Main(string[] args)
    {


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
        };



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
}
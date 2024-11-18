internal class Program
{

    // 1 zadanie
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe:");
        var n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Podana liczba jest licbą parzystą.");
        }
        else
        {
            Console.WriteLine("Podana liczba jest liczbą nieparzystą");
        };
    }
}
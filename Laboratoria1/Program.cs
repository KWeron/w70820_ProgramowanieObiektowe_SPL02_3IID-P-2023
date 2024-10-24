internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

//zadnaie 2  
void WriteEven()

{
    Console.WriteLine("Podaj n");
    var n = Console.ReadLine();

    for (var i = 0; i < int.Parse(n); i += 2)
    {
        Console.WriteLine(i);
    }

}
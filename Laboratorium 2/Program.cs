// See https://aka.ms/new-console-template for more information

string[] cars = { "volvo", "bmw", "fiat" };
Console.WriteLine(cars[2]);

int arrayLength = cars.Length;
Console.WriteLine(arrayLength);

int i = 0;

while (i <= (arrayLength - 1))
{
    Console.WriteLine(cars[i]);
    if (cars[i] == "bmw")
    {
        break;
    }
    i++;
}
 
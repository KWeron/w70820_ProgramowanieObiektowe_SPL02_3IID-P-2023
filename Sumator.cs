using System;

public class Sumator
{
	private int[] liczby;

	public Sumator(int[] liczby)
	{
		this.liczby = liczby;
	}

	public int Suma()
	{ 
		int suma = 0;
		foreach (int liczba in liczby) 
		{
			suma += liczba;
		}
		return suma;
	}

	public int SumaPodziel3()
	{
		int suma = 0;
        foreach (int liczba in liczby)
        {
			if (liczba % 3 == 0) 
				suma += liczba;
        }
        return suma;
    }

	public int IleElementów()
	{
		return liczby.Lenght;
	}

	public int Wypisywanie() 
	{
		foreach (int liczba in liczby)
		{
			Console.WriteLine(liczba);
		}
	}

	public int DwaParametry(int lowIndex, int highIndex)
	{ 
		if (lowIndex < 0 ) lowIndex = 0;
		if (highIndex >= liczby.Lenght) highIndex = liczby.Lenght - 1;

		for (int i = lowIndex; i <= highIndex; i++)
		{
			Console.WriteLine(liczby[i])
		}
	}
}

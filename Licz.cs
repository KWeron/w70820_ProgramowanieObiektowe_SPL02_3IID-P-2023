using System;

public class Licz
{
	private int wartość;

	public Licz(int wartość)
	{
		this.wartość = wartość; 
	}

	public void Dodaj(int liczba) 
	{
		wartość += liczba;
	}

	public void Odejmij(int liczba)
	{
		wartość -= liczba;
	}

	public void WypisanieStanu()
	{
		Console.WriteLine($"Aktualny wartość: (wartość)");
	}
}

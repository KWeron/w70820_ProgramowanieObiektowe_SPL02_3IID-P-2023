// See https://aka.ms/new-console-template for more information

public class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;
    private string pesel;

    public Osoba(string imie, string nazwisko, int wiek, string pesel)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        Wiek = wiek;
        this.pesel = pesel;
    }

    public string Imie
    {
        get { return imie; }
        set { imie = value; }
    }

    public string Nazwisko
    {
        get { return nazwisko; }
        set { nazwisko = value; }
    }

    public int Wiek
    {
        get { return wiek; }
        set
        {
            if (value < 0)
                wiek = 0;
            else
                wiek = value;
        }
    }

    public string Pesel
    {
        get { return pesel; }
    }

    public string PrzedstawSie
    {
        return $"Nazywam się {Imie} {Nazwisko} i mam {Wiek} lat.";
    }
}

namespace MyHashSetApp;

public class Lehrperson
{
    public string Vorname { get; }
    
    public string Nachname { get; }
    public DateTime Geburtsdatum { get; }
    public Unterrichtsfach Fach { get; }
    public int Wochenstunden { get; }

    public Lehrperson(string vorname, string nachname, DateTime geburtsdatum, Unterrichtsfach fach, int wochenstunden)
    {
        Vorname = vorname;
        Nachname = nachname;
        Geburtsdatum = geburtsdatum;
        Fach = fach;
        Wochenstunden = wochenstunden;
    }

    
    public override string ToString()
    {
        return $"{Nachname} {Vorname}, {Fach}, {Wochenstunden} Std., {Geburtsdatum:dd.MM.yyyy}";
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmeni = "Engin Demirog";
        kurs1.IzlenmeOrani = 7000;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmeni = "Kerem Varis";
        kurs2.IzlenmeOrani = 5000;

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
        
        foreach (Kurs kurs in kurslar )
        {
            Console.WriteLine(kurs.KursAdi + " - " + kurs.Egitmeni + " - " + kurs.IzlenmeOrani);
        }
    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}
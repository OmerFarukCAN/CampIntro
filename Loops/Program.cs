internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "Kurs1";
        string kurs2 = "Kurs2";
        string kurs3 = "Kurs3";

        //array - dizi

        string[] kurslar = new string[] { kurs1, kurs2, kurs3 };

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = new string[] { "Ali", "Veli", "Deli" };
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        names = new string[4];
        names[3] = "Omer";
        Console.WriteLine(names[3]);
        Console.WriteLine("------------");
        Console.WriteLine(names[0]);

        List<string> names2 = new List<string> { "Ali", "Veli", "Deli" };
        Console.WriteLine(names2[0]);
        Console.WriteLine(names2[1]);
        Console.WriteLine(names2[2]);
        names2.Add("Omer");
        Console.WriteLine(names2[3]);
        Console.WriteLine("------------");
        Console.WriteLine(names2[0]);
    }
}

// new denildigi anda yeni referans olusur. Bu örnekte names 2. kez newlendiğinden sadece 4. eleman gözükür.
// List kullanilar bu durumdan kurtulunur.
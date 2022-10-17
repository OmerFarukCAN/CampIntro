using Math;

internal class Program
{
    private static void Main(string[] args)
    {
        DortIslem dortIslem = new DortIslem();
        int topla = dortIslem.Topla(5, 7);
        int carpma = dortIslem.Carpma(5, 7);

        Console.WriteLine(topla);
        Console.WriteLine(carpma);
    }
}
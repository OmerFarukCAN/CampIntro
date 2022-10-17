using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> names = new MyList<string>();
        names.Add("Busra");
        Console.WriteLine(names.Length);
        names.Add("Omer");
        Console.WriteLine(names.Length);

        foreach (var name in names.Items)
        {
            Console.WriteLine(name);
        }
    }
}
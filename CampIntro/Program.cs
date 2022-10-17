internal class Program
{
    private static void Main(string[] args)
    {
        //type safety - tip güvenliği
        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.55;
        double dolarBugun = 7.45;

        if (dolarDun > dolarBugun)
        {
            Console.WriteLine("Azalis Oku");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artis Butonu");
        }
        else
        {
            Console.WriteLine("Esittir Butonu");
        }

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Ayarlar Butonu");
        }
        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }

        Console.WriteLine(kategoriEtiketi);
        Console.WriteLine(ogrenciSayisi);
        Console.WriteLine(faizOrani);
        Console.WriteLine(sistemeGirisYapmisMi);
    }
}
using Methods;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.Name = "Apple";
        product1.Price = 10;
        product1.Explanation = "Amasya's Apple";

        Product product2 = new Product();
        product2.Id = 2;
        product2.Name = "Watermelon";
        product2.Price = 80;
        product2.Explanation = "Diyarbakir's Watermelon";

        Product[] products = new Product[] { product1, product2 };

        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }

        CartManager cartManager = new CartManager();
        cartManager.Add(product1);
    }
}
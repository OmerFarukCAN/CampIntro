using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        // naming convention
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " added cart");
        }
    }
}

using Shoppingcart_lib;

namespace Shoppingcart_lib
{
    public class Product
    {
        public int PId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Categ { get; set; }
    }
}

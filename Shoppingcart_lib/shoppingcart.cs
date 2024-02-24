

using Shoppingcart_lib;

namespace Shoppingcart_lib
{
    public class ShoppingCart
    {
        public int PId { get; set; }
        public string User { get; set; }
        public List<Product> Products { get; set; } =new List<Product>();
    }
}

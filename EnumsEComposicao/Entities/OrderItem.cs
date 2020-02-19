namespace EnumsEComposicao.Entities
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } = new Product();
    }
}

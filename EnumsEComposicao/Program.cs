using EnumsEComposicao.Entities;
using EnumsEComposicao.Entities.Enums;
using System;

namespace EnumsEComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.WriteLine("Name: ");
            string clientName = Console.ReadLine();
            Console.WriteLine("Email: ");
            string clientEmail = Console.ReadLine();
            Console.WriteLine("Birth Date(DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Data: ");
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order?: ");
            int number = int.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, clientBirthDate);
            
            Order order = new Order(DateTime.Now, status);

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Product Name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName);
                OrderItem item = new OrderItem(productQuantity, productPrice, product);
                order.addItem(item);
            }
            Console.WriteLine("Order Sumarry: ");
            Console.WriteLine($"Order moment: {order.Moment} ");
            Console.WriteLine($"Order status: {order.Status} ");
            Console.WriteLine($"Client: {order.Client.Name} - {order.Client.Email} ");
            Console.WriteLine("Order Items: ");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"{item.Product.Name}, {item.Price}, {item.Quantity}, Subtotal: {item.subTotal()} ");
            }
            Console.WriteLine($"Total price: {order.total()}");
        }
    }
}

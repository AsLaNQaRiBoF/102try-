using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = @"C:\test\https://github.com/explore";
            product p1 = new product() { id = 1, Name="Doner", price=4 };
            product p2 = new product() { id = 2, Name="Shaurma", price=5 };

            Orderitem item1 = new Orderitem() { id = 1, Product = p1, count = 2 };
            item1.TotalPrice = p1.price * item1.count;

            Orderitem item2 = new Orderitem() { id = 2, Product = p2, count = 3 };
            item2.TotalPrice = p2.price * item2.count;

            List<Orderitem> items = new List<Orderitem>() { item1, item2 };

            Order order = new Order() { id = 1, Orderitems = items };

            string result = JsonConvert.SerializeObject(order);

        using (var writer = new StreamWriter(@"C:\Users\USER\Desktop\17APR\ConsoleApp1\ConsoleApp1\files\test.json"))
            {
                writer.WriteLine(result);
            }
            string json = string.Empty;
            using (var reader = new StreamReader(@"C:\Users\USER\Desktop\17APR\ConsoleApp1\ConsoleApp1\files\test.json"))
            {
                json = reader.ReadToEnd();
            }

            Order? order = JsonConvert.DeserializeObject<Order>(json);
            foreach (var item in order.Orderitems)
            {
                Console.WriteLine(item.Product.Name + item.Product.Price);
            }
        }
    }
}
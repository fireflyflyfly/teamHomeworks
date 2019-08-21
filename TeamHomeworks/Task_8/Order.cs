using System;
namespace TeamHomeworks.Task_8
{
    [Serializable]
    public class Order
    {
        public int id { get; set; }
        public string type { get; set; }
        public int quantity { get; set; }
        public Customer customer { get; set; }

        public Order()
        {
        }

        public Order(int id, string type, int quantity)
        {
            this.id = id;
            this.type = type;
            this.quantity = quantity;
            this.customer = Customer.CreateCustomer();
        }

        public static Order CreateOrder()
        {
            var random = new Random();

            Console.WriteLine("\nPlease enter your order type:");
            string type = Console.ReadLine();

            Console.WriteLine("\nPlease enter order quantity:");
            int.TryParse(Console.ReadLine(), out int quantity);

            Order order = new Order(random.Next(), type, quantity);
            return order;
        }

        public override string ToString()
        {
            return $"\nOrder ID: {id}, \nOrder Type: {type}, \nOrder Quantity: {quantity}";
        }
    }
}

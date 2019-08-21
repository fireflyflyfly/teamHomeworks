using System;
namespace TeamHomeworks.Task_8
{
    [Serializable]
    public class Shipment
    {
        public string id { get; set; }
        public string address { get; set; }
        public Order order { get; set; }

        public Shipment()
        {
        }

        public Shipment(string id, string address)
        {
            this.id = id;
            this.address = address;
            order = Order.CreateOrder();
        }

        public static Shipment CreateShipment()
        {
            Random random = new Random();
            Console.WriteLine("\nPlease enter shipment address: ");
            string address = Console.ReadLine();
            Shipment shipment = new Shipment(random.Next().ToString(), address);
            return shipment;
        }

        public override String ToString()
        {
            return $"\nShipment Id: {id}, \nShipemnt Address: {address}";
        }


    }
}


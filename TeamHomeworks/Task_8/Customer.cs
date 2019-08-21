using System;
namespace TeamHomeworks.Task_8
{
    [Serializable]
    public class Customer
    {
        public Guid id { get; set; }
        public string name { get; set; }

        public Customer()
        {
        }

        public Customer(Guid id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static Customer CreateCustomer()
        {

            Console.WriteLine("\nPlease etner customer name:");
            Customer customer = new Customer(Guid.NewGuid(), Console.ReadLine());
            return customer;
        }

        public override string ToString()
        {
            return $"\nCustomer ID: {id},\nCustomerName: {name}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace TeamHomeworks.Task_8
{
    public class Task_8_Launcher
    {
        static List<Shipment> shipments = new List<Shipment>();

        public static void LounchTask8()
        {
            //shipments.Add(Shipment.CreateShipment());
            XmlSerializer serializer = new XmlSerializer(typeof(List<Shipment>));
            using (FileStream fileStream = new FileStream("/Users/yegorabramenkov/Documents/VisualStudiFiles/shipments.xml", FileMode.OpenOrCreate))
            {
                shipments = (List<Shipment>)serializer.Deserialize(fileStream);
                PrintShipments(shipments);
            }

        }

        public static void PrintShipments(List<Shipment> shipmentList)
        {
            Console.WriteLine("\nPrint shipments with orders? Yes/No");
            string selection = Console.ReadLine().ToLower();
            switch (selection)
            {
                case "yes":
                    foreach (Shipment shipment in shipmentList)
                    {
                        Console.WriteLine($"{shipment.ToString()} {shipment.order.ToString()} {shipment.order.customer.ToString()}");

                    }
                    break;
                case "no":
                    foreach (Shipment shipment in shipmentList)
                    {
                        Console.WriteLine($"{shipment.ToString()}"); 
                    }
                    break;
            }
        }

    }
}

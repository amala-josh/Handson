using System;

namespace FinalAbstractCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory fact = new ConcreteFactory();
            OrderClient client = new OrderClient(fact);
            client.BuildElectronicOrder(Channel.Ecommerce);
            Console.WriteLine("\n");
            client.BuildFurnitureOrder(Channel.Tele);
            Console.WriteLine("\n");
            client.BuildToyOrder(Channel.Ecommerce);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}

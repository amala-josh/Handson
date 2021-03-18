using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static Factory getFactory(string carname) 
        {
            if (carname == "Mercedes")
            {
                return new MercedesFactory();
            }
            else if (carname == "Audi")
            {
                return new AudiFactory();
            }
            else
            {
                Console.WriteLine("Enter correct value");
                return null;
            }
        }
    }
}

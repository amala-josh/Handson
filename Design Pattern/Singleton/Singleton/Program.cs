using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn instance = DBConn.getInstance();
            DBConn instance1 = DBConn.getInstance();
            instance.PrintDetails("Doing Singleton handson");
            instance1.PrintDetails("Second handson");
            Console.WriteLine(instance.GetHashCode());
            Console.WriteLine(instance1.GetHashCode());
            Console.ReadLine();
        }
    }
}

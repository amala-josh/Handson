using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AysncAwaitUsage1
{
    class Program
    {
        public static async Task FirstMethod()
        {
            Console.WriteLine("First Method started");
            string FM = await SecondMethod();
            Console.WriteLine(FM);
            Console.WriteLine("First Method");
            Console.ReadLine();
        }
        public static async Task<string> SecondMethod()
        {
            Thread.Sleep(5000);
            return "This is Second method";
        }
        static void Main(string[] args)
        {
            FirstMethod();
            Console.ReadLine();
        }
    }
}

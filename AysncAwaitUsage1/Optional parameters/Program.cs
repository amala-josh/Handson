using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_parameters
{
    class Program
    {
        public static void OrderDetails(string SellerName, string ProductName, int OrderQuantity=1, bool IsReturnable=true)
        {
            Console.WriteLine("The order details are= {0} number of {1} by {2} is ordered.\n Return Status is {3}",OrderQuantity,ProductName,SellerName,IsReturnable);
        }
        static void Main(string[] args)
        {
            OrderDetails("Amazon Seller","Mobile phone");
            OrderDetails("Flipkart","T-Shirts",2,false);
            Console.ReadLine();
        }
    }
}

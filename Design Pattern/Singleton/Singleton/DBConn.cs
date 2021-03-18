using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class DBConn
    {
        private static DBConn instance;
        private DBConn()
        {
            Console.WriteLine("Singleton Example");
        }
        public static DBConn getInstance()
        {
            if (instance == null)
            {
                instance = new DBConn();

            }
            return DBConn.instance;
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

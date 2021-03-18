using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ChatMediator chat = new ChatMediator();
            IUser user1 = new PremiumUser() { Name = "AJ" };
            IUser user2 = new BasicUser() { Name = "Asuma" };
            IUser user3 = new BasicUser() { Name = "Kurenai" };

            chat.AddUser(user1);
            chat.AddUser(user2);
            chat.AddUser(user3);



            chat.SendMessage(user1, "Haiiii");
            chat.SendMessage(user3, "Helllo");
            Console.ReadLine();

            Console.ReadLine();
            
        }
    }
}

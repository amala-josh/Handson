using System;
using System.Collections.Generic;
using System.Text;

namespace FinalObserverCaseStudy
{
    class NotificationService : INotificationService
    {
        List<INotificationObserver> observer1 = new List<INotificationObserver>();
        private int Ticket = 0;

        public void TicketsBooked(int num)
        {
            Ticket += num;
            if (Ticket >= 100)
            {
                NotifySubscriber();
            }
        }

        public void AddSubscriber(INotificationObserver observer)
        {
            observer1.Add(observer);
            Console.WriteLine(observer.Name + " is added to subscribers");
            Console.WriteLine("List of Subscribers");
            foreach (var obs in observer1)
            {
                Console.WriteLine(obs.Name);
            }

        }
        public void RemoveSubscriber(INotificationObserver observer)
        {
            observer1.Remove(observer);
            Console.WriteLine(observer.Name + " is removed from subscription");
            Console.WriteLine("List of Subscribers");
            foreach (var obs in observer1)
            {
                Console.WriteLine(obs.Name);
            }
        }
        public void NotifySubscriber()
        {
            foreach (var obs in observer1)
            {
                obs.TicketsBooked();
            }
        }
    }
}

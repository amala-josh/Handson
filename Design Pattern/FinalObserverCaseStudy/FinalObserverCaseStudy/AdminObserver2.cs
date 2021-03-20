using System;
using System.Collections.Generic;
using System.Text;

namespace FinalObserverCaseStudy
{
    class AdminObserver2 : INotificationObserver
    {
        public string Name { get { return "Admin2"; } }
        public void TicketsBooked()
        {
            Console.WriteLine(Name + " Tickets are booked");
          
        }
    }
}

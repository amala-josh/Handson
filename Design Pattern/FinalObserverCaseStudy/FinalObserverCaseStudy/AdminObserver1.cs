using System;
using System.Collections.Generic;
using System.Text;

namespace FinalObserverCaseStudy
{

    class AdminObserver1 : INotificationObserver
    {
        public string Name { get { return "Admin1"; } }
        public void TicketsBooked()
        {
            Console.WriteLine(Name + " Tickets are booked");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FinalObserverCaseStudy
{
    public interface INotificationObserver
    {
        string Name { get; }
        void TicketsBooked();
    }
}

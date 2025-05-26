using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_principles.Core.Interfaces;

namespace Solid_principles.Services
{
    //L - Liskov Substitution Principle :
    //New classes that inherit from INotifier,  can be used in their place in the core code without problems.
    //SRP - Single Responsibility Principle:
    //Each class is responsible for only one function: sending a notification.
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }
}

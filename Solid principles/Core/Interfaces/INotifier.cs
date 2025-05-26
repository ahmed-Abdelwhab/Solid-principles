using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principles.Core.Interfaces
{
    // I - Interface Separation Principle
    //We designed every interface to be simple and clear(a simple, functional interface).
    //Each class uses only the interface it needs, without being forced to add additional functionality it doesn't use.
    public interface INotifier
    {
        void SendNotification(string message);
    }
}

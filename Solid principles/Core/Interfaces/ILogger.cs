using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Solid_principles.Core.Interfaces
{
// I - Interface Separation Principle
//We designed every interface to be simple and clear(a simple, functional interface).
//Each class uses only the interface it needs, without being forced to add additional functionality it doesn't use.
    public interface ILogger
    {
        void Log(string message);
    }
}

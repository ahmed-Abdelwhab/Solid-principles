using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_principles.Core.Interfaces;

namespace Solid_principles.Services
{
//O - Open/Closed Principle:
//If you want to add a new payment type(for example, GooglePay), you'll create a new class that inherits from IPaymentProcessor without modifying the existing code.
//The system is "open to extension" but "closed to modification."
    public class CreditCardPayment : IPaymentProcessor
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} with Credit Card.");
        }
    }
}

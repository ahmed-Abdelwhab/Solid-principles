using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Solid_principles.Core.Interfaces;

namespace Solid_principles.Application
{
//S - Single Responsibility Principle :
//The system is solely responsible for processing the order, but it does not handle payment details, registration, or notifications, and acts as a subclass for other classes.
//D - Dependency Inversion Principle :
//The OrderProcessor relies on abstractions (interfaces) rather than concrete classes.
//This allows you to replace any implementation (for example, use a different logger) without modifying the OrderProcessor.
    public class OrderProcessor
    {
        private readonly ILogger _logger;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly INotifier _notifier;

        public OrderProcessor(ILogger logger, IPaymentProcessor paymentProcessor, INotifier notifier)
        {
            _logger = logger;
            _paymentProcessor = paymentProcessor;
            _notifier = notifier;
        }

        public void ProcessOrder(decimal amount)
        {
            _logger.Log("Starting order processing...");
            _paymentProcessor.Pay(amount);
            _notifier.SendNotification("Your order has been processed.");
            _logger.Log("Order complete.");
        }
    }
}

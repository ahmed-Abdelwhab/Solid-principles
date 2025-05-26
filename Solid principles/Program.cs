using System.Runtime.Intrinsics.Arm;
using Solid_principles.Application;
using Solid_principles.Core.Interfaces;
using Solid_principles.Services;
//D - Dependency Inversion Principle(DIP):
//Here, smart classes are linked via abstractions (interfaces) to the OrderProcessor object.
//This makes the project flexible and easily scalable.
//O - Open/Closed Principle (OCP):
//If you want to change the payment method, simply change what you pass to the OrderProcessor (for example, from CreditCardPayment to PayPalPayment) without modifying the OrderProcessor itself.
ILogger logger = new ConsoleLogger();
IPaymentProcessor paymentProcessor = new CreditCardPayment();

INotifier notifier = new EmailNotifier();

OrderProcessor processor = new OrderProcessor(logger, paymentProcessor, notifier);
processor.ProcessOrder(500);



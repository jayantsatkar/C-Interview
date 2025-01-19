using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }

    public class PaypalPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Process using Paypal GW: " + amount);
        }
    }

    public class GooglePaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Process using Google GW: " + amount);
        }
    }

    public class PhonePePaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Process using PhonePePayment GW: " + amount);
        }
    }

    public static class PaymentGatewayFactoty
    {
        public static IPaymentGateway CreatePaymentGateway(string gatewayName)
        {
            switch (gatewayName.ToLower())
            {
                case "paypal":
                    return new PaypalPaymentGateway();
                case "google":
                    return new GooglePaymentGateway();
                case "phonepe":
                    return new PhonePePaymentGateway();
                default:
                    throw new ArgumentException("Invalid payment gateway specified");
            }
        }
    }
}

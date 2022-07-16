using facade.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Facade
{
    internal class Example1_Facade
    {
        public void Run()
        {
            string a = "1234567890";
            Console.WriteLine(a.Substring(a.Length - 4, 4));
            //number.Length-4, number.Length

            PaymentRequest request = new PaymentRequest();
            request.Ammount = 500;
            request.CardExpDate = "10/2015";
            request.CardName = "Oscar Blancarte";
            request.CardNumber = "1234567890123456";
            request.CardSecureNum = "345";
            request.CustomerId = 1L;

            try
            {
                IPaymentFacade paymentFacade = new OnlinePaymentFacadeImpl();
                paymentFacade.Pay(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsForLunch
{
    class CashRegister
    {



        //member variables (HAS A)
        string paymentType;
      




        //Constructor (BUILDS OBJECT)
        public CashRegister()
        {
            paymentType = "Cash";
        }





        //member methods(CAN DO)
        public void acceptPayment()
        {
            Console.WriteLine("What kind of payment method would you like to Choose? Cash, Card, or Bitcoin?");
                  paymentType = Console.ReadLine();
                switch (paymentType)
            {
                case "Cash":
                    Console.WriteLine("Payment Accepted!");
                    Console.ReadLine();
                    break;
                case "Card":
                    Console.WriteLine("Payment Accepted!");
                    Console.ReadLine();
                    break;
                case "Bitcoin":
                    Console.WriteLine("Payment Accepted!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("We dont accept that type of payment");
                    Console.ReadLine();
                    break;
            }
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsForLunch
{
    class Market
    {


        //member variables (HAS A)
        string name;
        string sandwichOption;
        CashRegister cashRegister;





        //Constructor (BUILDS OBJECT)
        public Market()
        {
            name = "Shawn\'s Sandwiches";
            sandwichOption = "Turkey with Bacon";
            cashRegister = new CashRegister();

        }





        //member methods(CAN DO)
        public void SellItem()
        {
            Console.WriteLine("What kind of sandwich would you like?");
            sandwichOption = Console.ReadLine();
            cashRegister.acceptPayment();
        }






    }
}

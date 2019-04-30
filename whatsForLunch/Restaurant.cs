using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsForLunch
{
    class Restaurant
    {




        //member variables (HAS A)
        string name;
        string FoodItem;
        CashRegister cashRegister;


        //Constructor (BUILDS OBJECT)
        public Restaurant()
        {
            name = "Shawn\'s Restaurant";
            FoodItem = "Meat on a stick";
            cashRegister = new CashRegister();
        }





        //member methods(CAN DO)
        public void SellItem()
        {
            Console.WriteLine("What food would you like?");
            FoodItem = Console.ReadLine();
            cashRegister.acceptPayment();
            
        }





    }
}

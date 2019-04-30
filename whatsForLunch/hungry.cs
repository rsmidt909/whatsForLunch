using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsForLunch
{
    class Person
    {

        //member variables (HAS A)

        Restaurant restaurant;
        Market market;
        CashRegister cashRegister;

        //Constructor (BUILDS OBJECT)
        public Person()
        {
            market = new Market();
            restaurant = new Restaurant();
        }


        //member methods(CAN DO)

        public void whatAreYouHungryFor()
        {
            Console.WriteLine("Would you like the Market, or the Restaurant?");
            string FoodChoice = Console.ReadLine();
            switch (FoodChoice)
            {
                case "Market":
                    Console.WriteLine("Market it is!");
                    market.SellItem();
                    break;
                case "Restaurant":
                    Console.WriteLine("Restaurant it is!");
                    restaurant.SellItem();
                    break;
                default:
                    Console.WriteLine("THATS NOT AN OPTION I GAVE YOU!");
                    break;
            }
        }




    }
}

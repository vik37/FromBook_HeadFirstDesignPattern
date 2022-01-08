using DecoratorPattern_StarbuzzCoffe.Coffe;
using DecoratorPattern_StarbuzzCoffe.Condiment;
using System;

namespace DecoratorPattern_StarbuzzCoffe
{
    class Program
    {
        /*
         * The Decorator Pattern: attaches additional responsibilities to an object dinamicly.
         * Decorators provide a flexible alternative to cubclassing for extending functionality.
         */
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            Console.WriteLine($"{beverage.GetDescription()} = {beverage.Cost()} $");

            Beverage beverage2 = new DarkRoast();
           // Console.WriteLine(beverage2.GetDescription());
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} = {Math.Round(beverage2.Cost(), 3)} $");

            Beverage beverage3 = new HouseBland();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()} = {Math.Round(beverage3.Cost(), 3)} $");
            Console.ReadLine();
        }
    }
}

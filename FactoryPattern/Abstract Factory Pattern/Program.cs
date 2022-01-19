using FactoryPattern.PizzaStores;
using System;

namespace FactoryPattern
{
    /*
     * THE ABSTRACT FACTORY PATTERN - provides an interface
     *    for creating family of related  or depend objects
     *    without specifying their concrate classes.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of pizza does someone want to order?");
            Console.WriteLine("------------------------");
            string order1 = Console.ReadLine();
            PizzaStore pizza = new NYPizzaStore();
            
            pizza.OrderPizza(order1);

            Console.WriteLine("------------------------");

            pizza = new ChicagoPizzaStore();
            pizza.OrderPizza("veggie");

            Console.ReadLine();
        }
    }
}

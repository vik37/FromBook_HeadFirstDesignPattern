using FactoryPattern.PizzaStores;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what pizza do you want?");
            Console.WriteLine("------------------------");
            PizzaStore pizzaStoreChicago1 = new ChicagoStylePizzaFactory();
            pizzaStoreChicago1.OrderPizza(Console.ReadLine());

            PizzaStore pizzaStoreChicago2 = new NYPizzaFactory();
            pizzaStoreChicago2.OrderPizza(Console.ReadLine());

            

            Console.ReadLine();
        }
    }
}

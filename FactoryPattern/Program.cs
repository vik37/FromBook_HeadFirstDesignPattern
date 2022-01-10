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
            PizzaStore nyStore = new NYPizzaFactory();
            PizzaStore chickagoStor = new ChicagoStylePizzaFactory();
            Pizza pizza = nyStore.OrderPizza("cheese");

            Console.WriteLine($"Stefan order a {pizza.Name} \n\n");

            pizza = chickagoStor.OrderPizza("veggie");

            Console.WriteLine($"Marika order a {pizza.Name}");

            

            Console.ReadLine();
        }
    }
}

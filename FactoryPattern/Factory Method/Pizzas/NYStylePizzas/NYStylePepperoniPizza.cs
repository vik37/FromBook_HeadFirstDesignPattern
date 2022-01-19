using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.NYStylePizzas
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            _name = "NY Style Sauce and Cheese Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";
            _toppings.Add("Greated Reggiano Cheese");
        }
    
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

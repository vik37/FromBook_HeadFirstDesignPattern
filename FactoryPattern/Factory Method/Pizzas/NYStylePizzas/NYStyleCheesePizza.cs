using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.NYStylePizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            _name = "NY Style Sauce and Cheese Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";
            _toppings.Add("Greated Reggiano Cheese");
        }
    }
}

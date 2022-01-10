using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.ChicagoStyle
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            _name = "Chicago Style Deep Dish Pepperoni Pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";
            _toppings.Add("Shredded Mozzarella Cheese");
            _toppings.Add("cloves garlic");
            _toppings.Add("minced");
        }
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

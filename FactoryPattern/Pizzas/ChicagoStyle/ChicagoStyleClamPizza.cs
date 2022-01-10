using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.ChicagoStyle
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            _name = "Chicago Style Deep Dish Clum Pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";
            _toppings.Add("Shredded Mozzarella Cheese");
        }
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

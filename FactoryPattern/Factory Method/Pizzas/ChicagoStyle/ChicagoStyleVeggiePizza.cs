using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas.ChicagoStyle
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            _name = "Chicago Style Deep Dish Cheese Pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";
            _toppings.Add("Shredded Mozzarella Cheese");
            _toppings.Add("teaspoon dried oregano");
        }
    }
}

using FactoryPattern.Ingredients;
using FactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type, Pizza pizza = null)
        {
            IPizzaIngredientFactory pizzaIngredientFactory = new NewYorkPizzaIngredientFactory();
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(pizzaIngredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    return pizza;
                case "greek":
                    pizza = new GreekPizza(pizzaIngredientFactory);
                    pizza.Name = "New York Style Greek Pizza";
                    return pizza;
                case "clam":
                    pizza = new ClamPizza(pizzaIngredientFactory);
                    pizza.Name = "New York Style Clam Pizza";
                    return pizza;
                case "veggie":
                    pizza = new VeggiePizza(pizzaIngredientFactory);
                    pizza.Name = "New York Style Veggie Pizza";
                    return pizza;
                case "pepperoni":
                    pizza = new PepperoniPizza(pizzaIngredientFactory);
                    pizza.Name = "New York Style Pepperoni Pizza";
                    return pizza;
                default:
                    return null;
            }
        }
    }
}

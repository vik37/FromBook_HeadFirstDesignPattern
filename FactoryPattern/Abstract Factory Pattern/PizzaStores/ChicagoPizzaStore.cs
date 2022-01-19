using FactoryPattern.Ingredients;
using FactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type, Pizza pizza)
        {
            IPizzaIngredientFactory pizzaIngredientFactory = new NewYorkPizzaIngredientFactory();
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(pizzaIngredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    return pizza;
                case "greek":
                    new GreekPizza(pizzaIngredientFactory);
                    pizza.Name = "Chicago Style Greek Pizza";
                    return pizza;
                case "clam":
                    pizza = new ClamPizza(pizzaIngredientFactory);
                    pizza.Name = "Chicago Style Clam Pizza";
                    return pizza;
                case "veggie":
                    pizza = new VeggiePizza(pizzaIngredientFactory);
                    pizza.Name = "Chicago Style Veggie Pizza";
                    return pizza; 
                case "pepperoni":
                    pizza = new PepperoniPizza(pizzaIngredientFactory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    return pizza;
                default:
                    return null;

            }
        }
    }
}

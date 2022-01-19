using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDought();
        Sauce CreateSouce();
        Cheese CreateCheese();
        List<Veggie> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}

using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients.Entitities
{
    public class MozzarellaCheese : Cheese
    {
        public void TypeOfIngredientCheese()
        {
            Console.WriteLine("Mozzarella Cheese");
        }
    }
}

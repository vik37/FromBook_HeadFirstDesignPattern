using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients.Entitities
{
    public class ReggianoCheese : Cheese
    {
        public void TypeOfIngredientCheese()
        {
            Console.WriteLine("Regiano Cheese");
        }
    }
}

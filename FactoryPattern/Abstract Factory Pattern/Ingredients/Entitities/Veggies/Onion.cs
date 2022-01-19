using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients.Entitities.Veggies
{
    public class Onion : Veggie
    {
        public void TypeOfIngredientVeggie()
        {
            Console.WriteLine("Onion");
        }
    }
}

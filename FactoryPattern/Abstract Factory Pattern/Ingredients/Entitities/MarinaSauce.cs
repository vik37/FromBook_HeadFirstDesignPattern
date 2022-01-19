using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients.Entitities
{
    public class MarinaSauce : Sauce
    {
        public void TypeOfIngredientSauce()
        {
            Console.WriteLine("Marina Sauce");
        }
    }
}

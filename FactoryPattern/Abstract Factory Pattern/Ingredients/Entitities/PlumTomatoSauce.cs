using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients.Entitities
{
    public class PlumTomatoSauce : Sauce
    {
        public void TypeOfIngredientSauce()
        {
            Console.WriteLine("Plum Tomato Sauce");
        }
    }
}

using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients.Entitities
{
    public class ThinCrustDough : Dough
    {
        public void TypeOfIngredientDought()
        {
            Console.WriteLine("Dought");
        }
    }
}

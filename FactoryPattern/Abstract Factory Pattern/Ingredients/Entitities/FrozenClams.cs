using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients.Entitities
{
    public class FrozenClams : Clams
    {
        public void TypeOfIngredientClams()
        {
            Console.WriteLine("Frozen Clams");
        }
    }
}

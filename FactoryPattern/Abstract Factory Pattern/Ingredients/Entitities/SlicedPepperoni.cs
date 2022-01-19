﻿using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients.Entitities
{
    public class SlicedPepperoni : Pepperoni
    {
        public void TypeOfIngredientPepperoni()
        {
            Console.WriteLine("Sliced Pepperoni");
        }
    }
}

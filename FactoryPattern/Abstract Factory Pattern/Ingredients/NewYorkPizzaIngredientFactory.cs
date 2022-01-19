using FactoryPattern.Ingredients.Entitities;
using FactoryPattern.Ingredients.Entitities.Veggies;
using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients
{
    public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDought()
        {
            return new ThinCrustDough();
        }
        public Sauce CreateSouce()
        {
            return new MarinaSauce();
        }
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie>
            {
                new Garlic(), new Onion(), new Mushroom(), new RedPepper()

            };
        }
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams CreateClams()
        {
            return new FreshCLams();
        }     
    }
}

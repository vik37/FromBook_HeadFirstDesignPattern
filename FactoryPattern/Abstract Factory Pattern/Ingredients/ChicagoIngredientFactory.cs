using FactoryPattern.Ingredients.Entitities;
using FactoryPattern.Ingredients.Entitities.Veggies;
using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients
{
    public class ChicagoIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDought()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSouce()
        {
            return new PlumTomatoSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie>
            {
                new BlackOlives(), new Spinach(), new EggPlant()
            };
        }
    }
}

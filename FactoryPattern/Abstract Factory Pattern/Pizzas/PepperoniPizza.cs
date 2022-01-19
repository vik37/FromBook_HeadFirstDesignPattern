using FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _dough = _ingredientFactory.CreateDought();
            _sauce = _ingredientFactory.CreateSouce();
            _cheese = _ingredientFactory.CreateCheese();
            _pepperoni = _ingredientFactory.CreatePepperoni();
            Composition();
        }
        public void Composition()
        {
            Console.WriteLine("COMPOSITIONS: ");
            Console.Write("- ");
            _dough.TypeOfIngredientDought();
            Console.Write("- ");
            _sauce.TypeOfIngredientSauce();
            Console.Write("- ");
            _cheese.TypeOfIngredientCheese();
            Console.Write("- ");
            _pepperoni.TypeOfIngredientPepperoni();
        }
    }
}

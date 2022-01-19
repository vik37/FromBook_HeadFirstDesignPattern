using FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _dough = _ingredientFactory.CreateDought();
            _sauce = _ingredientFactory.CreateSouce();
            _cheese = _ingredientFactory.CreateCheese();
            _clams = _ingredientFactory.CreateClams();
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
            _clams.TypeOfIngredientClams();
        }
    }
}

using FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas
{
    public class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _dough = _ingredientFactory.CreateDought();
            _sauce = _ingredientFactory.CreateSouce();
            _veggies = _ingredientFactory.CreateVeggies();
            Composition();
        }
        public void Composition()
        {
            int count = 0;
            Console.WriteLine("COMPOSITIONS: ");
            Console.Write("- ");
            _dough.TypeOfIngredientDought();
            Console.Write("- ");
            _sauce.TypeOfIngredientSauce();
            Console.WriteLine(" VEGGIES: ");
            foreach (var veggie in _veggies)
            {
                count+=1;
                Console.Write($"{count}. ");
                veggie.TypeOfIngredientVeggie();
            }
        }
    }
}

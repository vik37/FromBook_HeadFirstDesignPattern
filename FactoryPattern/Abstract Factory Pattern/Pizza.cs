using FactoryPattern.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected Dough _dough;
        protected Sauce _sauce;
        protected List<Veggie> _veggies;
        protected Cheese _cheese;
        protected Pepperoni _pepperoni;
        protected Clams _clams;
       
        public abstract void Prepare();
        
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

    }
}

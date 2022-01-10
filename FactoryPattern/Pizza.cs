using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public abstract void TypeOfPizza();
        public void Prepare()
        {
            Console.WriteLine("Prepare");
        }
        public void Bake()
        {
            Console.WriteLine("Bake");
        }
        public void Cut()
        {
            Console.WriteLine("Cut");
        }
        public void Box()
        {
            Console.WriteLine("Box");
        }
    }
}

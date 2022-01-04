using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks.Behaviours
{
    public class Squeack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("rubber duck squeack");
        }
    }
}

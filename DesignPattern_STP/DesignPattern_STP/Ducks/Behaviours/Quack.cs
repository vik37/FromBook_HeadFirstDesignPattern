using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks.Behaviours
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Duck quack, quack...");
        }
    }
}

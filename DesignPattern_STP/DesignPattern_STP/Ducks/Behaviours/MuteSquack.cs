using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks.Behaviours
{
    public class MuteSquack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Do nothing - can't quack");
        }
    }
}

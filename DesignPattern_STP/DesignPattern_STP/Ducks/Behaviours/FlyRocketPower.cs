using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks.Behaviours
{
    public class FlyRocketPower : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with a rocket!");
        }
    }
}

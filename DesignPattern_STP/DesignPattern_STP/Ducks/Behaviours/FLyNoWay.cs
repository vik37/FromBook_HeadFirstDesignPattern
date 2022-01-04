using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_STP.Ducks.Behaviours
{
    public class FLyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can not fly");
        }
    }
}

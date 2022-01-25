using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Turn on");
        }
        public void Off()
        {
            Console.WriteLine("Turn off");
        }
    }
}

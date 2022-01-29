using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Device
{
    public class Light
    {
        private string _place;
        public Light(string place)
        {
            this._place = place;
        }
        public void On()
        {
            Console.WriteLine($"{_place} Light is on");
        }
        public void Off()
        {
            Console.WriteLine($"{_place} Light is  off");
        }
    }
}

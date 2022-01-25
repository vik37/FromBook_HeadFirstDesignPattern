using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Device
{
    public class CeilingFan
    {
        private string _place;
        public CeilingFan(string place)
        {
            this._place = place;
        }
        public void On()
        {
            Console.WriteLine($"{_place} Ceiling Fun is on");
        }
        public void Off()
        {
            Console.WriteLine($"{_place} Ceiling Fun is off");
        }
    }
}

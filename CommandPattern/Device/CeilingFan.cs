using CommandPattern.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Device
{
    public class CeilingFan
    {
        private string _place;
        private CeilingFanSpeed _speed;
        public CeilingFan(string place)
        {
            this._place = place;
            _speed = CeilingFanSpeed.OFF;
        }
        public void High()
        {
            _speed = CeilingFanSpeed.HIGH;
            Console.WriteLine($"{_place} Ceiling Fun is on HIGH");
        }
        public void Medium()
        {
            _speed = CeilingFanSpeed.MEDIUM;
            Console.WriteLine($"{_place} Ceiling Fun is on MEDIUM");
        }
        public void Low()
        {
            _speed = CeilingFanSpeed.LOW;
            Console.WriteLine($"{_place} Ceiling Fun is on LOW");
        }
        public void On()
        {
            Console.WriteLine($"{_place} Ceiling Fun is on");
        }
        public void Off()
        {
            _speed = CeilingFanSpeed.OFF;
            Console.WriteLine($"{_place} Ceiling Fun is off");
        }
        public CeilingFanSpeed GetSpeed()
        {
            return _speed;
        }
    }
}

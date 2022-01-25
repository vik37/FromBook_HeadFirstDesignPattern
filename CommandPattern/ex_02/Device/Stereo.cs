using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Device
{
    public class Stereo
    {
        public int Volume { get; private set; }
        private string _place;
        public Stereo(string place)
        {
            this._place = place;
        }
        public void On()
        {
            Console.WriteLine($"{_place} Stereo Turn On");
        }
        public void Off()
        {
            Console.WriteLine($"{_place} Stereo Turn Off");
        }
        public void SetCd()
        {
            Console.WriteLine($"{_place} Stereo is set on CD");
        }
        public void SetDvd()
        {
            Console.WriteLine($"{_place} Stereo is set on DVD");
        }
        public void SetRadio()
        {
            Console.WriteLine($"{_place} Stereo is set on Radio");
        }
        public void SetVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine($"{_place} Stereo volume set to {Volume}");
        }
    }
}

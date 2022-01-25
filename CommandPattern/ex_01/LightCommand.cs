using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class LightCommand : Command
    {
        private Light _light;
        public LightCommand(Light light)
        {
            this._light = light;
        }
        public void Execute()
        {
            _light.On();
        }
    }
}

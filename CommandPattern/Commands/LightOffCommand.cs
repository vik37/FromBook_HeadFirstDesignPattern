using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Device;


namespace CommandPattern.Commands
{
    public class LightOffCommand : Command
    {
        private Light _light;
        public LightOffCommand(Light light)
        {
            this._light = light;
        }
        public void Execute()
        {
            _light.Off();
        }
        public void Undo()
        {
            _light.On();
        }
    }
}


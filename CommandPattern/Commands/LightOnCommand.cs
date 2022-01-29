using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Device;


namespace CommandPattern.Commands
{
    public class LightOnCommand : Command
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            this._light = light;
        }
        public void Execute()
        {
            _light.On();
        }
        public void Undo()
        {
            _light.Off();
        }
    }
    
}

using CommandPattern.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class GarageDoorDownCommand
    {
        private GarageDoor _garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Down();
        }
    }
}

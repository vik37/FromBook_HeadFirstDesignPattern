using CommandPattern.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class GarageDoorUpCommand
    {
        private GarageDoor _garageDoor;
        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}

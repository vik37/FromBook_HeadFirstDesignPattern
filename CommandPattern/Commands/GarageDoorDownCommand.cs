using CommandPattern.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class GarageDoorDownCommand : Command
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

        public void Undo()
        {
            _garageDoor.Up();
        }
    }
}

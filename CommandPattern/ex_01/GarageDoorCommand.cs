using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class GarageDoorCommand : Command
    {
        private GarageDoor _garageDoor;
        public GarageDoorCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}

using CommandPattern.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class CeilingFanOnCommand : Command
    {
        private CeilingFan _ceilingFan;
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _ceilingFan.On();
        }
        public void Undo()
        {
            _ceilingFan.Off();
        }
    }
}

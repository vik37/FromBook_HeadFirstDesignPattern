using CommandPattern.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class CeilingFanOffCommand : Command
    {
        private CeilingFan _ceilingFan;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _ceilingFan.Off();            
        }
    }
}

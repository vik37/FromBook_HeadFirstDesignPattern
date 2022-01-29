using CommandPattern.Device;
using CommandPattern.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class CeilingFanHighCommand : Command
    {
        private CeilingFan _ceilingFan;
        private CeilingFanSpeed _prevSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
        }

        public void Undo()
        {
            if(_prevSpeed == CeilingFanSpeed.HIGH)
            {
                _ceilingFan.High();
            }
            else if(_prevSpeed == CeilingFanSpeed.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if(_prevSpeed == CeilingFanSpeed.LOW)
            {
                _ceilingFan.Low();
            }
            else
            {
                _ceilingFan.Off();
            }
        }
    }
}

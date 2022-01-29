using CommandPattern.Device;
using CommandPattern.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class CeilingFanLowCommand : Command
    {
        private CeilingFan _ceilingFan;
        private CeilingFanSpeed _prevSpeed;
        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Low();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFanSpeed.LOW)
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

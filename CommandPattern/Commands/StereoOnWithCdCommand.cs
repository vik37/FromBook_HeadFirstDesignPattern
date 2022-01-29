using CommandPattern.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class StereoOnWithCdCommand : Command
    {
        private Stereo _stereo;
        public StereoOnWithCdCommand(Stereo stereo)
        {
            this._stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}

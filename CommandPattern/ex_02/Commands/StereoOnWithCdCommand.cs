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
            _stereo.Off();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }
    }
}

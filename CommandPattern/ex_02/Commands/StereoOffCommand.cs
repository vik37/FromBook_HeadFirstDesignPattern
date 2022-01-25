using CommandPattern.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class StereoOffCommand : Command
    {
        private Stereo _stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this._stereo = stereo;
        }
        public void Execute()
        {
            _stereo.Off();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        private Command _slot;
        public void SetCommand(Command command)
        {
            _slot = command;
        }
        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}

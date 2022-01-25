using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        private Command[] _onCommands;
        private Command[] _offCommands;
        public RemoteControl()
        {
            _onCommands = new Command[7];
            _offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }
        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }
        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }
        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append("\n ------ Remote Control --------- \n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                strBuild.Append($"[slot {i}] {_onCommands[i].GetType().Name}   {_offCommands[i].GetType().Name} \n");
            }
            return strBuild.ToString();
        }
    }
}

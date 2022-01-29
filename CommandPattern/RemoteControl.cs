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
        private Command _undoCommand;
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
            _undoCommand = noCommand;
        }
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }
        public void OnButtonWasPushed(int slot)
        {
            if(_onCommands[slot] != null)
            {
                _onCommands[slot].Execute();
                _undoCommand = _onCommands[slot];
            }
            
        }
        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }
        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }
        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append("\n ------ Remote Control --------- \n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                strBuild.Append($"[slot {i}] {_onCommands[i].GetType().Name}   {_offCommands[i].GetType().Name} \n");
            }
            strBuild.Append($"[undo] {_undoCommand.GetType().Name}");
            return strBuild.ToString();
        }
    }
}

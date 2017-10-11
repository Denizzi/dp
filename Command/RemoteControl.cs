using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RemoteControl
    {
        private IList<ICommand> _onCommands;
        private IList<ICommand> _offCommands;


        public RemoteControl()
        {
            _onCommands = new List<ICommand>();
            _offCommands = new List<ICommand>();

            var noCommand = new NoCommand();

            _onCommands.Add(noCommand);
            _offCommands.Add(noCommand);
        }
    }
}

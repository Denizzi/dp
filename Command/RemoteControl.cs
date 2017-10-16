using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /* The Invoker class */
    public class RemoteControl
    {
        private ICommand _onCommand;
        private ICommand _offCommand;


        public RemoteControl(ICommand onCommand, ICommand offCommand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
        }

        public void Open()
        {
            _onCommand.Execute();
        }

        public void Close()
        {
            _offCommand.Execute();
        }
    }
}

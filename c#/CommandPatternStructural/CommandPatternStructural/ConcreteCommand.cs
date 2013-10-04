using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStructural
{
    // <summary>
    // This is an actual command. It implements the Command interface
    // and it defines the binding between the receiver object and its
    // action. It implements the execute method by calling the corresponding
    // action on the receiver.
    // </summary>
    class ConcreteCommand : Command
    {
        private Receiver _receiver;

        public ConcreteCommand(Receiver receiver)
        {
            this._receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.Action();
        }
    }
}

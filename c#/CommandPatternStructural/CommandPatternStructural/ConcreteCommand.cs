using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStructural
{
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

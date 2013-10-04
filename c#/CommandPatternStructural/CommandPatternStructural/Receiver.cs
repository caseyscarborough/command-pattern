using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStructural
{
    class Receiver
    {
        public void Action()
        {
            Console.Write("Receiver.Action() has been called!");
        }
    }
}

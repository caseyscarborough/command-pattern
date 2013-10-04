using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStructural
{
    // <summary>
    // The receiver is the object which the action is being
    // performed on. It knows how to perform the operations
    // associated with carrying out the request.
    // </summary>
    public interface Command
    {
        void Execute();
    }
}

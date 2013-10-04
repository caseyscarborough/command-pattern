using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStructural
{   
    // <summary>
    // This is essentially the Client. It is the main application and
    // handles the creation of the Command object and setting its receiver,
    // and then passing that command object to the invoker. The commands
    // can then be executed via the invoker.
    // </summary>
    class Program
    {
        static void Main(string[] args)
        {   
            // Create a new receiver.
            Receiver receiver = new Receiver();

            // Create a new command and bind it to our receiver.
            Command command = new ConcreteCommand(receiver);

            // Create a new invoker to execute commands.
            Invoker invoker = new Invoker();

            // Set the invoker's command and execute it.
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Wait for user.
            Console.ReadKey();
        }
    }
}

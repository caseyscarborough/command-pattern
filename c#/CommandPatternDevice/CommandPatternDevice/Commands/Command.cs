using CommandPatternDevice.Receivers;

namespace CommandPatternDevice.Commands
{   
    ///<summary>
    /// This is our Command abstract class. All ConcreteCommands 
    /// will implement this class, requiring them to implement
    /// the methods in the interface.
    ///</summary>
    public abstract class Command
    {
        // This is the device (Receiver) that we will perform our commmand on.
        protected Device device;

        // The defaul constructor. Sets the device (Receiver) for the command
        // to be executed on.
        public Command(Device device)
        {
            this.device = device;
        }

        // Every command must implement an Execute method.
        public abstract void Execute();

        // It must also have an Undo method.
        public abstract void Undo();
    }
}

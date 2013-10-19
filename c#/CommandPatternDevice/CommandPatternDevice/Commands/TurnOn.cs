using CommandPatternDevice.Receivers;

namespace CommandPatternDevice.Commands
{
    ///<summary>
    /// This is one of our ConcreteCommands in the Command
    /// Pattern. This is used to turn a device on.
    ///</summary>
    public class TurnOn : Command
    {
        public TurnOn(Device device) : base(device) { }

        public override void Execute()
        {
            this.device.On();
        }

        public override void Undo()
        {
            this.device.Off();
        }
    }
}

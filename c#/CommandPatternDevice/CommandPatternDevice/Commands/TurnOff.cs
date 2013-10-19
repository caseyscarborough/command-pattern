using CommandPatternDevice.Receivers;

namespace CommandPatternDevice.Commands
{
    ///<summary>
    /// This is one of our ConcreteCommands in the Command
    /// Pattern. This is used to turn a device off.
    ///</summary>
    public class TurnOff : Command
    {
        public TurnOff(Device device) : base(device) { }

        public override void Execute()
        {
            this.device.Off();
        }

        public override void Undo()
        {
            this.device.On();
        }
    }
}

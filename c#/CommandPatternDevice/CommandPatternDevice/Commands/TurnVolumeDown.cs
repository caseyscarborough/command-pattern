using CommandPatternDevice.Receivers;

namespace CommandPatternDevice.Commands
{
    ///<summary>
    /// This is one of our ConcreteCommands in the Command
    /// Pattern. This is used to turn a device's volume down.
    ///</summary>
    public class TurnVolumeDown : Command
    {
        public TurnVolumeDown(Device device) : base(device) { }

        public override void Execute()
        {
            this.device.VolumeDown();
        }

        public override void Undo()
        {
            this.device.VolumeUp();
        }
    }
}

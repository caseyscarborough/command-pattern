using CommandPatternDevice.Receivers;

namespace CommandPatternDevice.Commands
{
    ///<summary>
    /// This is one of our ConcreteCommands in the Command
    /// Pattern. This is used to turn a device's volume up.
    ///</summary>
    public class TurnVolumeUp : Command
    {
        public TurnVolumeUp(Device device) : base(device) { }

        public override void Execute()
        {
            this.device.VolumeUp();
        }

        public override void Undo()
        {
            this.device.VolumeDown();
        }
    }
}

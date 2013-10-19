using CommandPatternDevice.Commands;

namespace CommandPatternDevice.Invokers
{
    /// <summary>
    ///  This is our Invoker. It handles the execution of the command.
    ///  It knows nothing about the command, or the device that it is
    ///  executing the command on.
    /// </summary>
    class DeviceButton
    {
        private Command _command;

        public DeviceButton(Command command)
        {
            this._command = command;
        }

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void Press()
        {
            this._command.Execute();
        }

        internal void PressUndo()
        {
            this._command.Undo();
        }
    }
}

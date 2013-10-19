namespace CommandPatternDevice.Receivers
{
    /// <summary>
    /// This abstract class is used to define the methods that will
    /// be used for each of our devices. These devices are the
    /// "Receivers" in the Command Pattern.
    /// </summary>
    public abstract class Device
    {
        protected int volume = 0;

        public abstract void On();
        public abstract void Off();
        public abstract void VolumeUp();
        public abstract void VolumeDown();
    }
}

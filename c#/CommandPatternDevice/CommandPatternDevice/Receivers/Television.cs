using System;

namespace CommandPatternDevice.Receivers
{
    /// <summary>
    /// This is our actual receiver. It implements the methods
    /// defined in the Device abstract class. This class (Receiver)
    /// holds the information needed to execute the actual commands.
    /// </summary>
    class Television : Device
    {
        public override void On()
        {
            Console.WriteLine("The TV is now on.");
        }

        public override void Off()
        {
            Console.WriteLine("The TV is now off.");
        }

        public override void VolumeUp()
        {
            this.volume++;
            Console.WriteLine("TV volume: " + this.volume);
        }

        public override void VolumeDown()
        {
            this.volume--;
            Console.WriteLine("TV volume: " + this.volume);
        }
    }
}

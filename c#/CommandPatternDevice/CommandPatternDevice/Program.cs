using System;

using CommandPatternDevice.Commands;
using CommandPatternDevice.Invokers;
using CommandPatternDevice.Receivers;

namespace CommandPatternDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new television.
            Device television = new Television();

            // Create a new command to turn on the television.
            Command turnTelevisionOn = new TurnOn(television);

            // Create a new device button and set the command to
            // turn the television on.
            DeviceButton deviceButton = new DeviceButton(turnTelevisionOn);

            // Press the device button (in turn, executing the command).
            deviceButton.Press();

            // Make a new command to turn off the television, set
            // the command for the device button, and "press" it.
            Command turnTelevisionOff = new TurnOff(television);
            deviceButton.SetCommand(turnTelevisionOff);
            deviceButton.Press();

            Command turnTelevisionVolumeUp = new TurnVolumeUp(television);
            deviceButton.SetCommand(turnTelevisionVolumeUp);

            // Press the button multiple times, then "press" undo.
            deviceButton.Press();
            deviceButton.Press();
            deviceButton.Press();
            deviceButton.PressUndo();
            deviceButton.PressUndo();

            // Instantiate a radio!
            Device radio = new Radio();

            // Make a command to turn the radio off, since we can
            // just use Spotify.
            Command turnRadioOff = new TurnOff(radio);

            deviceButton.SetCommand(turnRadioOff);
            deviceButton.Press();

            Console.ReadKey();

        }
    }
}

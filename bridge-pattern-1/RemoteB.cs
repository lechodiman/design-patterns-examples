using System;

namespace bridge_pattern_1
{
    public class RemoteB : RemoteImplementor
    {
        public override void ChannelUpButtonPressed()
        {
            System.Console.WriteLine("Remote B: Channel Up");
        }

        public override void ChannelDownButtonPressed()
        {
            System.Console.WriteLine("Remote B: Channel Up");
        }
    }
}

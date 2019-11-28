using System;

namespace bridge_pattern_1
{
    public class RemoteA : RemoteImplementor
    {
        public override void ChannelUpButtonPressed()
        {
            System.Console.WriteLine("Remote A: Channel Up");
        }

        public override void ChannelDownButtonPressed()
        {
            System.Console.WriteLine("Remote A: Channel Down");
        }
    }
}

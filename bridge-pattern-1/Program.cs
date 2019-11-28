using System;

namespace bridge_pattern_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteA = new RemoteA();
            var remoteB = new RemoteB();

            remoteA.ChannelDownButtonPressed();
            remoteB.ChannelUpButtonPressed();

            var remoteAPlus = new RemoteAPus(remoteA);
            var remoteBPlus = new RemoteBPus(remoteB);

            remoteAPlus.ChannelUpButtonPressed();
            remoteAPlus.PauseButtonPressed();

            var remoteAPlus2 = new RemoteAPus(new RemoteB());
            remoteAPlus2.ChannelUpButtonPressed();
        }
    }
}

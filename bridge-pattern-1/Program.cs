using System;

namespace bridge_pattern_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteA = new RemoteA();
            remoteA.ChannelDownButtonPressed();

            var remoteB = new RemoteB();
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

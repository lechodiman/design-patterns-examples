using System;

namespace bridge_pattern_1
{
    public class RemoteBPus : PlusRemoteAbstraction
    {
        public RemoteBPus(RemoteImplementor remoteImplementor) : base(remoteImplementor) { }

        public override void PlayButtonPressed()
        {
            System.Console.WriteLine("Remote B: Play");
        }

        public override void PauseButtonPressed()
        {
            System.Console.WriteLine("Remote B: Play");
        }
    }
}

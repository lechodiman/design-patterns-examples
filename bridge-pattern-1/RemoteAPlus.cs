using System;

namespace bridge_pattern_1
{
    public class RemoteAPus : PlusRemoteAbstraction
    {
        public RemoteAPus(RemoteImplementor remoteImplementor) : base(remoteImplementor) { }

        public override void PlayButtonPressed()
        {
            System.Console.WriteLine("Remote A: Play");
        }

        public override void PauseButtonPressed()
        {
            System.Console.WriteLine("Remote A: Pause");
        }
    }
}

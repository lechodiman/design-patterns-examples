using System;

namespace bridge_pattern_1
{
    public abstract class PlusRemoteAbstraction
    {
        private RemoteImplementor _remoteImplementor;

        protected PlusRemoteAbstraction(RemoteImplementor remoteImplementor)
        {
            _remoteImplementor = remoteImplementor;
        }

        public void ChannelUpButtonPressed()
        {
            _remoteImplementor.ChannelUpButtonPressed();
        }

        public void ChannelDownButtonPressed()
        {
            _remoteImplementor.ChannelDownButtonPressed();
        }

        public abstract void PlayButtonPressed();

        public abstract void PauseButtonPressed();
    }
}

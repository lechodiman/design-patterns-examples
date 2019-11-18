using System;

namespace bridge
{
    public interface Remote
    {
        void Power();
        void VolumeDown();
        void VolumeUp();
    }

    public class BasicRemote : Remote
    {
        protected Device device;

        public BasicRemote() { }

        public BasicRemote(Device device)
        {
            this.device = device;
        }

        public void Power()
        {
            System.Console.WriteLine("Remote: power toggle");
            if (device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }

        public void VolumeDown()
        {
            System.Console.WriteLine("Remote: volume down");
            device.SetVolume(device.GetVolume() - 10);
        }

        public void VolumeUp()
        {
            System.Console.WriteLine("Remote: volume up");
            device.SetVolume(device.GetVolume() + 10);
        }
    }

    public class AdvancedRemote : BasicRemote
    {
        public AdvancedRemote(Device device) : base(device)
        {

        }

        public void Mute()
        {
            System.Console.WriteLine("Remote: mute");
            device.SetVolume(0);
        }
    }
}

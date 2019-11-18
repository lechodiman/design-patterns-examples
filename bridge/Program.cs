using System;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDevice(new Tv());
            TestDevice(new Radio());
        }

        static void TestDevice(Device device)
        {
            System.Console.WriteLine("Tests with basic remote");
            var basicRemote = new BasicRemote(device);
            basicRemote.Power();
            device.PrintStatus();

            System.Console.WriteLine("Tests with advanced remote");
            var advancedRemote = new AdvancedRemote(device);
            advancedRemote.Power();
            advancedRemote.Mute();
            device.PrintStatus();
        }
    }
}

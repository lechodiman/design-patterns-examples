using System;

namespace bridge
{
    public abstract class Device
    {
        protected bool On = false;
        protected int Volume = 30;

        public abstract void PrintStatus();

        public void Disable()
        {
            On = false;
        }

        public void Enable()
        {
            On = true;
        }

        public int GetVolume()
        {
            return Volume;
        }

        public void SetVolume(int percent)
        {
            Volume = percent;
        }

        public bool IsEnabled()
        {
            return On;
        }
    }

    public class Radio : Device
    {
        public Radio() : base()
        {
            On = false;
            Volume = 30;
        }

        public override void PrintStatus()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| I'm radio.");
            Console.WriteLine("| I'm " + (On ? "enabled" : "disabled"));
            Console.WriteLine("| Current volume is " + Volume + "%");
            Console.WriteLine("------------------------------------\n");
        }
    }

    public class Tv : Device
    {
        public Tv() : base()
        {
            On = false;
            Volume = 50;
        }

        public override void PrintStatus()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| I'm TV set.");
            Console.WriteLine("| I'm " + (On ? "enabled" : "disabled"));
            Console.WriteLine("| Current volume is " + Volume + "%");
            Console.WriteLine("------------------------------------\n");
        }
    }
}

using System;

namespace bridge
{
    public interface Device
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int percent);
        void PrintStatus();
    }

    public class Radio : Device
    {
        private bool On = false;
        private int Volume = 30;

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

        public bool IsEnabled()
        {
            return On;
        }

        public void PrintStatus()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| I'm radio.");
            Console.WriteLine("| I'm " + (On ? "enabled" : "disabled"));
            Console.WriteLine("| Current volume is " + Volume + "%");
            Console.WriteLine("------------------------------------\n");
        }

        public void SetVolume(int percent)
        {
            Volume = percent;
        }
    }

    public class Tv : Device
    {
        private bool On = false;
        private int Volume = 30;

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

        public bool IsEnabled()
        {
            return On;
        }

        public void PrintStatus()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| I'm TV set.");
            Console.WriteLine("| I'm " + (On ? "enabled" : "disabled"));
            Console.WriteLine("| Current volume is " + Volume + "%");
            Console.WriteLine("------------------------------------\n");
        }

        public void SetVolume(int percent)
        {
            if (Volume > 100)
            {
                Volume = 100;
            }
            else if (Volume < 0)
            {
                Volume = 0;
            }
            else
            {
                Volume = percent;
            }
        }
    }

}

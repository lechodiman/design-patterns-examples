using System;
using System.Collections.Generic;

namespace duck_reunion
{
    public class Flock : Quackable
    {
        private List<Quackable> Quackers = new List<Quackable>();

        public void Add(Quackable quacker)
        {
            Quackers.Add(quacker);
        }

        public void Quack()
        {
            foreach (var quacker in Quackers)
            {
                quacker.Quack();
            }
        }
    }
}

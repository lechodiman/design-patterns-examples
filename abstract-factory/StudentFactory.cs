using System;
using System.Collections.Generic;

namespace abstract_factory
{
    public class StudentFactory : IFactory
    {
        private Random _random = new Random();
        private static List<string> _names = new List<string> { "alvaro", "bruno", "carlos" };

        public IIndexedItem BuildItem()
        {
            var name = _names[_random.Next(_names.Count)];
            var id = _random.Next(maxValue: 1000);

            return new Student(name, id);
        }
    }
}

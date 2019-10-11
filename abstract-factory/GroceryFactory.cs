using System;
using System.Collections.Generic;

namespace abstract_factory
{
    public class GroceryFactory : IFactory
    {
        private Random _random = new Random();
        private static List<string> _groceries = new List<string> { "milk", "pan", "eggs" };

        public IIndexedItem BuildItem()
        {
            var name = _groceries[_random.Next(_groceries.Count)];
            var index = _random.Next(maxValue: 1000);

            return new Groceries(name, index);
        }
    }
}

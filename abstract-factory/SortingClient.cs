using System.Collections.Generic;

namespace abstract_factory
{
    public class SortingClient
    {
        private List<IIndexedItem> _items;

        public SortingClient(IFactory factory, int numberOfItems)
        {
            _items = new List<IIndexedItem>();
            for (int i = 0; i < numberOfItems; i++)
            {
                _items.Add(factory.BuildItem());
            }
        }

        public void Sort()
        {

        }
    }
}

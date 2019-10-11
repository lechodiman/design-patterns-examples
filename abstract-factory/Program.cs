using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortingClient = new SortingClient(new GroceryFactory(), numberOfItems : 10);
            sortingClient.Sort();

            // To do something like
            // Student student = studentFactory.BuildItem()
            // we can use generics and constrains
        }
    }
}

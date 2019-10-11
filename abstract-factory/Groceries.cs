namespace abstract_factory
{
    public class Groceries : IIndexedItem
    {
        public string Name { get; set; }
        public int Index { get; set; }

        public Groceries(string name, int index)
        {
            Name = name;
            Index = index;
        }
    }
}

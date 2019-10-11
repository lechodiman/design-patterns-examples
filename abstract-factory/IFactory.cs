namespace abstract_factory
{
    public interface IFactory
    {
        // It returns items that implement a given interface
        public IIndexedItem BuildItem();
    }
}

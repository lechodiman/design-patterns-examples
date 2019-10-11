namespace abstract_factory
{
    public class Student : IIndexedItem
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}

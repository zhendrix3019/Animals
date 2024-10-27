namespace Animals.Models
{
    public abstract class Person : Interfaces.ITalkable
    {
        public string Name { get; set; }

        protected Person(string name)
        {
            Name = name;
        }

        public abstract string Talk();
    }
}

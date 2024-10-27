namespace Animals.Models
{
    public abstract class Pet : Interfaces.ITalkable
    {
        public string Name { get; protected set; }

        protected Pet(string name)
        {
            Name = name;
        }

        public abstract string Talk();
    }
}

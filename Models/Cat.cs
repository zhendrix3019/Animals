namespace Animals.Models
{
    public class Cat : Pet
    {
        public int MiceKilled { get; private set; }

        public Cat(int miceKilled, string name) : base(name)
        {
            MiceKilled = miceKilled;
        }

        public void AddMouse()
        {
            MiceKilled++;
        }

        public override string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"Cat: Name={Name}, MiceKilled={MiceKilled}";
        }
    }
}

namespace Animals.Models
{
    public class Dog : Pet
    {
        public bool IsFriendly { get; private set; }

        public Dog(bool isFriendly, string name) : base(name)
        {
            IsFriendly = isFriendly;
        }

        public override string Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"Dog: Name={Name}, Friendly={IsFriendly}";
        }
    }
}

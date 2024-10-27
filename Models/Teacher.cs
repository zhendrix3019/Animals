namespace Animals.Models
{
    public class Teacher : Person
    {
        public int Age { get; set; }

        public Teacher(int age, string name) : base(name)
        {
            Age = age;
        }

        public override string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public override string ToString()
        {
            return $"Teacher: Name={Name}, Age={Age}";
        }
    }
}

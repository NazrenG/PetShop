

namespace Homework.NewFolder
{
    internal class Fish:Animal
    {
        public string Color { get; set; }

        public Fish(string nickName, string gender, int energy, int price, int age, string color)
        : base(nickName, gender, energy, price, age)
        {
            Color = color;
        }
    }
}

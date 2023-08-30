

namespace Homework.NewFolder
{
    internal class Bird : Animal
    {
        public bool Migration { get; set; }

        public Bird(string nickName, string gender, int energy, int price, int age, bool migration)
        : base(nickName, gender, energy, price, age)
        {
            Migration = migration;
        }
    }
}

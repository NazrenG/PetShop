

namespace Homework.NewFolder
{
    internal class Cat:Animal
    {
        public bool Flexibility { get; set; }//celdlik

        public Cat(string nickName, string gender, int energy, int price, int age, bool flexibility) 
            :base(nickName, gender, energy, price, age)
        {
            Flexibility = flexibility;
        }
    }
}

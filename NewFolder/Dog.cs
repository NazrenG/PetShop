
namespace Homework.NewFolder
{
    internal class Dog:Animal
    {
        private string breed;//cins

        public Dog(string nickName, string gender, int energy, int price, int age, string breed)
        : base(nickName, gender, energy, price, age)
        {
            this.breed = breed;
        }
       
        public string Breed
        {
            get { return breed; }
            set { if(value.Length>0)breed = value; }
        }

    }
}

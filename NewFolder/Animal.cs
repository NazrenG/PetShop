

namespace Homework.NewFolder
{
    internal abstract class Animal
    {
        public Guid Guid { get; set; }
        private string nickName;
        private string gender;
        private int energy;
        private int price;
        private int age;

        public Animal()
        {
            Guid = Guid.NewGuid();
            this.nickName = "---";
            this.gender = "---";
            this.energy = 0;
            this.price = 0;
            this.age = 0;
        }
        public Animal(string nickName, string gender, int energy, int price, int age)
        {
            Guid = Guid.NewGuid();
            this.nickName = nickName;
            this.gender = gender;
            this.energy = energy;
            this.price = price;
            this.age = age;
        }

        public string NickName
        {
            get { return nickName; }
            set { if (value.Length >= 0) nickName = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { if (value == "male" || value == "female") gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { if (value >= 0) age = value; }
        }
        public int Energy
        {
            get { return energy; }
            set { if (value >= 0 && value <= 50) energy = value; }
        }
        public int Price
        {
            get { return price; }
            set { if (value >= 0) price = value; }
        }


        public void Eat()
        {
            
            energy += 5;
            if (energy >= 50)
            {
                price += 10;
                age += 1;
                energy = 0;
                Console.WriteLine(" \nYour pet's price and age have increased ");
                Thread.Sleep(1500);
                return;
            }
            Console.WriteLine("\nYour pet's energy has increased ");
            Thread.Sleep(1500);
        }
        public void Sleep()
        {
            
            energy += 10;
            if (energy >= 50)
            {
                price += 10;
                age += 1;
                energy = 0;
                Console.WriteLine(" \nYour pet's price and age have increased ");
                Thread.Sleep(1500);
                return;
            }
            Console.WriteLine("\nYour pet's energy has increased ");
            Thread.Sleep(1500);
        }
        public void Play()
        {
          
            energy -= 10;
            if (energy <= 0)
            {
               
                Console.WriteLine("\nYou must feed your pet ");
                energy = 0;
                Thread.Sleep(1500);
                return;

            }
            Console.WriteLine("\nYour pet's energy has decreased ");
            Thread.Sleep(1500);
        }

        public void showData()
        {
            Console.WriteLine(Guid);
            Console.WriteLine($"Nickname: {nickName}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Price: {price}$");
            Console.WriteLine($"Energy: {energy}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public void ShowShort()
        {
            Console.WriteLine("\n\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"\t\t\t\t\tNickname: {nickName}");
            Console.WriteLine($"\t\t\t\t\tGender: {gender}");
            Console.WriteLine($"\t\t\t\t\tAge: {age}");
            Console.WriteLine($"\t\t\t\t\tPrice: {price}$");
            Console.WriteLine($"\t\t\t\t\tEnergy: {energy}");
            Console.WriteLine("\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~");
        }

    }
}

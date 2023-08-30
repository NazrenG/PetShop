using Homework.NewFolder;
using Homework;

void Menu(byte choose)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\n\n\n\n\t\t\t\t\t~~~~Select animal~~~~\n");
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (choose == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t\t\t=>1.Cat");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t\t2.Dog");
        Console.WriteLine("\t\t\t\t\t\t3.Fish");
        Console.WriteLine("\t\t\t\t\t\t4.Bird");
    }
    else if (choose == 2)
    {
        Console.WriteLine("\t\t\t\t\t\t1.Cat");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t\t\t=>2.Dog");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t\t3.Fish");
        Console.WriteLine("\t\t\t\t\t\t4.Bird");
    }
    else if (choose == 3)
    {
        Console.WriteLine("\t\t\t\t\t\t1.Cat");
        Console.WriteLine("\t\t\t\t\t\t2.Dog");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t\t\t=>3.Fish");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t\t4.Bird");
    }
    else if (choose == 4)
    {
        Console.WriteLine("\t\t\t\t\t\t1.Cat");
        Console.WriteLine("\t\t\t\t\t\t2.Dog");
        Console.WriteLine("\t\t\t\t\t\t3.Fish");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t\t\t=>4.Bird");
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}
void Menu_2_1(byte choose, byte choose_2, string pet)
{
    Menu_2(choose, ref pet);
    if (choose_2 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t\t\t\t\t=>1.Play {pet}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\t\t\t\t\t2.Show all {pet} ");
        Console.WriteLine($"\t\t\t\t\t3.Buy {pet} ");
        Console.WriteLine("\t\t\t\t\t4.Back");

    }
    else if (choose_2 == 2)
    {
        Console.WriteLine($"\t\t\t\t\t1.Play {pet}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t\t\t\t\t=>2.Show all {pet}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\t\t\t\t\t3.Buy {pet} ");
        Console.WriteLine("\t\t\t\t\t4.Back");
    }
    else if (choose_2 == 3)
    {
        Console.WriteLine($"\t\t\t\t\t1.Play {pet}");
        Console.WriteLine($"\t\t\t\t\t2.Show all {pet}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t\t\t\t\t=>3.Buy {pet} ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t4.Back");
    }
    else if (choose_2 == 4)
    {
        Console.WriteLine($"\t\t\t\t\t1.Play {pet}");
        Console.WriteLine($"\t\t\t\t\t2.Show all {pet}");
        Console.WriteLine($"\t\t\t\t\t3.Buy {pet} ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t\t=>4.Back");
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

}
void Menu_2(byte choose, ref string pet)
{
    Console.Clear();
    Console.Write("\n\n\n\n\n\t\t\t\t\tYour pet: ");
    Console.ForegroundColor = ConsoleColor.Green;
    if (choose == 1)
    {
        pet = "cat";
    }
    else if (choose == 2)
    {
        pet = "dog";
    }
    else if (choose == 3)
    {
        pet = "fish";
    }
    else if (choose == 4)
    {
        pet = "bird";
    }
    Console.WriteLine(pet);
    Console.WriteLine("\n");
    Console.ForegroundColor = ConsoleColor.Yellow;

}
void Menu_3(byte choose_3, byte choose, string id, ref Cat[] cats, ref Dog[] dogs, ref Fish[] fish, ref Bird[] birds)
{
    Console.Clear();
    Play(choose, id, ref cats, ref dogs, ref fish, ref birds);
    if (choose_3 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\n\t\t\t\t Feed your pet");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\t Sleep");
        Console.Write("\t Play");
        Console.Write("\t Exit");
    }
    else if (choose_3 == 2)
    {
        Console.Write("\n\t\t\t\t Feed your pet");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\t Sleep");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\t Play");
        Console.Write("\t Exit");
    }
    else if (choose_3 == 3)
    {
        Console.Write("\n\t\t\t\t Feed your pet");
        Console.Write("\t Sleep");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\t Play");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\t Exit");
    }
    else if (choose_3 == 4)
    {
        Console.Write("\n\t\t\t\t Feed your pet");
        Console.Write("\t Sleep");
        Console.Write("\t Play");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\t Exit");
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}
void ShowList(byte choose, Cat[] cats, Dog[] dogs, Fish[] fish, Bird[] birds)
{
    Console.Clear();
    Console.WriteLine("All pet\n");
    if (choose == 1)//cat
    {
        for (int i = 0; i < cats.Length; i++)
        {
            cats[i].showData();
        }
    }
    else if (choose == 2)//dog
    {
        for (int i = 0; i < dogs.Length; i++)
        {
            dogs[i].showData();
        }
    }
    else if (choose == 3)//fish
    {
        for (int i = 0; i < fish.Length; i++)
        {
            fish[i].showData();
        }
    }
    else if (choose == 4)//bird
    {
        for (int i = 0; i < birds.Length; i++)
        {
            birds[i].showData();
        }
    }
}
void Buy(byte choose, ref Cat[] cats, ref Dog[] dogs, ref Fish[] fish, ref Bird[] birds)
{
    Console.Clear();
    Console.Write("\n\n\n\n\n\t\t\t\t\tWrite pet id:");
    string? id = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(id);

    int indexToRemove = 0; ;

    if (choose == 1)//cat
    {
        Cat[] newArray = new Cat[cats.Length - 1];
        for (int i = 0; i < cats.Length; i++)
        {
            if (ToString(cats[i].Guid) == id) indexToRemove = i;
        }
        if (indexToRemove != 0)
        {
            for (int i = 0; i < indexToRemove; i++)
            {
                newArray[i] = cats[i];
            }
            for (int i = indexToRemove + 1; i < cats.Length; i++)
            {
                newArray[i - 1] = cats[i];
            }
            Array.Resize(ref cats, cats.Length - 1);
            for (int i = 0; i < cats.Length; i++)
            {
                cats[i] = newArray[i];
            }
        }
        Console.WriteLine("\n\n\n\n\n\t\t\t\t\tThe cat was adopted");
    }
    else if (choose == 2)//dog
    {
        Dog[] newArray = new Dog[dogs.Length - 1];
        for (int i = 0; i < dogs.Length; i++)
        {
            if (ToString(dogs[i].Guid) == id) indexToRemove = i;
        }
        if (indexToRemove != 0)
        {
            for (int i = 0; i < indexToRemove; i++)
            {
                newArray[i] = dogs[i];
            }
            for (int i = indexToRemove + 1; i < dogs.Length; i++)
            {
                newArray[i - 1] = dogs[i];
            }
            Array.Resize(ref dogs, dogs.Length - 1);
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i] = newArray[i];
            }
        }
        Console.WriteLine("\n\n\n\n\n\t\t\t\t\tThe dog was adopted");
    }
    else if (choose == 3)//fish
    {
        Fish[] newArray = new Fish[fish.Length - 1];
        for (int i = 0; i < fish.Length; i++)
        {
            if (ToString(fish[i].Guid) == id) indexToRemove = i;
        }
        if (indexToRemove != 0)
        {
            for (int i = 0; i < indexToRemove; i++)
            {
                newArray[i] = fish[i];
            }
            for (int i = indexToRemove + 1; i < dogs.Length; i++)
            {
                newArray[i - 1] = fish[i];
            }
            Array.Resize(ref fish, fish.Length - 1);
            for (int i = 0; i < fish.Length; i++)
            {
                fish[i] = newArray[i];
            }
        }
        Console.WriteLine("\n\n\n\n\n\t\t\t\t\tThe fish was adopted");
    }
    else if (choose == 4)//bird
    {
        Bird[] newArray = new Bird[birds.Length - 1];
        for (int i = 0; i < birds.Length; i++)
        {
            if (ToString(birds[i].Guid) == id) indexToRemove = i;
        }
        if (indexToRemove != 0)
        {
            for (int i = 0; i < indexToRemove; i++)
            {
                newArray[i] = birds[i];
            }
            for (int i = indexToRemove + 1; i < birds.Length; i++)
            {
                newArray[i - 1] = birds[i];
            }
            Array.Resize(ref birds, birds.Length - 1);
            for (int i = 0; i < birds.Length; i++)
            {
                birds[i] = newArray[i];
            }
        }
        Console.WriteLine("\n\n\n\n\n\t\t\t\t\tThe bird was adopted");
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
}
void Play(byte choose, string id, ref Cat[] cats, ref Dog[] dogs, ref Fish[] fish, ref Bird[] birds)
{

    bool check = false;
    if (choose == 1)//cat
    {
        for (int i = 0; i < cats.Length; i++)
        {
            if (ToString(cats[i].Guid) == id)
            {
                cats[i].ShowShort();
                check = true;
                break;
            }
        }
    }
    else if (choose == 2)//dog
    {
        for (int i = 0; i < dogs.Length; i++)
        {
            if (ToString(dogs[i].Guid) == id)
            {
                dogs[i].ShowShort();
                check = true;
                break;
            }
        }
    }
    else if (choose == 3)//fish
    {
        for (int i = 0; i < fish.Length; i++)
        {
            if (ToString(fish[i].Guid) == id)
            {
                fish[i].ShowShort();
                check = true;
                break;
            }
        }

    }
    else if (choose == 4)//bird
    {
        for (int i = 0; i < birds.Length; i++)
        {
            if (ToString(birds[i].Guid) == id)
            {
                birds[i].ShowShort();
                check = true;
                break;
            }
        }

    }
    if (!check) Console.WriteLine("\n\t\t\t\t\tID was not found!!!");
}
void EatSleepPlay(byte choose, byte choose_3, string id, ref Cat[] cats, ref Dog[] dogs, ref Fish[] fish, ref Bird[] birds)
{
    
    if (choose == 1)
    {
        for (int i = 0; i < cats.Length; i++)
        {
            if (ToString(cats[i].Guid) == id)
            {
                if (choose_3 == 1) cats[i].Eat();
                else if (choose_3 == 2) cats[i].Sleep();
                else if (choose_3 == 3) cats[i].Play();
            }
        }
    }
    else if (choose == 2)//dog
    {
        for (int i = 0; i < dogs.Length; i++)
        {
            if (ToString(dogs[i].Guid) == id)
            {
                if (choose_3 == 1) dogs[i].Eat();
                else if (choose_3 == 2) dogs[i].Sleep();
                else if (choose_3 == 3) dogs[i].Play();
            }
        }
    }
    else if (choose == 3)//fish
    {
        for (int i = 0; i < fish.Length; i++)
        {
            if (ToString(fish[i].Guid) == id)
            {

                if (choose_3 == 1) fish[i].Eat();
                else if (choose_3 == 2) fish[i].Sleep();
                else if (choose_3 == 3) fish[i].Play();
            }
        }

    }
    else if (choose == 4)//bird
    {
        for (int i = 0; i < birds.Length; i++)
        {
            if (ToString(birds[i].Guid) == id)
            {
                if (choose_3 == 1) birds[i].Eat();
                else if (choose_3 == 2) birds[i].Sleep();
                else if (choose_3 == 3) birds[i].Play();
            }
        }
    }
    
}
string? ToString(Guid guid)
{
    return guid.ToString();
}

//////////////////////
///
Cat[] CatArr = new Cat[]
{
    new Cat("Tom","male",25,30,2,true),
    new Cat("Penny","female",30,25,1,false),
    new Cat("Lucy","female",15,40,1,true)
};
Dog[] DogArr = new Dog[]
{
    new Dog("Luna","female",40,50,3,"breed1"),
    new Dog("Oliver","male",33,55,2,"breed2"),
    new Dog("Jack","male",45,53,2,"breed3")
};
Fish[] FishArr = new Fish[]
{
    new Fish("Ace","male",15,20,1,"red"),
    new Fish("Blue","male",35,25,1,"blue"),
    new Fish("Bubble","female",48,23,2,"green")
};
Bird[] BirdArr = new Bird[]
{
    new Bird("Charlie","male",36,15,1,true),
    new Bird("Bob","male",26,30,3,false),
    new Bird("Arthur","male",19,35,2,false)
};

/// /////////////////

dynamic select, select_2, select_3;
byte choose = 1, choose_2 = 1, choose_3 = 1;
Menu(choose);
while (true)
{
    select = Console.ReadKey();
    if (select.Key == ConsoleKey.UpArrow)
    {
        if (choose == 1) choose = 4;
        else choose--;
        Menu(choose);
    }
    else if (select.Key == ConsoleKey.DownArrow)
    {
        if (choose == 4) choose = 1;
        else choose++;
        Menu(choose);
    }
    else if (select.Key == ConsoleKey.Enter)
    {
        string? pet = null;
        Menu_2_1(choose, choose_2, pet);
        bool check_2 = true;
        while (true)
        {
            select_2 = Console.ReadKey();
            if (select_2.Key == ConsoleKey.UpArrow)
            {
                if (choose_2 == 1) choose_2 = 4;
                else choose_2--;
                Menu_2_1(choose, choose_2, pet);
            }
            else if (select_2.Key == ConsoleKey.DownArrow)
            {
                if (choose_2 == 4) choose_2 = 1;
                else choose_2++;
                Menu_2_1(choose, choose_2, pet);
            }
            else if (select_2.Key == ConsoleKey.Enter)
            {
                if (choose_2 == 4)//back
                {
                    check_2 = false;
                    Menu(choose);
                    break;
                }
                if (choose_2 == 1)//play pet
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\t\t\t\t\tWrite pet id:");
                    string? id = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(id);
                    bool check=true;
                    Menu_3(choose_3, choose, id, ref CatArr, ref DogArr, ref FishArr, ref BirdArr);
                    while (true)
                    {
                        select_3 = Console.ReadKey();
                        if (select_3.Key == ConsoleKey.RightArrow)
                        {
                            if (choose_3 == 4) choose_3 = 1;
                            else choose_3++;
                            Menu_3(choose_3, choose, id, ref CatArr, ref DogArr, ref FishArr, ref BirdArr);
                        }
                        else if (select_3.Key == ConsoleKey.LeftArrow)
                        {
                            if (choose_3 == 1) choose_3 = 4;
                            else choose_3--;
                            Menu_3(choose_3, choose, id, ref CatArr, ref DogArr, ref FishArr, ref BirdArr);

                        }
                        else if (select_3.Key == ConsoleKey.Enter)
                        {
                            EatSleepPlay(choose,choose_3, id, ref CatArr, ref DogArr, ref FishArr, ref BirdArr);
                            if (choose_3 == 4)//exit
                            {
                                Menu_2_1(choose, choose_2, pet);
                                check = false;
                                break;
                            }
                            Menu_3(choose_3, choose, id, ref CatArr, ref DogArr, ref FishArr, ref BirdArr);

                        }

                    }

                }
                else if (choose_2 == 2)//show list
                {
                    ShowList(choose, CatArr, DogArr, FishArr, BirdArr);
                }
                else if (choose_2 == 3)//buy 
                {
                    Buy(choose, ref CatArr, ref DogArr, ref FishArr, ref BirdArr);
                }
                Console.WriteLine("\nPress ENTER...");
                dynamic backButton = Console.ReadKey();
                if (backButton.Key == ConsoleKey.Enter) 
                    Menu_2_1(choose, choose_2, pet);

            }
        }
    }
}


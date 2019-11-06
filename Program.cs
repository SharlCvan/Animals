using System;
using System.Collections.Generic;
using System.Linq;

namespace Animal
{

    class Program
    {
        public static string[] names =
        {
            "Anders",
            "Maja",
            "Fido",
            "Herman",
            "Bengt",
            "Mats",
            "Sofia",
            "Greger",
            "Johan"
        };

        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            Zoo animalList = new Zoo();

            for (int i = 0; i < 5; i++) //Frog
            {
                int name = rnd.Next(0, names.Length);
                int age = rnd.Next(1, 40);
                int gender = rnd.Next(0, 2);
                int color = rnd.Next(0, 5);
                bool poison = gender == 1 ? true : false;

                Frog frog = new Frog((Frog.FrogColor)color, poison, names[name], (Animal.Gender)gender, age);

                animalList.AddFrogs(frog);
            }

            for (int i = 0; i < 5; i++) //Dog
            {
                int name = rnd.Next(0, names.Length);
                int age = rnd.Next(1, 20);
                int gender = rnd.Next(0, 2);
                int color = rnd.Next(0, 5);
                int race = rnd.Next(0, 6);

                Dog dog = new Dog((Dog.DogRace)race, (Dog.FurColor)color, names[name], (Animal.Gender)gender, age);

                animalList.AddDogs(dog);
            }

            for (int i = 0; i < 5; i++) //Kitten
            {
                int name = rnd.Next(0, names.Length);
                int age = rnd.Next(1, 20);
                int lives = rnd.Next(0, 9);

                Kitten kitten = new Kitten(lives, names[name], age);

                animalList.AddKittens(kitten);
            }

            for (int i = 0; i < 5; i++) //Bobcats
            {
                int name = rnd.Next(0, names.Length);
                int age = rnd.Next(1, 15);
                int lives = rnd.Next(0, 9);

                Bobcat bobcat = new Bobcat(lives, names[name], age);

                animalList.AddBobcats(bobcat);
            }

            PrintAnimals(animalList);

        }

        public static void PrintAnimals(Zoo animalList)
        {
            Console.WriteLine("FROGS");
            int age = 0;
            int numOfFrogs = 0;
            foreach (Frog frog in animalList.Frogs)
            {
                Console.WriteLine(frog);
                Console.WriteLine("The frog says {0}", frog.Sound());
                Console.WriteLine("______________");
                numOfFrogs++;
                age += frog.Age;
            }

            int AvarageAge = age / numOfFrogs;
            Console.WriteLine("Avarage age of all frogs is: {0}", AvarageAge);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("DOGS");
            age = 0;
            numOfFrogs = 0;
            foreach (Dog dog in animalList.Dogs)
            {
                Console.WriteLine(dog);
                Console.WriteLine("The dog says {0}", dog.Sound());
                Console.WriteLine("______________");
                numOfFrogs++;
                age += dog.Age;
            }

            AvarageAge = age / numOfFrogs;
            Console.WriteLine("Avarage age of all dogs is: {0}", AvarageAge);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("KITTENS");
            age = 0;
            numOfFrogs = 0;
            foreach (Kitten kitten in animalList.Kittens)
            {
                Console.WriteLine(kitten);
                Console.WriteLine("The kitten says {0}", kitten.Sound());
                Console.WriteLine("______________");
                numOfFrogs++;
                age += kitten.Age;
            }

            AvarageAge = age / numOfFrogs;
            Console.WriteLine("Avarage age of all kittens is: {0}", AvarageAge);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("BOBCATS");
            age = 0;
            numOfFrogs = 0;
            foreach (Bobcat bobcat in animalList.Bobcats)
            {
                Console.WriteLine(bobcat);
                Console.WriteLine("Te bobcat says {0}", bobcat.Sound());
                Console.WriteLine("______________");
                numOfFrogs++;
                age += bobcat.Age;
            }

            AvarageAge = age / numOfFrogs;
            Console.WriteLine("Avarage age of all bobcats is: {0}", AvarageAge);

        }
    }

    class Zoo
    {
        private List<Frog> frogs;
        private List<Dog> dogs;
        private List<Kitten> kittens;
        private List<Bobcat> bobcats;

        public List<Frog> Frogs
        {
            get
            {
                return frogs;
            }
            set
            {
                frogs = value;
            }
        }
        public List<Dog> Dogs
        {
            get
            {
                return dogs;
            }
            set
            {
                dogs = value;
            }
        }
        public List<Kitten> Kittens
        {
            get
            {
                return kittens;
            }
            set
            {
                kittens = value;
            }
        }
        public List<Bobcat> Bobcats
        {
            get
            {
                return bobcats;
            }
            set
            {
                bobcats = value;
            }
        }

        public void AddFrogs(Frog f)
        {
            frogs.Add(f);
        }
        public void AddDogs(Dog d)
        {
            dogs.Add(d);
        }
        public void AddKittens(Kitten k)
        {
            kittens.Add(k);
        }
        public void AddBobcats(Bobcat b)
        {
            bobcats.Add(b);
        }

        public Zoo()
        {
            frogs = new List<Frog>();
            dogs = new List<Dog>();
            kittens = new List<Kitten>();
            bobcats = new List<Bobcat>();
        }
    }

    class Animal
    {
        private int age;
        private string name;

        public enum Gender
        {
            Male, Female
        }

        private Gender sex;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Gender Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        public Animal(string name, Gender sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }


    }

    class Frog : Animal, ISound
    {
        public enum FrogColor
        {
            Green, Red, Black, White, Orange, Pink
        }

        private FrogColor color;
        private bool poisonus;

        public FrogColor Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public bool Poisonus
        {
            get
            {
                return poisonus;
            }
            set
            {
                poisonus = value;
            }
        }

        public Frog(FrogColor color, bool poisonus, string name, Gender sex, int age) : base(name, sex, age)
        {
            Color = color;
            Poisonus = poisonus;
        }

        public override string ToString()
        {
            string result = "";

            if (poisonus)
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }

            return "Frog name: " + Name + "\nFrog Age: " + Age + "\nFrog Gender: " + Sex + "\nFrog poisonus: " + result + "\nFrog Color: " + Color;
        }

        public string Sound()
        {
            return "Ribbit, Ribbit";
        }
    }

    class Dog : Animal, ISound
    {
        public enum DogRace
        {
            Dalmatin, Pitbull, Pug, GreatDane, Pudel, GoldenRetreaver, Labrador
        }

        private DogRace race;

        public enum FurColor
        {
            Black, Brown, Blonde, White, Spotted, other
        }

        private FurColor furColor;

        public DogRace Race
        {
            get
            {
                return race;
            }
            set
            {
                race = value;
            }
        }

        public FurColor Color
        {
            get
            {
                return furColor;
            }
            set
            {
                furColor = value;
            }
        }

        public Dog(DogRace race, FurColor color, string name, Gender sex, int age) : base(name, sex, age)
        {
            Race = race;
            Color = color;
        }

        public override string ToString()
        {
            return "\nDog name: " + Name + "\nDog Age: " + Age + "\nDog Race: " + Race + "\nDog Gender: " + Sex + "\nDog Color: " + Color;
        }

        public string Sound()
        {
            return "Ruff!!";
        }
    }

    class Cat : Animal
    {
        private int lives;

        public int Lives
        {
            get
            {
                return lives;
            }
            set
            {
                lives = value;
            }
        }

        public Cat(int lives, string name, Gender sex, int age) : base(name, sex, age)
        {
            Lives = lives;
        }

    }

    class Kitten : Cat, ISound
    {

        public Kitten(int lives, string name, int age, Gender sex = Gender.Female) : base(lives, name, sex, age)
        {

        }

        public override string ToString()
        {
            return "\nKitten name: " + Name + "\nKitten age: " + Age + "\nKitten gender: " + Sex + "\nKitten number of lives: " + Lives;
        }

        public string Sound()
        {
            return "Mjaooouuu";
        }
    }

    class Bobcat : Cat, ISound
    {
        public Bobcat(int lives, string name, int age, Gender sex = Gender.Male) : base(lives, name, sex, age)
        {

        }

        public string Sound()
        {
            return "Raaaawwwrrrr!!!";
        }

        public override string ToString()
        {
            return "\nBobcat name: " + Name + "\nBobcat age: " + Age + "\nBobcat gender: " + Sex + "\nBobcat number of lives: " + Lives;
        }
    }

    interface ISound
    {
        public string Sound();
    }
}
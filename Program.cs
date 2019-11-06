using System;
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
            #region Print Frogs
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_____________________________FROGS___________________________");
            Console.WriteLine("|  Name  | Gender | Age | Color  | Poisonus |      Sound     |");
            Console.WriteLine("|________|________|_____|________|__________|________________|");
            int age = 0;
            int numOfFrogs = 0;
            foreach (Frog frog in animalList.Frogs)
            {
                Console.WriteLine("| {0,-6} | {1,-6} | {2,-3} | {3,-6} | {4,-8} | {5,-12} |",frog.Name,frog.Sex,frog.Age,frog.Color,frog.Poisonus, frog.Sound());                
                Console.WriteLine("|________|________|_____|________|__________|________________|");
                numOfFrogs++;
                age += frog.Age;
            }

            int AvarageAge = age / numOfFrogs;
            Console.WriteLine("Avarage age of all frogs is: {0}", AvarageAge);

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Print Dogs
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_________________DOGS________________");
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

            #endregion

            #region Print kittens
            Console.ForegroundColor = ConsoleColor.Blue;
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

            #endregion

            #region Print bobcats

            Console.ForegroundColor = ConsoleColor.Red;
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
            #endregion
        }
    }
}
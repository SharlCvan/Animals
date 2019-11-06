namespace Animal
{
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
}
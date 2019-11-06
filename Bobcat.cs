namespace Animal
{
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
}
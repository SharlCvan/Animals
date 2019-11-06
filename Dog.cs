namespace Animal
{
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
}
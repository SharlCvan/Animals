namespace Animal
{
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
}
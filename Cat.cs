namespace Animal
{
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
}
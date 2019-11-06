namespace Animal
{
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
}
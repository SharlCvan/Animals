using System.Collections.Generic;

namespace Animal
{
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
}
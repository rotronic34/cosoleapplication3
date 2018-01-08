using System;

namespace ConsoleApplication3
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public Animal(){            //constructor for Animal Class
            this.height = 0;
            this.weight = 0;
            this.name = "No name";
            this.sound = "No sound";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string sound, string name){
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;  //static field attribute; check number of animal objects created

        public static int getNumOfAnimals(){
            return numOfAnimals;      //return numOfAnimals whenever it is called
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

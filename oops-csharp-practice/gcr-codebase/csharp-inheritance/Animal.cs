
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class Animal
    {
        protected string name;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("ANIMAL MAKES A SOUND");
        }
    }
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("DOG BARKS");
        }
    }
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("CAT MEOWS");
        }
    }
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("BIRD CHIRPS");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            TakeInputs();
        }
        public static void TakeInputs()
        {
            Console.WriteLine("ENTER DOG NAME: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("ENTER DOG AGE: ");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            Animal dog = new Dog(dogName, dogAge);
            dog.MakeSound();
            Console.WriteLine("\nENTER CAT NAME: ");
            string catName = Console.ReadLine();
            Console.WriteLine("ENTER CAT AGE: ");
            int catAge = Convert.ToInt32(Console.ReadLine());
            Animal cat = new Cat(catName, catAge);
            cat.MakeSound();
            Console.WriteLine("\nENTER BIRD NAME: ");
            string birdName = Console.ReadLine();
            Console.WriteLine("ENTER BIRD AGE: ");
            int birdAge = Convert.ToInt32(Console.ReadLine());
            Animal bird = new Bird(birdName, birdAge);
            bird.MakeSound();
        }
    }
}

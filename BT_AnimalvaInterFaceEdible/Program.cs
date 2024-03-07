using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_AnimalvaInterFaceEdible
{
    namespace BT_AnimalvaInterFaceEdible
    {
        class AbstractAndInterfaceTests
        {
            public abstract class Animal
            {
                public abstract string MakeSound();
                public virtual string HowToEat()
                {
                    return "This animal is not edible.";
                }
            }

            public class Tiger : Animal
            {
                public override string MakeSound()
                {
                    return "Tiger: roarrrrr!";
                }
            }

            public class Chicken : Animal
            {
                public override string MakeSound()
                {
                    return "Chicken: cluck-cluck!";
                }

                public override string HowToEat()
                {
                    return "Fried, boiled, or grilled.";
                }
            }

            public abstract class Fruit : Animal
            {
                public override string MakeSound()
                {
                    return "This is a fruit.";
                }
            }

            public class Apple : Fruit
            {
                public override string HowToEat()
                {
                    return "Apple could be sliced.";
                }
            }

            public class Orange : Fruit
            {
                public override string HowToEat()
                {
                    return "Orange could be juiced.";
                }
            }

            static void Main(string[] args)
            {
                Animal[] animals = new Animal[2];
                animals[0] = new Tiger();
                animals[1] = new Chicken();

                foreach (Animal animal in animals)
                {
                    Console.WriteLine(animal.MakeSound());
                    Console.WriteLine(animal.HowToEat());
                }

                Fruit[] fruits = new Fruit[2];
                fruits[0] = new Orange();
                fruits[1] = new Apple();

                foreach (Fruit fruit in fruits)
                {
                    Console.WriteLine(fruit.MakeSound());
                    Console.WriteLine(fruit.HowToEat());
                }

                Console.ReadKey();
            }
        }
    }
}

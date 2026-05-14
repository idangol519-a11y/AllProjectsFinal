namespace AnimalManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[]{
               new Cat(11,"Angela"), new Dog(99,"Ben")
            };
            Show(zoo);

        }
        public static void Show(Animal[] zoo)
        {
            foreach (Animal a in zoo)
            {
                if (a is Cat)
                {
                    Cat c = a as Cat;
                    Console.WriteLine(c.ToString());
                    c.Purr();
                }
                else
                {
                    Dog d = a as Dog;
                    Console.WriteLine(d.ToString());
                    d.Bark();

                }
            }

        }


        public abstract class Animal
        {
            public int age;
            public String name;
            public Animal(int age, String name)
            {
                this.age = age;
                this.name = name;
            }

            public override string ToString()
            {
                return $"My age is: {age} , My name is: {name}";
            }
        }
        sealed class Cat : Animal
        {
            public Cat(int age, String name) : base(age, name)
            {

            }
            public void Purr()
            {
                Console.WriteLine("Purr");
            }
        }

        public class Dog : Animal
        {
            public Dog(int age, String nam) : base(age, nam)
            {

            }

            public void Bark()
            {
                Console.WriteLine("Bark");
            }

        }
    }
}


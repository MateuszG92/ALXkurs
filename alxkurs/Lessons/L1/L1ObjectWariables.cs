using alxkurs.Lessons.L1.classes;

namespace alxkurs.Lessons.L1
{
    public class L1ObjectWariables
    {
        public static void Test1()
        {
            Console.WriteLine("test");
            Dog dog = new Dog();
            dog.Jump();
            dog.Bark();
            dog.Name = "Burek";
            dog.Age = 5;
            dog.Race = "golden retriver";
            Console.WriteLine("Attention here is " + dog.Name);
            Console.WriteLine("Race " + dog.Race);
            Console.WriteLine("Age " + dog.Age);

        }
        public static void Test2()
        {
            Dog dog2 = new Dog();
            dog2.Name = "skiper";
            dog2.Age = 5;
            dog2.Race = "chihuahua";
            dog2.Present();
            Console.WriteLine("Female " + dog2.Breed().NumberOfFemalePuppies);
            Console.WriteLine("Male " + dog2.Breed().NumberOfMalePuppies);
            Console.WriteLine("Number of puppies " + dog2.NumberOfPuppies());
            dog2.Jump();
            dog2.Bark();
            Console.WriteLine(dog2.Add(2, 3));
        }
    }
}

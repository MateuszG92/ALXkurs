using System;
namespace alxkurs.Assigments.classes
{

public class Cat
{
	
        public string Name;
        public string Color;
        public int Age;

        public Cat(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age; 
        }
        public Cat(string color, int age)
        {
            Color = color;
            Age=age;
        }

        public void Jump()
        {
            Console.WriteLine("jump");
        }

        public void Meow()
        {
            Console.WriteLine("miauu");
        }

        public void Present()
        {
            Console.WriteLine("This is a cat");
            Console.WriteLine("It's name is " + Name);
            Console.WriteLine("It's color is " + Color);
            Console.WriteLine("It's age is " + Age);
        }
    }
}


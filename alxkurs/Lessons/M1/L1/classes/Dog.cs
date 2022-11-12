using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M1.L1.classes
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Race;
        public int Puppies;
     
        public void Jump()
        {
            Console.WriteLine("jump");
        }

        public void Bark()
        {
            Console.WriteLine("woof woof");
        } 

        public int GetOlderAge()
        {
            return Age+1;
        }
        public void GrowOlder(int numberofyears)
        {
            Age = Age + numberofyears;
        }
        public int Add(int x,int y)
        {
            return x + y;
        }
        public OffspringStats Breed()
        {
            OffspringStats offSpringStat1 = new OffspringStats();
            offSpringStat1.NumberOfMalePuppies = 2;
            offSpringStat1.NumberOfFemalePuppies = 4;
            return offSpringStat1;
        }
        public int NumberOfPuppies()
        {
            Puppies = Breed().NumberOfMalePuppies + Breed().NumberOfFemalePuppies;
            return Puppies;
        }
        public void Present()
        {
            Console.WriteLine("Attention here is " + Name);
            Console.WriteLine("Race " + Race);
            Console.WriteLine("Age " + Age);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.classes
{
    public class Spider
    {
        public string Color;
        public string Species;
        public bool IsVenomous; 
        public string Sex;

        public Spider()
        {
        }

        public Spider(string color, string species, bool isVenomous, string sex)
        {
            Console.WriteLine("It's sex is " + Sex);
            Color = color;
            Species = species;
            IsVenomous = isVenomous;
            Sex = sex;
        }
        public Spider(string color, bool isVenomous)
        {
            Color = color;
            IsVenomous = isVenomous;
        }

        public void Present()
        {
            Console.WriteLine("This is a spider");
            Console.WriteLine("It's color is " + Color);
            Console.WriteLine("It's Spice is " + Species);
            Console.WriteLine("It's sex is " + Sex);
            Console.WriteLine("Is it venomous " + IsVenomous);
        }

    }
}

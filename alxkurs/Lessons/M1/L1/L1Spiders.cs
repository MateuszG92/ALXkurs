using alxkurs.Lessons.M1.L1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//constructors
namespace alxkurs.Lessons.M1.L1.classes
{
    public class L1Spiders
    {
        public static void Run()
        {
            var spider = new Spider();
            spider.Color = "black";
            spider.Species = "black widow";
            spider.IsVenomous = true;
            spider.Sex = "female";
            var redSpider = new Spider("Red", "Tarantula", true, "Male");
            var blackSpider = new Spider("black", true);
        }

    }
}

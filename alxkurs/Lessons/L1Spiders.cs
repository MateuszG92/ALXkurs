using alxkurs.Lessons.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons
{
    public class L1Spiders
    {
        public static void Test()
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

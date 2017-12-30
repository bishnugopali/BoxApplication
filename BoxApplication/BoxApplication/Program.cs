using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxApplication
{
    class Box
    {

        public double Length;
        public double Width;
        public double Height;
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();

            double volume = 0.0;

            //Box1 Specification
            box1.Length = 5.0;
            box1.Width = 6.0;
            box1.Height = 7.0;

            //Box2 Specification
            box2.Length = 10.0;
            box2.Width = 12.0;
            box2.Height = 13.0;

            //volume of box1
            volume = box1.Height * box1.Width * box1.Length;
            Console.WriteLine("Box 1 Volume is " + volume + ".");

            //volume of box2
            volume = box2.Height * box2.Width * box2.Length;
            Console.WriteLine("Box 2 Volume is " + volume + ".");

            Console.ReadKey();



        }

    }
    
}

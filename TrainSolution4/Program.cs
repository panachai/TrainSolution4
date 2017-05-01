using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSolution4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Box
    {
        private double width, height, length, side;
        private Box oldBox;
        // Constructors 
        Box(double width, double height, double length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }
        Box(double side)
        {
            this.side = side;
        }
        Box(Box oldBox)
        {
            this.oldBox = oldBox;
        }

        // Methods 
        double area()
        {
            return 2 * faceArea() + 2 * topArea() + 2 * sideArea();
        }

        public double faceArea()
        {
            return width * height;
        }

        public double topArea()
        {
            return width * length;
        }

        public double sideArea()
        {
            return height * length;
        }

    }
}

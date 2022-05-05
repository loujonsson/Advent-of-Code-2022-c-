using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Day2
    {
        private static int length;
        private static int width;
        private static int height;
        private static int side1;
        private static int side2;
        private static int side3;
        private static string[] measurements = new string[3];
        private static int smallestSide;

        /**
         * Wrapping paper for elves
         */
        internal static long First(string[] lines)
        {
            int area = 0;

            foreach (string line in lines)
            {
                getMeasurements(line); 

                side1 = length * width;
                side2 = length * height;    
                side3 = width * height;

                smallestSide = findSmallestSide(side1, side2, side3);

                area += 2 * side1 + 2 * side2 + 2 * side3 + smallestSide;
            }
                
            return area;
        }

        private static void getMeasurements(string line)
        {
            measurements = line.Split('x');

            length = Int32.Parse(measurements[0]);
            width = Int32.Parse(measurements[2]);
            height = Int32.Parse(measurements[1]);
        }

        private static int findSmallestSide(int side1, int side2, int side3)
        {
            int x = side1;
            if(x > side2)
                x = side2;

            if(x > side3)
                x = side3;

            return x;
        }

        /**
         * Ribbons
         */
        internal static int Last(string[] lines)
        {
            int ribbon = 0;

            foreach(string line in lines)
            {
                getMeasurements(line);

                ribbon += smallestPerimeter() + length * height * width;
            }

            return ribbon;
        }

        private static int smallestPerimeter()
        {
            int x = 2 * length + 2 * width;
            if (x > 2 * length + 2 * height)
                x = 2 * length + 2 * height;

            if (x > 2 * width + 2 * height)
                x = 2 * width + 2 * height;

            return x;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Day3
    {
        private static Dictionary<string, bool> visitedHouses = new Dictionary<string, bool>();
        private static string coordinates;
        private static int numberOfHouses = 1;

        internal static int First(string[] lines)
        {
            int x = 0;
            int y = 0;

            visitedHouses.Add("0.0", true);

            foreach (char c in lines[0])
            {
                var arr = checkHouse(c, x, y);

                x = arr[0];
                y = arr[1];
            }

            return numberOfHouses;

        }

        private static int[] checkHouse(char c, int x, int y)
        {
          
            if (c == '^')
                y++;
            else if (c == '>')
                x++;
            else if (c == '<')
                x--;
            else if (c == 'v')
                y--;

            coordinates = x.ToString() + '.' + y.ToString();

            if (!visitedHouses.ContainsKey(coordinates))
            {
                numberOfHouses++;
                visitedHouses.Add(coordinates, true);
            }
            

            int[] coordinatesArray = { x, y };

            return coordinatesArray;
        }

        internal static int Last(string[] lines)
        {
            int santaX = 0;
            int santaY = 0;
            int robotX = 0;
            int robotY = 0;

            visitedHouses.Add("0.0", true);

            int charPlacement = 0;

            foreach(char c in lines[0])
            {
                if (charPlacement % 2 == 0)
                {
                    var arr = checkHouse(c, santaX, santaY);

                    santaX = arr[0];
                    santaY = arr[1];
                }
                else
                {
                    var arr = checkHouse(c, robotX, robotY);

                    robotX = arr[0];
                    robotY = arr[1];
                }
                charPlacement++;
            }

            return numberOfHouses; 
        }   
       
    }
}

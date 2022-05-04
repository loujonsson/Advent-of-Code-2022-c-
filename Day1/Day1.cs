using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Day1
    {
        public static int First(string[] fileContent)
        {
            string s = fileContent[0];
            int floor = 0;

            foreach (char c in s)
            {
                floor += c == '(' ? 1 : -1;
            }

            return floor;
        }

        public static int Last(string[] fileContent)
        {
            string s = fileContent[0];
            int floor = 0;
            int pos = 1;

            foreach (char c in s)
            {
                floor += c == '(' ? 1 : -1;

                if (floor == -1)
                    break;

                pos++;
            }

            return pos;
        }
    }
}

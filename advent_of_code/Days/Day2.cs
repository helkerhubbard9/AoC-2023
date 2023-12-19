using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace advent_of_code.Days
{
    internal class Day2
    {
        readonly Dictionary<String, int> colors = new();
        private readonly Regex regex = new Regex("\\b\\d+\\s(blue|red|green)\\b"), regex_quatity_of = new("\\d+");

        public Day2(int quantity_of_red_blocks = 0, int quantity_of_green_blocks = 0, int quantity_of_blue_blocks = 0)
        {
            colors.Add("red", quantity_of_red_blocks);
            colors.Add("green", quantity_of_green_blocks);
            colors.Add("blue", quantity_of_blue_blocks);
        }

        public void ShowAvailableColors()
        {
            foreach (KeyValuePair<String, int> color in colors)
            {
                Console.WriteLine($"color {color.Key} => {color.Value} cube(s)");
            }
        } 

        public int SumOfValidIds(String path)
        {
            String line;
            int sum = 0, ID_Cnt = 1;

            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();

                while (line != null)
                {
                    sum += CheckIfValid(line, ID_Cnt);
                    ID_Cnt++;
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return 0;
        }

        //here is where the magic starts
        private int CheckIfValid(String line, int ID)
        {            
            int blue = 0, green = 0, red = 0;

            Console.Write(ID + ": ");
            foreach ( Match match in numbers ) { Console.Write(match + ", "); }

            if (blue > colors["blue"] || green > colors["green"] || red > colors["red"])
            {
                ID = 0;    
            }

            Console.WriteLine();


            return ID;
        }
    }

}

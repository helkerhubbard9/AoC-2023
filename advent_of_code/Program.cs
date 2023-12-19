using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using advent_of_code.Days;

namespace adventofcode
{
public class Program
{

        public static void Main(string[] args)
        {
            String path = "C:\\Users\\ACTECK\\OneDrive - INSTITUTO TECNOLOGICO SUPERIOR DE POZA RICA\\advent_of_code\\day2\\input.txt";

            //Day1 day1 = new Day1(path);
            //Console.WriteLine(day1.sum_of_values);
            
            Day2 day2 = new Day2(12, 13, 14);
            day2.SumOfValidIds(path);

            
        }

}

}

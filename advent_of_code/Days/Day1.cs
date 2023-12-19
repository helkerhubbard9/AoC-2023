using System;

namespace adventofcode.Days { 
internal class Day1
{
    public int sum_of_values;

    Dictionary<String, int> numbers_dict = new Dictionary<string, int>()
        {
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
            {"1", 1},
            {"2", 2},
            {"3", 3},
            {"4", 4},
            {"5", 5},
            {"6", 6},
            {"7", 7},
            {"8", 8},
            {"9", 9}
        };

    public Day1(String path)
    {
        sum_of_values = sum_of_calibrations(path);

    }


    private int sum_of_calibrations(String path)
    {
        String line;
        int sum = 0;
        try
        {
            StreamReader sr = new StreamReader(path);
            line = sr.ReadLine();

            while (line != null)
            {
                sum += extract_calibration(line);

                Console.WriteLine("\tsum = " + sum);

                line = sr.ReadLine();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return sum;
    }

    private int extract_calibration(String code)
    {
        int min, max, super_max = -1, super_min = code.Length;
        String last_value = "", first_value = "";

        Console.WriteLine(code + ": ");

        foreach (String value in numbers_dict.Keys)
        {
            min = code.IndexOf(value);
            max = code.LastIndexOf(value);

            if (min != -1 && min < super_min)
            {
                super_min = min;
                first_value = value;
            }

            if (max > super_max)
            {
                super_max = max;
                last_value = value;
            }
        }

        Console.Write($"\t{first_value}, {last_value}\n");

        return numbers_dict[first_value] * 10 + numbers_dict[last_value];
    }

}

}

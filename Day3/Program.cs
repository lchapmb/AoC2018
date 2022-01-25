using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // creates input list
            //List<string> input = new List<string>();
            List<string> testInput = new List<string>();

            // creates line variable for streamreader
            string line;

            // Opens file with stream reader
            using (var sr = new StreamReader("C:/Users/lewis.chapman-barker/source/repos/AoC2018/inputs/day 3 test.txt"))
            {
                // continues reading lines in text file until the read line would be null ie nothing to read
                while ((line = sr.ReadLine()) != null)
                {
                    // adds the line to input list
                    testInput.Add(line);
                }
            }

            int part1Result = Part1(testInput);

            Console.Write($"Part 1 result is {part1Result}\n");
        }

        public static int Part1(List<string> testInput)
        {
            Console.WriteLine("Part 1, FIGHT!");

            foreach(var coord in testInput)
            {
                Console.WriteLine(coord);
            }

            return -1;
        }
    }
}

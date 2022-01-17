using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AoC2018
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello AoC!");

            List<int> input = new List<int>();
            string line;
            // Opens file with stream reader
            using (var sr = new StreamReader("C:/Users/lewis.chapman-barker/source/repos/AoC2018/inputs/day 1.txt"))
            {
                // continues reading lines in text file until the read line would be null ie nothing to read
                while ((line = sr.ReadLine()) != null)
                {
                    input.Add(Int32.Parse(line));
                }
            }

            int part1Result = Part1(input);
            int part2Result = Part2(input);

            Console.WriteLine($"Part 1 result is {part1Result}");
            Console.WriteLine($"Part 2 result is {part2Result}");
        }

        public static int Part1(List<int> input)
        {
            // declare starting frequency
            int frequency = 0;

            // declare line variable
            string line;

            // loop through given date
            foreach(int val in input)
            {
                frequency += val;
            }

            // write frequency to console
            // Console.WriteLine(frequency);

            // return frequency
            return frequency;
        }

        public static int Part2(List<int> input)
        {
            try
            {
                // declare starting frequency
                int frequencyTotal = 0;

                // initalise list 
                List<int> pastFreq = new List<int>();

                // declare a breakout point
                int iterations = 2000;

                // open loop to go over changes multiple times
                while (iterations != 0)
                {
                    iterations--;

                    foreach (int val in input)
                    {
                        // parses the line and adds to total
                        frequencyTotal += val;

                        if (pastFreq.Contains(frequencyTotal))
                        {
                            return frequencyTotal;
                        }
                        else
                        {
                            pastFreq.Add(frequencyTotal);
                        }
                    }
                }
                return -1;
            }
            catch (IOException e)
            {
                Console.WriteLine("File could not be read:");
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}

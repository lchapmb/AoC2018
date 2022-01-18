using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // creates input list
            List<string> input = new List<string>();
            List<string> testInput = new List<string>();

            // creates line variable for streamreader
            string line;

            // Opens file with stream reader
            using (var sr = new StreamReader("C:/Users/lewis.chapman-barker/source/repos/AoC2018/inputs/day 2.txt"))
            {
                // continues reading lines in text file until the read line would be null ie nothing to read
                while ((line = sr.ReadLine()) != null)
                {
                    // adds the line to input list
                    input.Add(line);
                }
            }

            using (var sr = new StreamReader("C:/Users/lewis.chapman-barker/source/repos/AoC2018/inputs/day 2 test input 2.txt"))
            {
                // continues reading lines in text file until the read line would be null ie nothing to read
                while ((line = sr.ReadLine()) != null)
                {
                    // adds the line to input list
                    testInput.Add(line);
                }
            }

            int part1Result = Part1(input);
            string part2Result = Part2(testInput);

            Console.Write($"Part 1 result is {part1Result}\n");
            Console.Write($"Part 2 result is {part2Result}");
        }

        public static int Part1(List<string> input)
        {
            // declare int
            int checkTwiceRep = 0;
            int checkThriceRep = 0;

            foreach(var boxID in input)
            {
                //Console.WriteLine(boxID);

                // create flag for twiceRepeat and thriceRepeat
                bool twiceRepeat = false;
                bool thriceRepeat = false;

                // loop through characters in string
                for (int i = 0; i < boxID.Length; i++)
                {

                    // check for any character being repeated twice and flag false
                    if (boxID.Count(IDchar => (IDchar == boxID[i])) == 2 && !twiceRepeat)
                    {
                        // set flag to true if repetition found and increment the count
                        twiceRepeat = true;
                        checkTwiceRep++;
                    }

                    // check for any character being repeated thrice and flag false
                    if (boxID.Count(IDchar => (IDchar == boxID[i])) == 3 && !thriceRepeat)
                    {
                        // set flag to true if repetition found and increment the count
                        thriceRepeat = true;
                        checkThriceRep++;
                    }
                }
            }
            // multiply the value together and set as checksum

            //Console.WriteLine(checkTwiceRep);
            //Console.WriteLine(checkThriceRep);

            int checksum = checkTwiceRep * checkThriceRep;
            return checksum;
        }

        public static string Part2(List<string> input)
        {

            // init string for result
            string commonLetters = "not yet calculated";

            return commonLetters;
        }
    }
}

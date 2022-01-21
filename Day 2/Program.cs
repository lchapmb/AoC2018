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
            //List<string> testInput = new List<string>();

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

            //using (var sr = new StreamReader("C:/Users/lewis.chapman-barker/source/repos/AoC2018/inputs/day 2 test input 2.txt"))
            //{
            //    // continues reading lines in text file until the read line would be null ie nothing to read
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        // adds the line to input list
            //        testInput.Add(line);
            //    }
            //}

            int part1Result = Part1(input);
            string part2Result = Part2(input);

            Console.Write($"Part 1 result is {part1Result}\n");
            Console.Write($"Part 2 result is {part2Result}");
        }

        public static int Part1(List<string> input)
        {
            // declare int
            int checkTwiceRep = 0;
            int checkThriceRep = 0;

            foreach (var boxID in input)
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
            string commonLetters = "";

            // loop through list of strings
            foreach (var boxID in input)
            {
                //Console.WriteLine(boxID);

                // loop through list of strings again
                foreach (var compareID in input)
                {
                    //Console.WriteLine(compareID);

                    // init count of no matches
                    int noMatchCount = 0;

                    // loop through characters in first ID, comparing with same index in second ID
                    for (int i = 0; i < boxID.Length; i++)
                    {

                        if (boxID[i] != compareID[i])
                        {
                            // if no match increment count
                            //Console.WriteLine("No match");
                            noMatchCount++;
                        }
                        else
                        {
                            // if a match then add the character the commonLetters string
                            //Console.WriteLine("Match");
                            commonLetters += boxID[i];
                        }
                    }

                    // if matching count is one, save the matching strings (just writes to console for now)
                    if (noMatchCount == 1 && boxID != compareID)
                    {
                        //Console.WriteLine("Found it");
                        return commonLetters;
                    }
                    else
                    {
                        //Console.WriteLine("Not here");
                        commonLetters = "";
                    }
                }
            }

            commonLetters = "not found";
            return commonLetters;
        }
    }
}

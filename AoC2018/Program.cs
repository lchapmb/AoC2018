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

            // string testFreqInput = "+1, -2, +3, +1";

            using (StreamReader reader = new StreamReader("C:/Users/lewis.chapman-barker/source/repos/AoC2018/inputs/day 1.txt"))
            {
                // declare starting frequency
                int frequency = 0;

                // declare line variable
                string line;

                // loop through given date
                while ((line = reader.ReadLine()) != null){

                    // parse and add each line to frequency
                    Console.WriteLine(line);
                    frequency += Int32.Parse(line);
                }

                // write frequency to console
                Console.WriteLine(frequency);
            }
        }
    }
}

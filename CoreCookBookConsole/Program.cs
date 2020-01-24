using System;
using static System.Console;

namespace CoreCookBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!, about to calculate scores");
            int[] scores = { 17, 46, 39, 62, 81, 79, 52, 24 };
            Chapter1 ch1 = new Chapter1();
            var s = ch1.GetAverageAndCount(scores);
            WriteLine($"Average was {s.average} across {s.studentCount} students");
            ReadLine();

        }
    }

    public class Chapter1
    {
        public (int average, int studentCount) GetAverageAndCount(int[] scores)
        {
            var returnTuple = (0, 0);
            return returnTuple;
        }

    }

}

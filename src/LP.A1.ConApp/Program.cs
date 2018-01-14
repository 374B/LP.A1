using System;
using System.Collections.Generic;
using LP.A1._2._1;
using LP.A1._2._2;
using LP.A1._2._3;

namespace LP.A1.ConApp
{
    class Program
    {
        private static readonly Dictionary<decimal, Runner> _options = new Dictionary<decimal, Runner>();

        static void Main(string[] args)
        {
            var runners = new List<Runner>
            {
                new Runner(2.1m, "Balanced Brackets", RunBrackets),
                new Runner(2.2m, "FizzBuzz", RunFizzBuzz),
                new Runner(2.3m, "Time Angles", RunTimeAngles),
                new Runner(0m, "Quit", Quit)
            };

            runners.ForEach(x => _options.Add(x.Key, x));

            Options();

        }

        private static void Options()
        {
            Console.WriteLine("Select an option:\n");

            PrintOptions();

            var selected = Console.ReadLine();
            Runner option;
            decimal key;

            while (!decimal.TryParse(selected, out key) || !_options.TryGetValue(key, out option))
            {
                Console.WriteLine("\nPlease select a valid option:\n");
                PrintOptions();
                selected = Console.ReadLine();
            }

            Console.WriteLine();

            option.Run();
        }

        private static void PrintOptions()
        {
            foreach (var option in _options)
            {
                Console.WriteLine($"\t{option.Key}:\t{option.Value.Description}");
            }

            Console.WriteLine();

        }

        private static void RunBrackets()
        {
            Console.Write("Enter input string: ");
            var input = Console.ReadLine();

            var bb = new BalancedBrackets();
            var balanced = bb.Balanced(input);

            Console.WriteLine($"\nBalanced: {balanced}\n");

            Options();
        }

        private static void RunFizzBuzz()
        {
            var fb = new FizzBuzz();
            var results = fb.Apply(1, 100);

            Console.WriteLine();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();

            Options();
        }

        private static void RunTimeAngles()
        {
            Console.Write("Enter time (hh:mm). Leave empty to use current system time: ");
            var input = Console.ReadLine();

            TimeSpan ts;

            if (string.IsNullOrWhiteSpace(input))
            {
                ts = DateTime.Now.TimeOfDay;
            }
            else if (!TimeSpan.TryParse(input, out ts))
            {
                Console.WriteLine("\nCould not parse input\n");
                RunTimeAngles();
            }

            var calc = new TimeAnglesCalculator();
            var angle = calc.Calculate(ts);

            Console.WriteLine($"\nAngle: {angle} degrees\n");

            Options();
        }

        private static void Quit()
        {
            Console.WriteLine("Quitting...");
        }

    }
}

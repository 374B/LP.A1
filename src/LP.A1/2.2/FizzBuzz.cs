using System;
using System.Collections.Generic;

namespace LP.A1._2._2
{
    public class FizzBuzz
    {
        /// <summary>
        /// Apply the FizzBuzz algorithm over a range of numbers
        /// </summary>
        /// <param name="rangeStart">The first number in the range (inclusive)</param>
        /// <param name="rangeEnd">The last number in the range (inclusive)</param>
        /// <param name="increment">The increment to apply when iterating over the range</param>
        /// <returns></returns>
        public IEnumerable<string> Apply(int rangeStart, int rangeEnd, int increment = 1)
        {
            if (rangeEnd < rangeStart) throw new ArgumentOutOfRangeException(nameof(rangeEnd), "rangeEnd must be greater or equal to rangeStart");
            if (increment <= 0) throw new ArgumentOutOfRangeException(nameof(increment), "increment must be at least 1");

            var results = new List<string>();

            for (int i = rangeStart; i <= rangeEnd; i = i + increment)
            {
                var str = Apply(i);
                results.Add(str);
            }

            return results;
        }

        public string Apply(int number)
        {
            var str = number.ToString();

            if (number % 3 == 0)
            {
                str = "Fizz";

                if (number % 5 == 0)
                    str = str + "Buzz";

            }
            else if (number % 5 == 0)
            {
                str = "Buzz";
            }

            return str;
        }

    }
}

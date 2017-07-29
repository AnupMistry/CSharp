using System;
using System.Collections.Generic;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Created Console Project
             *  Added Nuget reference for valuetype <-- enables the C# feature
             *  Add using for System.Collections.Generic
             *  
             *  Working: Tally function returns more than 1 value
             * 
             */
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var r = Tally(numbers);
            Console.WriteLine($"Sum: {r.sum}, Count: {r.count}");
            Console.Read();
        }

        static (int sum, int count) Tally (IEnumerable<int> values)  {
            int s = 0; int c = 0;
            foreach (var v in values)
            {
                s += v;
                c++;
            }
            return (s, c);
        }

    }
}
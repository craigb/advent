using System;

namespace puzzle01._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = args[0];
            var sum = 0;
            var step = characters.Length >> 1;

            for (int i = 0; i < characters.Length; ++i)
            {
                var current = characters[i];
                var otherIndex = (i + step) % characters.Length;
                var next = characters[otherIndex];

                if (current == next)
                {
                    sum += current - '0';
                }
            }

            Console.WriteLine(sum);
        }
    }
}

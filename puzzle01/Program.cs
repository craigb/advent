using System;

namespace puzzle01
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = args[0];
            var sum = 0;

            for (int i = 1; i < characters.Length; ++i)
            {
                var current = characters[i-1];
                var next = characters[i];

                if (current == next)
                {
                    sum += current - '0';
                }
            }

            if (characters[0] == characters[characters.Length-1])
            {
                sum += characters[0] - '0';
            }

            Console.WriteLine(sum);
        }
    }
}

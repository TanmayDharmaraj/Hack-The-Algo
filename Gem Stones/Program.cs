using System;
using System.Linq;

namespace Gem_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] rocks = new string[N];
            for (int i = 0; i < N; i++)
            {
                rocks[i] = Console.ReadLine();
            }
            int index = 0;
            int smallest = rocks[0].Length;

            for (int i = 0; i < rocks.Length; i++)
            {
                if (rocks[i].Length < smallest)
                {
                    smallest = rocks[i].Length;
                    index = i;
                }
            }
            char[] c = rocks[index].ToCharArray();
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < rocks.Length; j++)
                    if (rocks[j].Contains(c[i]))
                        temp++;

                if (rocks.Length == temp)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}

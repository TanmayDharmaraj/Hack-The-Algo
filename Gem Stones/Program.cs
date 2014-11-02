using System;
using System.Linq;

namespace Gem_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string input;
            int[,] chr_array = new int[N, 26];
            int answer = 0;
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine();
                char[] tempArray = input.ToCharArray();
                foreach (char c in tempArray)
                    chr_array[i, (int)c - 'a']++;

            }

            for (int i = 0; i < 26; i++)
            {
                int flag = 0;
                for (int j = 0; j < N; j++)
                {
                    if (chr_array[j, i] == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);
            Console.ReadLine();


            /* Below is the old code. It basically does the same thing but in a little complicated way which made
             * the test case to fail.
             */
            #region Old code
            /*
            int N = Convert.ToInt32(Console.ReadLine());
            char[] rocks = new char[N];
            
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
            Console.WriteLine("Character = "+c[1]);
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                int temp = 0;
                foreach (string rock in rocks)
                {
                    if (rock.Contains(c[i]))
                        temp++;
                }
                if (rocks.Length == temp)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();*/
            #endregion
        
        }
    }
}

using System;
using System.Linq;
using System.Text;

namespace TheLoveLetterMystery
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            int[] output = new int[testCases];
            int count = 0;
            for (int i = 0; i < testCases; i++)
            {
                string console_input = Console.ReadLine();
                char[] input = console_input.ToCharArray();

                int halfLength = (input.Length) / 2;
                for (int j = 0; j < halfLength; j++)
                {
                    char left_letter = input[j];
                    char right_letter = input[input.Length - 1 - j];
                    if (left_letter != right_letter)
                    {
                        count += Math.Abs((int)right_letter - (int)left_letter);
                    }
                }
                output[i] = count;
                count = 0;
            }

            foreach (int value in output)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}

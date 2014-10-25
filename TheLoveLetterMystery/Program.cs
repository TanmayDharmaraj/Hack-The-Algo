using System;
using System.Linq;

namespace TheLoveLetterMystery
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            int[] output = new int[testCases];
            for (int i = 0; i < testCases; i++)
            {
                string console_input = Console.ReadLine();
                if (checkPalindrome(console_input))
                    continue;
                char[] input = console_input.ToCharArray();
                int count = 0;
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    int currentCharCode = (int)input[j];
                    for (int startChar = currentCharCode; startChar >= 97; startChar--)
                    {
                        input[j] = (char)startChar;
                        if (checkPalindrome(new string(input)))
                        {
                            j = 0;//to break out of the outer for loop
                            break;
                        }
                        else if (startChar != 97)
                        {
                            count++;
                        }
                    }
                }
                output[i] = count;
            }
            foreach (int value in output)
            {
                Console.WriteLine(value);
            }
        }
        private static bool checkPalindrome(string input)
        {
            char[] rev = input.Reverse<char>().ToArray<char>();
            return input.Equals(new string(rev));
        }
    }
}

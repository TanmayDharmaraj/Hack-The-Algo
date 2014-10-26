using System;
using System.Collections.Generic;

namespace Game_Of_Thrones_I
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> li = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                int char_i = input[i];
                int count = li.ContainsKey((char)char_i) ? li[(char)char_i] : 0;
                if (count == 0)
                {
                    int value = (int)char_i;
                    li.Add((char)value, ++count);
                }
                else
                {
                    li[(char)char_i]++;
                }
            }
            int oddCount = 0;
            foreach (int i in li.Values)
            {
                if (i % 2 != 0)
                {
                    oddCount++;
                }
            }
            if (oddCount < 2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}

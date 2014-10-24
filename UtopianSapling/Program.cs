using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianSapling
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int height = 0;
            int TestCase_input = Convert.ToInt32(Console.ReadLine());
            int[] TestCases = new int[TestCase_input];
            for (int testCount = 0; testCount < TestCases.Length; testCount++)
            {
                TestCases[testCount] = Convert.ToInt32(Console.ReadLine());
            }

            for (int testCase = 0; testCase < TestCases.Length; testCase++)
            {
                height = 1;
                int N = TestCases[testCase];
                for (int i = 0; i <= N; i++)
                {
                    if (i == 0)
                    {
                        //height++;
                    }
                    else if (i % 2 == 0)
                    {
                        //double
                        height++;
                    }
                    else
                    {
                        height = height * 2;
                    }
                }
                Console.WriteLine(height);

            }
            Console.ReadLine();
        }
    }
}

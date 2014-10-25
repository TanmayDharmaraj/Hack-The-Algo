using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            double[] result = new double[testCase];
            for (int i = 0; i < testCase; i++)
            {
                double k = Convert.ToDouble(Console.ReadLine());
                result[i] = Math.Floor((k/2) * (k - (k/2)));
            }
            foreach (double val in result)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}

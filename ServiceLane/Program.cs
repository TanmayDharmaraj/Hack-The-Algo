using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] inputVals = input.Split(' ');
                if (inputVals.Length != 2)
                {
                    Console.WriteLine("Invalid input. Input 2 numbers separated with a single space");
                    return;
                }
                int freewayLength = Convert.ToInt32(inputVals[0]);
                int testCaseLength = Convert.ToInt32(inputVals[1]);
                string[] output = new string[testCaseLength];
                string freewayValues = Console.ReadLine();

                string[] str_freeway = freewayValues.Split(' ');
                if (str_freeway.Length != freewayLength)
                {
                    Console.WriteLine("Invalid input. Input " + freewayLength + " numbers separated with a single space");
                    return;
                }
                //build the freeway
                int[] freeway = new int[freewayLength];
                for (int i = 0; i < freewayLength; i++)
                {
                    freeway[i] = Convert.ToInt32(str_freeway[i]);
                }


                for (int i = 0; i < testCaseLength; i++)
                {
                    string testCase = Console.ReadLine();
                    int segmentEnter = Convert.ToInt32(testCase.Split(' ')[0]);
                    int segmentExit = Convert.ToInt32(testCase.Split(' ')[1]);
                    int result = freeway[segmentEnter];
                    for (int j = segmentEnter; j <= segmentExit; j++)
                    {
                        if (result > freeway[j])
                            result = freeway[j];
                    }
                    output[i] = result.ToString();
                }

                //print the output
                foreach (string outValue in output)
                {
                    Console.WriteLine(outValue);
                }
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error ! " + Environment.NewLine + e.Message);
            }
        }
    }
}

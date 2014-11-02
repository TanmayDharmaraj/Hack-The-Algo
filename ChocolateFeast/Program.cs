using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            int[][] array = new int[T][];
            Queue<int> answer = new Queue<int>();

            for (int i = 0; i < T; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                array[i] = new int[3] { Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]) };
            }

            foreach (int[] ar in array)
            {
                int N = ar[0]; int C = ar[1]; int M = ar[2];
                int ans1 = (N / C);
                int init = ans1;
                while (init / M > 0)
                {
                    int div = init / M;
                    int rem = init % M;
                    ans1 += div;
                    init = div + rem;
                }
                answer.Enqueue(ans1);
            }
            foreach (int ans in answer)
            {
                Console.WriteLine(ans);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace cut_the_sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] values = Console.ReadLine().Split(' ');
            int[] A = new int[N];
            //List<int> li = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int val = Convert.ToInt32(values[i]);
                A[i] = val;
                //if (!li.Contains(val))
                //    li.Add(val);
            }
            Array.Sort<int>(A);
            int count = A.Length;
            Console.WriteLine(count);

            for (int i = 0; i < A.Length; i++)
            {
                int temp = 0;
                int curr = A[i];
                if (curr == 0) continue;
                for (int j = i; j < A.Length; j++)
                {
                    if (A[j] == curr)
                    {
                        A[j] = 0;
                        temp++;
                    }
                    else
                    {
                        count = count - temp;
                        Console.WriteLine(count);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

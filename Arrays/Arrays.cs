using System;

namespace WASP_PR_1
{
    class Arrays
    {
        public static void Task_1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double p = Convert.ToDouble(Console.ReadLine());
            double[] arr = new double[n];
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
                result += Math.Pow(arr[i], p);
            }
            result = Math.Pow(result, 1 / p);
            Console.WriteLine(result);
        }

        public static void Task_2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int min_i = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_i])
                    {
                        min_i = j;
                    }
                }
                int temp = arr[min_i];
                arr[min_i] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine(arr[k - 1]);
        }

        public static void Task_3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int begin = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            int step = Convert.ToInt32(Console.ReadLine());

            if (step > 0)
            {
                for (int i = begin; i <= end; i += step)
                {
                    Console.Write($"{arr[i]} ");
                }
            } else if (step < 0)
            {
                for (int i = end; i >= begin; i += step)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}

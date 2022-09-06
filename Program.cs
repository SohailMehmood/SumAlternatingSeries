using System;

namespace SumAlternatingSeries
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            float sum = 0;

            for (float i = 1; i <= 1e6; i++)
            {
                if (i % 2 == 1)
                {
                    sum += 1 / (2 * i - 1);
                }
                else
                {
                    sum -= 1 / (2 * i - 1);
                }

                float answer = sum * 4;
                sum++;

                Console.WriteLine(answer);

            }


        }
    }
}
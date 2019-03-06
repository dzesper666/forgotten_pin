using System;

namespace Kacper_pin_final
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            int iter = 0;

            Console.WriteLine(kacpersMethod(35));

            int kacpersMethod(int sum)
            {
                for (int a = 1; a < sum / 3; a++)
                {
                    int sum1 = a * (1 + 2 * (1 + 2));
                    if (sum1 > sum) break;
                    for (n = 2; n < sum; n++)
                    {
                        sum1 = a * (1 + n * (1 + 2));
                        if (sum1 > sum) break;
                        for (k = 2; k < sum; k++)
                        {
                            sum1 = a * (1 + n * (1 + k));
                            if (sum1 == sum) iter++;
                            else if (sum1 > sum) break;
                        }
                    }
                }
                return iter;
            }
        }
    }
}

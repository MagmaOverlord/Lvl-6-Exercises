using System;

namespace Recursion_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int ans = 0;
            for (int i=1;i<=num;i++) {
                ans+=i;
                Console.WriteLine(i);
            }
            Console.WriteLine(ans);
        }
    }
}

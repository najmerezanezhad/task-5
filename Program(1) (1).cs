using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonacci_function
{
    class Program
    {
       static void Main(string[] args)
    {
        Console.Write("please enter number:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int result = Fibonacci(n, new Dictionary<int, int>());
        Console.WriteLine("fibonacci:{0}", result);
        Console.ReadKey();
    }

    static int Fibonacci(int n, Dictionary<int, int> memo)
    {
        // Base case checks
        if (n <= 0) return 0; // Fibonacci sequence for n=0 is 0
        if (n == 1) return 1;  // Fibonacci sequence for n=1 is 1


        // Check if the result has already been computed
        if (memo.ContainsKey(n))
        {
            return memo[n];
        }

        // Calculate and store the result
        memo[n] = Fibonacci(n - 1, memo) + Fibonacci(n - 2, memo);
        return memo[n];
    }
    }
}

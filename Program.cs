using System;
using System.Collections.Generic;
using System.Linq;

namespace atcoder {
    class Program 
    {
        static void Main (string[] args)
        {
            ABC140.Buffet();
        }
    }

    class ABC140
    {
        public static void Password()
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(n, 3));
        }

        public static void Buffet()
        {
            int n = int.Parse(Console.ReadLine());
            var dish = Input.getIntArray();
            var satisfaction = Input.getIntArray();
            var addSatisfaction = Input.getIntArray();
            int result = satisfaction.Sum(x=>x);

            for (int i = 0; i < n-1; i++)
            {
                if(dish[i+1]-dish[i]==1)
                {
                    result = result + addSatisfaction[i - 1];
                }
            }
            Console.WriteLine(result);
        }

    }
}
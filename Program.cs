using System;
using System.Linq;
using System.Collections.Generic;

namespace atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(' ');
            int[] w = a.Select(x=>int.Parse(x)).ToArray();
        
            int sum = w.Sum();
            int result =0;

            for(int i = 0; i<n; i++)
            {
                int s1 = 0;
                int s2 = 0;

                for(int j = 0; j<=i; j++)
                {
                    s1= s1 + w[j];
                }
                s2 = sum-s1;
                
                if(result < Math.Abs(s2-s1))
                {
                    result = Math.Abs(s2-s1);
                }

            }

            Console.WriteLine(result);
        }
    }

    class Output
    {
        public static void writeIntArraySprit(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                if(i == array.Length-1)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i+" ");    
                }
                
            }
        }
    }

    class Input
    {
        public static int[] getIntArray()
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] num = s.Select(x=>int.Parse(x)).ToArray();
            return num;
        }
        public static long[] getLongArray()
        {
            string[] s = Console.ReadLine().Split(' ');
            long[] num = s.Select(x=>long.Parse(x)).ToArray();
            return num;
        }
        public static string[] getStringArray(int n)
        {
            var s = new string[n];
            for(int i=0; i<n; i++)
            {
                s[i] = Console.ReadLine();
            }
            return s;
        }
    }

    class Calc
    {
        //Greatest common divisor
        public static int Gcd(int a, int b)
        { 
            if(a<b)
            {
                return Gcd(b,a);
            }
            else
            {
                while(b != 0)
                {
                    int tmp = a%b;
                    a = b;
                    b = tmp;
                }
                return a;                
            }

        }

        //Least common multiple
        public static long Lcm(int a, int b)
        {
            return (long)(a*b/Gcd(a,b));
        }
    }
}

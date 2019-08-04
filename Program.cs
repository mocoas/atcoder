using System;
using System.Linq;
using System.Collections.Generic;

namespace atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            C.AntiDivision();
        }
    }

    class C
    {
        public static void AntiDivision()
        {
            long[] num = Input.getLongArray();
            long a = num[0];
            long b = num[1];
            int c = (int)(long)num[2];
            int d = (int)(long)num[3];
            long cd = Calc.Lcm(c,d);

            long cntAll = b-a+1;
            long cntC = (long)Math.Floor((decimal)b/c) - (long)Math.Ceiling((decimal)a/c) + 1;
            long cntD = (long)Math.Floor((decimal)b/d) - (long)Math.Ceiling((decimal)a/d) + 1;
            long cntCD = (long)Math.Floor((decimal)b/cd) - (long)Math.Ceiling((decimal)a/cd) + 1;

            Console.WriteLine(cntAll-(cntC+cntD-cntCD));
        }
    }
  
    class Input
    {
        public static int getInt()
        {
            int i = int.Parse(Console.ReadLine());
            return i;
        }

        public static string getString()
        {
            string s = Console.ReadLine();
            return s;
        }
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

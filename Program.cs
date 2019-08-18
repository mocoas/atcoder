using System;
using System.Linq;
using System.Collections.Generic;

namespace atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            ABC138.Alchemist();
        }
    }

    class ABC138
    {
        public static void Alchemist()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = Input.getIntArray();
            var sortV = v.Select(x=>double.Parse(x.ToString())).OrderBy(x=>x).ToArray();

            double ed;
            for(int i=0; i<n-1; i++)
            {
                ed = (sortV[i]+sortV[i+1])/2;
                sortV[i+1] = ed;
            }

            Console.WriteLine(sortV[n-1]);
        }
        public static void ResistorsInParallel()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Input.getIntArray();

            double result = 1/a.Select(x=>(double)1/x).Sum();
            Console.WriteLine(result);
            
        }
        public static void RedOrNot()
        {
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            if(a>=3200)
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("red");
            }
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
        public static void writeInt(int i)
        {
            Console.WriteLine(i);
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

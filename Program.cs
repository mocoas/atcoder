using System;
using System.Linq;
using System.Collections.Generic;

namespace atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            ABC137.GreenBin();
        }
    }

    class ABC137
    {
        public static void GreenBin()
        {
            int n = int.Parse(Console.ReadLine());
            var s = Input.getStringArray(n);
            for(int i=0; i<n; i++)
            {
                var a = s[i].ToCharArray();
                Array.Sort(a);
                string str = new string (a);
                s[i] = str;                
            }

            var result = s.GroupBy(x=>x).Where(x=>x.Count()>1).Select(x=> new {number = x.Key, cnt=x.Count() -1}).ToList();
            //long allCount = result.Sum(x=>x.Count*(x.Count-1)/2);
            Console.WriteLine(result.Count());
        }
        public static void OneClue()
        {
            var num = Input.getIntArray();
            if(num[0]==1)
            {
                Console.Write(num[1]);
            }
            else
            {
                int a = num[1]-num[0]+1;
                int b = num[1]+num[0]-1;
                for(int i=a; i<=b; i++)
                {
                    if(i==b)
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
        public static void plus()
        {
            var i = Input.getIntArray();
            int[] a = {i[0] + i[1], i[0] - i[1], i[0] * i[1]};
            Console.WriteLine(a.Max());
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

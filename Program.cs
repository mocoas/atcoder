using System;
using System.Linq;
using System.Collections.Generic;

namespace atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            if(ABC136.BuildStairs())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    class ABC136
    {
        public static bool BuildStairs()
        {
            int n = Input.getInt();
            long[] h = Input.getLongArray();
<<<<<<< HEAD
            
            if(n==1) return true;

            for(int i=n-1; i>0; i--)
=======
            int left = 0;
            int right;
            while(left+1<n)
>>>>>>> eeda3495362a1101474f045c1118167e764231fa
            {
                if(h[i-1]-h[i]==1)
                {
                    h[i-1] = h[i-1]-1;        
                }
                if(h[i-1]-h[i]>0)
                {
<<<<<<< HEAD
                    return false;
=======
                    if(h[left]<=h[right])
                    {
                        left = right;
                        right ++;
                    }
                    else if(h[left]-h[right]>=2)
                    {
                        return false;
                    }
>>>>>>> eeda3495362a1101474f045c1118167e764231fa
                }
            }

            return true;
        }

        public static void UnevenNumbers()
        {
            int n = Input.getInt();
            int cnt = 0;
            if(n<10) cnt = n%10;
            if(10<= n && n < 100)
            {                
                cnt = 9;
            }
            if(100<= n && n <1000)
            {
                cnt = n- 99 + 9;
            } 
            if(1000<= n && n<10000)
            {
                cnt = 999 - 99 + 9;
            }
            if(10000<=n && n<100000)
            {
                cnt = n - 9999 + 999 - 99 + 9;
            }
            if(n==100000) cnt = 99999-9999+999-99+9;
            Console.WriteLine(cnt);
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

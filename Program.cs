using System;
using System.Collections.Generic;
using System.Linq;

namespace atcoder {
    class Program {
        static void Main (string[] args)
        {
            ABC139.PowerSocket();
        }
    }

    class ABC139
    {
        public static void Lower()
        {
            int n = int.Parse(Console.ReadLine());
            var hight = Input.getIntArray();
            int point = 0;
            int max = 0;
            int tmp = 0 ;
            int i = 0;

            while(i<n-1)
            {
                if(hight[i]>=hight[i+1])
                {
                    tmp++;    
                    
                    if(tmp > max)
                    {
                        max = tmp;
                    }
                }
                else
                {
                    tmp=0;
                }
                
                i++;
            }

            Console.WriteLine(max);
        }
        public static void PowerSocket()
        {
            var s = Input.getIntArray();
            int a = s[0];
            int b = s[1];

            int tap = 0;
            if(b<=a)
            {
                tap=1;
            }
            else
            {
                tap = (int)Math.Ceiling((double)(b-a)/(a-1)) + 1;
            }        

            Console.WriteLine(tap);
        }
        public static void Tenki()
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            int cnt = 0;

            for(int i=0; i<3; i++)
            {
                if(s[i]==t[i])
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }

    
    }

    class Output {
        public static void writeIntArraySprit (int[] array) {
            for (int i = 0; i < array.Length; i++) {
                if (i == array.Length - 1) {
                    Console.Write (i);
                } else {
                    Console.Write (i + " ");
                }

            }
        }
    }

    class Input {
        public static int[] getIntArray () {
            string[] s = Console.ReadLine ().Split (' ');
            int[] num = s.Select (x => int.Parse (x)).ToArray ();
            return num;
        }
        public static long[] getLongArray () {
            string[] s = Console.ReadLine ().Split (' ');
            long[] num = s.Select (x => long.Parse (x)).ToArray ();
            return num;
        }
        public static string[] getStringArray (int n) {
            var s = new string[n];
            for (int i = 0; i < n; i++) {
                s[i] = Console.ReadLine ();
            }
            return s;
        }
    }

    class Calc {
        //Greatest common divisor
        public static int Gcd (int a, int b) {
            if (a < b) {
                return Gcd (b, a);
            } else {
                while (b != 0) {
                    int tmp = a % b;
                    a = b;
                    b = tmp;
                }
                return a;
            }

        }

        //Least common multiple
        public static long Lcm (int a, int b) {
            return (long) (a * b / Gcd (a, b));
        }
    }
}
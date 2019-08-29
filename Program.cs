using System;
using System.Collections.Generic;
using System.Linq;

namespace atcoder {
    class Program {
        static void Main (string[] args)
         {
            int n = int.Parse (Console.ReadLine ());
            var dic = new Dictionary<Tuple<int,string>,int>();
            string[] s = Input.getStringArray (n);

            for (int i = 0; i < n; i++) {

                var str = s[i].Split (' ');
                dic.Add(Tuple.Create(i+1,str[0]), int.Parse(str[1]));

            }

            foreach(var item in dic.OrderBy(x => x.Key.Item2).ThenByDescending(x => x.Value))
            {
                Console.WriteLine(item.Key.Item1);
            }

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
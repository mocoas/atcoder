using System;
using System.Linq;

namespace atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeC.test();
        }
    }

    class PracticeC
    {
        public static void test()
        {
            char[] s = Input.getString().ToCharArray();
            int result = 0;
            
            for (int i = 0; i<s.Length; i++)
            {
                if(s[i]=='1')
                {
                    result ++;
                }
            }
            Console.WriteLine(result);
        }
    }

    class Input
    {
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
    }

    class PracticeB
    {
        public static void test()
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] num = s.Select(x=>int.Parse(x)).ToArray();

            if(num[0]%2==0 || num[1]%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
    class PracticeA
    {
        public static void test()
        {
            int a = int.Parse(Console.ReadLine());
            string[] b = Console.ReadLine().Split(' ');
            int[] bc = b.Select(x=>int.Parse(x)).ToArray();
            string s = Console.ReadLine();
            
            
            int abc = a + bc[0]+bc[1];
            var result = abc + " " + s;   
            Console.WriteLine(result);
        }
    }
    
}

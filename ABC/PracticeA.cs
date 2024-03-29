using System;
using System.Linq;

namespace atcoder.ABC.A
{
    class ProgramA
    {
        public static void ABC()
        {
            A.FiftyFifty();
        }                                       
    }

    class A
    {
        public static void Dodecagon()
        {
            int r = Input.getInt();
            int d = 3 * r * r ;
            Console.WriteLine(d);   
        }

        public static void TorT()
        {
            int[] num = Input.getIntArray();
            int train = num[0] * num[1];
            if(train>num[2]) 
            {
                Console.WriteLine(num[2]);
            }
            else{
                Console.WriteLine(train);
            }
        }
        public static void FiftyFifty()
        {
            string s = Input.getString();

            if(s[0] == s[1] && s[1] == s[2])
            {
                Console.WriteLine("No");
            }
            else if ( s[0] == s[1]  &&  s[2] == s[3] )
            {
                Console.WriteLine("Yes");
            }
            else if( s[1] == s[2] && s[0] == s[3])
            {
                Console.WriteLine("Yes");
            }
            else if( s[0] == s[2] && s[1] == s[3])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            } 
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
    }
}

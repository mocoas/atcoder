using System;
using System.Linq;

namespace atcoder
{
class ABC139
    {
        public static void Lower()
        {
            int n = int.Parse(Console.ReadLine());
            var hight = Input.getIntArray();
            int max = 0;
            int tmp = 0;
            int i = 0;

            while (i < n - 1)
            {
                if (hight[i] >= hight[i + 1])
                {
                    tmp++;

                    if (tmp > max)
                    {
                        max = tmp;
                    }
                }
                else
                {
                    tmp = 0;
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
            if (b == 1)
            {
                tap = 0;
            }
            else if (b <= a)
            {
                tap += 1;
            }
            else
            {
                tap = (int)Math.Ceiling((double)(b - a) / (a - 1)) + 1;
            }

            Console.WriteLine(tap);
        }
        public static void Tenki()
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            int cnt = 0;

            for (int i = 0; i < 3; i++)
            {
                if (s[i] == t[i])
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }

    }
}

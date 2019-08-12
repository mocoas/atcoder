using System;
using System.Linq;
using System.Collections.Generic;

namespace atcoder
{
        class ABC137
    {
        public static void GreenBin()
        {
            int n = int.Parse(Console.ReadLine());
            var s = Input.getStringArray(n);
            var dic = new Dictionary<string,long>();
            long cnt = 0;
            for(int i=0; i<n; i++)
            {
                var a = s[i].ToCharArray();
                Array.Sort(a);
                string str = new string (a);
                if(dic.ContainsKey(str))
                {
                    dic.TryGetValue(str,out cnt);
                    cnt ++;
                    dic[str] = cnt;
                }
                else
                {
                    dic.Add(str,1);
                }                            
            }
            cnt = dic.Values.Select(x=>x*(x-1)/2).Sum();
            Console.WriteLine(cnt);
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
}
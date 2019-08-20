using System;

namespace atcoder
{
    class ABC136
    {
        public static bool BuildStairs()
        {
            int n = int.Parse(Console.ReadLine());
            long[] h = Input.getLongArray();
           
            if(n==1) return true;

            for(int i=n-1; i>0; i--)

            {
                if(h[i-1]-h[i]==1)
                {
                    h[i-1] = h[i-1]-1;        
                }
                if(h[i-1]-h[i]>0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void UnevenNumbers()
        {
            int n = int.Parse(Console.ReadLine());
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
  
}

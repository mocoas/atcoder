using System;
using System.Linq;

namespace atcoder{
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
}
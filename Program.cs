﻿using System;
using System.Linq;

namespace atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            B.GoodDistance();
        }
    }

    class B
    {
        public static void GoodDistance()
        {
            int[] num = Input.getIntArray();
            int n = num[0];
            int d = num[1];
            int[,] point = new int[n,d];
            for(int i=0; i<n; i++)
            {
                int[] temp = Input.getIntArray();
                for(int j=0; j<d; j++)
                {
                    point[i,j] = temp[j];
                }
            }

            int cnt =0;
            for(int i=0; i<n; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    double route =0;
 
                    for(int k=0; k<d; k++)
                    {
                        double tmp = Math.Pow(Math.Abs(point[i,k]-point[j,k]),2);
                        route += tmp;
                    }
                    
                    double result = Math.Sqrt(route);
                    if(route == Math.Pow(Math.Floor(result),2))
                    {
                        cnt ++;
                    }
                }
            }

            Output.writeInt(cnt);
        }
        public static void OrdinaryNumber()
        {
            int n = Input.getInt();
            int[] p = Input.getIntArray();

            int cnt = 0;
            for(int i=1; i<n-1; i++)
            {
                if(p[i-1]<p[i] && p[i]<p[i+1] || p[i-1]>p[i] && p[i]>p[i+1]) cnt ++;                
            }

            Output.writeInt(cnt);
        }
        public static void BiteEating()
        {
            int[] a = Input.getIntArray();
            int apple = a[0];
            int taste = a[1];
            int preApplepie = 0;

            for(int i = 1; i <= apple; i++)
            {
                preApplepie = preApplepie + (taste + i - 1);
            }

            int tmp = 0;
            int applepie;
            int result=0;            
            for(int i = 1; i<= apple; i++)
            {   
                applepie = preApplepie - (taste + i -1 );
                int abs = Math.Abs(preApplepie - applepie);

                if(i==1)
                {
                    tmp = abs;
                    result = applepie;
                }
                else if(tmp > abs)
                {
                    tmp = abs;
                    result = applepie;
                }                    
            }

            Output.writeInt(result);
        }

        public static void GoldenApple()
        {
            int[] num = Input.getIntArray();
            decimal n = num[0];
            decimal d = num[1];
            int human = 0;

            // ++ * ++ ++ * ++ ++ * ++
            
            human = decimal.ToInt32(Math.Ceiling(n / (d + d + 1)));
            Output.writeInt(human);
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

    class Output
    {
        public static void writeInt(int i)
        {
            Console.WriteLine(i);
        }
    }
}

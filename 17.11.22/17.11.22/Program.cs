using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorprim
{
    internal class Program
    {
        static Random random = new Random();

        static bool isprim(int x)
        {
            if (x < 2)
                return false;
            if (x == 2)
                return true;
            if (x % 2 == 0)
                return false;
            for (int i = 3; i <= Math.Sqrt(x); i+=2)
                if (x % i == 0)
                    return false;
                return true;
        }

        static bool palindrom(int x)
        {
            int r, temp, sum = 0;
            temp = x;
            while (x > 0)
            {
                r = x % 10;
                sum = (sum * 10) + r;
                x = x / 10;
            }
            if (temp == sum)
                return true;
            return false;
        }


        static void Main(string[] args)
        {
            int []v;
            int nr = 0;
            int nr2 = 0;
            int  n = int.Parse(Console.ReadLine());
            v = new int[n];
            for(int i = 0; i < n; i++)
                v[i] = random.Next(-100,101);
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                
                if (isprim(v[i]))
                { 
                    Console.WriteLine("prim : " + v[i] + " ");
                    nr++;
                }
            }
            Console.WriteLine("total nr prime : " + nr);

            for (int i = 0; i < n; i++)
            {
                if (palindrom(v[i]))
                {
                    
                    Console.WriteLine("palindrom : " + v[i] + " ");
                    nr2++;
                }
            }
            Console.WriteLine("total palindrom : " + nr2);

        }
    }
}
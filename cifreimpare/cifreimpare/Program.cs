using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cifreimpare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c1 = n % 10;
            int c2 = (n / 10) % 10;
            int c3 = n / 100;

            int nr = 0;
            if(c1 % 2 == 1)
                nr++;
            if (c2 % 2 == 1)
                nr++;
            if (c3 % 2 == 1)
                nr++;
            Console.WriteLine(nr);
        }
    }
}

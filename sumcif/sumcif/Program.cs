using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumcif
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string[] t = Console.ReadLine().Split(' ');
            int a=int.Parse(t[0]);
            int b=int.Parse(t[1]);
            int c=int.Parse(t[2]);

            int sca = a % 10 + a / 10;
            int scb = b % 10 + b / 10;
            int scc = c % 10 + c / 10;

            int max = sca;
            if(scb > max)
                max = scb;
            if(scc > max)
                max = scc;

            if (sca == max)
                Console.Write(a + " ");
            if (scb == max)
                Console.Write(b + " ");
            if (scc == max)
                Console.Write(c + " ");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nr_primi
{
    internal class Program
    {
        // se da un vector de dimensiune n<1000 in fisierul data.in
        // se cere sa se insereze dupa toate valorile prime suma cifrelor acestora
        // ex:
        // in: 2 9 11 70 203
        //  1 -1 11
        //  3
        // out: 2 2 9 11 2 70 203 5 -1 11 2 3 3
        static void Main(string[] args)
        {
            int[] v = load(@"..\..\Resurse\data.in");


        }
        bool isprim(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        int sumacifrelor(int a)
        {
            int s = 0;
            while (a > 0)
            {
                s += a % 10;
                a /= 10;
            }
            return s;
        }
        static int[] load(string fileName)
        {
            TextReader load = new StreamReader(fileName);
            string buffer;
            List<int> T = new List<int>();
            while ((buffer = load.ReadLine()) != null)
            {
                string[] local = buffer.Split(' ');
                foreach (string s in local)
                    T.Add(int.Parse(s));

            }
            int[] toReturn = new int[T.Count];
            for (int i = 0; i < T.Count; i++)
            {
                toReturn[i] = T[i];
            }
            return toReturn;
        }
    }
}
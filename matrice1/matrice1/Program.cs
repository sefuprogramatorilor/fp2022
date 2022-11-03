/*Implementarea problemelor ce ţin de numărul de elemente identice într-o mulţime (1,3,4,1,1) = 3 bucăţi
[Se dau 5 valori întregi a, b, c, d şi e.Construiţi un algoritm care identifică următoarele cazuri:
    1.) Există 2 valori identice, 2.) Există 2 cȃte 2 valori identice, 3.) Există 3 valori identice,
    4.) Există 3valori identice şi celelalte 2 sunt de asemena identice,
    5.) Există 4 valori identice şi 6.) Toate valorile sunt identice]
[Să se verifice dacă valorile pot fi elementele consecutive ale unei progresii aritmetice cu raţia 1.]*/

using System;

namespace matrice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;


            Console.Write("\n\nSort elements of array in ascending order :\n");
            Console.Write("----------------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }

            }

            if (arr1[0] == arr1[1] && arr1[0] == arr1[2] && arr1[0] == arr1[3] && arr1[0] == arr1[4])
                Console.WriteLine("caz 5 : 5 indentice");
            else if (arr1[0] == arr1[1] && arr1[0] == arr1[2] && arr1[0] == arr1[3] || arr1[1] == arr1[2] && arr1[1] == arr1[3] && arr1[1] == arr1[4])
                Console.WriteLine("caz 4 : 4 identice");
            else if (arr1[0] == arr1[1] && arr1[0] == arr1[2] && arr1[3] == arr1[4] || arr1[0] == arr1[1] && arr1[2] == arr1[3] && arr1[3] == arr1[4])
                Console.WriteLine("caz 3 : 3-2 identice");
            else if (arr1[0] == arr1[1] && arr1[0] == arr1[2] || arr1[1] == arr1[2] && arr1[1] == arr1[3] || arr1[2] == arr1[3] && arr1[2] == arr1[4])
                Console.WriteLine("caz 2 : 3 identice");
            else if ((arr1[0] == arr1[1] && (arr1[2] == arr1[3] || arr1[3] == arr1[4])) || arr1[1] == arr1[2] && arr1[3] == arr1[4])
                Console.WriteLine("caz 1 : 2-2 identice");
            else if (arr1[0] == arr1[1] || arr1[1] == arr1[2] || arr1[2] == arr1[3] || arr1[3] == arr1[4])
                Console.WriteLine("2 identice");
            else
                Console.WriteLine("nu sunt valori identice");
            


            /*Random rnd= new Random();  
            int a = rnd.Next(5); 
            int b = rnd.Next(5);
            int c = rnd.Next(5);
            int d = rnd.Next(5);
            int e = rnd.Next(5);
            int t;
            
            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }*/


            /*int[] v = new int[5];
            for(int i = 1; i <= 5; i++)
                v[i] = Convert.ToInt32(Console.ReadLine());
            if (v[1] == v[2])

            if (a == b || a == c || a == d || a == e || b == c || b == d || b == e || c == d || c == e || d == e)
                Console.WriteLine("2 voalori sunt identice"); */

        }
    }
}
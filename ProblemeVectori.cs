using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere
{
    internal class ProblemeVectori
    {
        public static void ex1()
        {   //se da un sir cu n elem, nr. nat. Det. dif. in valoare absoluta dintre nr. de valori pare si nr. de valori impare din sir.
            int n = Int32.Parse(Console.ReadLine());
            int[] v = new int[n];
            int par = 0, impar = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = Int32.Parse(Console.ReadLine());
                if (v[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }

            if (par > impar)
            {
                Console.WriteLine(par - impar);
            }
            else
            {
                Console.WriteLine(impar - par);
            }
            //v.ToList().ForEach(x => Console.Write(x.ToString()));
        }

        public static void ex2()
        {   //sa se afiseze elem. din vector care sunt multipli ai ultimului element
            int n = Int32.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] % v[v.Length - 1] == 0)
                {
                    Console.Write(v[i]);
                    Console.Write(" ");
                }
            }
        }

        private static bool isPrime(int num)
        {
            if (num < 1) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static void ex3()
        {   //sa se inlocuiasca ultimul elem. prim din vector cu 0, apoi sa se afis. vectorul
            int n = Int32.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (isPrime(v[i]))
                {
                    v[i] = 0;
                    v.ToList().ForEach(x => Console.Write(x.ToString()));
                    return;
                }
            }
        }
    }
}

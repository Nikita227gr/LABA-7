using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Var15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] g = new int[15];
            int[] r = new int[15];
            double p = 1;
            int k = 0;
            for (int i = 0; i < g.Length; i++)
            {
                g[i] = rand.Next(-10, 11);
            }
            for (int i = 0; i < g.Length; i++)
            {
               if (g[i] > 0)
                {
                    p *= g[i];
                    k++;
                }
            }
            for (int i = 0; i < g.Length; i++)
            {
                Console.WriteLine("d[" + (i + 1) + "] =" + g[i]);
            }
            Console.WriteLine($"произведение положительных чисел={p}  кол-во = {k}");
            Console.WriteLine("");
            Console.WriteLine("Задание 2");
            for (int i = 0; i < r.Length; i++)
            {
                r[i] = 6 * g[i] - 7;
            }
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine("r[" + (i + 1) + "] =" + r[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Задание 3");
            int kg = 0;
            int kr = 0;
            int sg =0;
            int sr =0;

            for (int i = 0; i < r.Length; i ++)
            {
                if (r[i] < 0)
                {
                    sr += r[i];
                    kr++;
                }
                if (g[i] < 0)
                {
                    sg += g[i];
                    kg++;
                }
            }
            int S = 0;
            k = kg + kr;
            S = sg + sr;
            Console.WriteLine($"сумму всех отрицательных элементов массивов = {S}, и количество таких элементов = {k}");
        }
    }
}

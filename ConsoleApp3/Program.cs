using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите кол-во секунд");
            //int T = Convert.ToInt32(Console.ReadLine());
            //int S, M;
            //Pervoe(T, out S, out M);
            //Console.WriteLine("Минут {0}, секунд {1}", M, S);
            Console.WriteLine("Введите два числа");
            float A = Convert.ToInt32(Console.ReadLine());
            float B = Convert.ToInt32(Console.ReadLine());
            Vtoroe(ref A, ref B);
            Console.WriteLine("Первое {0}, второе {1}", A, B);
        }

        static void Vtoroe(ref float A, ref float B)
        {
            float a = A, b = B;
            if (A > B)
            {
                A = (a + b) * 2;
                B = (b + a) / 2;
            }
            else
            {
                B = (b + a) * 2;
                A = (a + b) / 2;
            }
        }
        static void Pervoe(int T, out int M, out int S)
        {
            M = T % 60;
            S = T / 60;
        }
    }
}

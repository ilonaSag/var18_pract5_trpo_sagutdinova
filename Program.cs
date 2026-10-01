using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sagutdinova_var18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n =Convert.ToInt32(Console.ReadLine());
            Console.Write(n + " ");
            bool Prostoe = false;
            while (!Prostoe)
            {
                Prostoe = n >= 2;
                for(int i =2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Prostoe = false;
                        break;
                    }
                }
                if (Prostoe) break;
                int sum = 0;
                int temp = n;
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                n = sum;
                Console.Write(n + " ");
            }
            
        }
    }
}

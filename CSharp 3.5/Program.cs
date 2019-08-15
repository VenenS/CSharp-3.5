using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharp_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int x = int.Parse(Console.ReadLine());
            Thread fact = new Thread(() => { ThreadFact(x); });
            Thread sum = new Thread(() => { ThreadSum(x); });
            fact.Start();
            sum.Start();
            fact.Join();
            sum.Join();
        }

        static void ThreadFact(int x)
        {
            int factor = 1;
            for (int i = 1; i < x+1; i++)
            {
                factor = factor * i;
            }
            Console.WriteLine(factor);
        }

        static void ThreadSum(int x)
        {
            int sum = 0;
            for (int i = 1; i < x+1; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal
{
    public class Test
    {
        public int Num;
        public string Str;
        //public int Num { get; set; }
        //public string Str { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Test a = new Test() { Num = 1, Str = "Hi" };
            //Test b = new Test() { Num = 1, Str = "Hi" };
            //bool a = true;
            //bool b = false;
            //bool c;
            //(variable ?a: b)=1;
            //Console.WriteLine(c);

            //for (double i = 1.1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            var B = new char[2, 3] { { '1', '2', '3' }, { '4', '5', '6' } };
            char[,] A = new char[2, 3];
            var C = new char[3, 2];
            //B
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int x = 0; x < 3; x++)
                {
                    Console.Write("{0} \t", B[i, x]);
                }
            }
            Console.ReadKey();

            //A
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int x = 0; x < 3; x++)
                {
                    Console.Write("{0} \t", A[i, x]);
                }
            }
            Console.ReadKey();

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int x = 0; x < 3; x++)
                {
                    Console.Write("{0} \t", C[i, x]);
                }
            }
            Console.ReadKey();

            //Char[,] E = new Char[2, 3] { { 'a', 'b', 'c' }, }{ 'a','b','c'} };
            //var D = new char[{{'1', '2','3'},{'4','5','6'}}];

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int [5];
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                a++;
                array[i] = a;
            }

            foreach (int value in array)
            {
                a--;
                array[value] = a;
               
            }
        }
    }
}

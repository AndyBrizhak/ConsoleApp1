using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Col
{
    class Program
    {
        static void Main(string[] args)
        {
            // необобщенная коллекция ArrayList
            //ArrayList objectList = new ArrayList() { 1, 2, "string", 'c', 2.0f };

            //object obj = 45.8;

            //objectList.Add(obj);
            //objectList.Add("string2");

            //foreach (object o in objectList)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("Общее число элементов коллекции: {0}", objectList.Count);
            //Console.ReadKey();
            //objectList.Sort();
            //foreach (object o in objectList)
            //{
            //    Console.WriteLine(o);
            //}

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Displays the values of the ArrayList.
            Console.WriteLine("The ArrayList initially \n contains \t the  \\ following values:");
            PrintValues(myAL);
            Console.ReadKey();
            // Sorts the values of the ArrayList.
            myAL.Sort();
            PrintValues(myAL);
            Console.ReadKey();

            myAL.Add("crocodile");
            PrintValues(myAL);
            Console.ReadKey();

            myAL.Reverse();
            PrintValues(myAL);
            Console.ReadKey();
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();
        }
    }
}

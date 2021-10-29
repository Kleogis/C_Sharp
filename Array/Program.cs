using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            int[] a = new int[5] { 10, 20, 30, 40, 50};


            //display value of each element
            a[0] = 100;

            for(int i = a.Length-1; i>0; i--)
            {
                Console.WriteLine(a[i]);
            }

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            int index = Array.IndexOf(a, 30);

            Console.WriteLine(a[0]);
            Console.ReadKey();

        }
    }
}

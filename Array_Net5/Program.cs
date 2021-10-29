using System;

namespace Array_Net5
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array
            double[] a = new double[5] { 10, 20, 30, 40, 50 };

            //search for 30 in the array
            int n = Array.BinarySearch(a, 30);
            Console.WriteLine("30 second occurrence is found at " + n);

            //search for 30 in the array (second occurrence)
            int n2 = Array.IndexOf(a, 30, 3);
            Console.WriteLine("30 second occurrence is found at " + n2);

            //search for 100 in the array (not exists)
            int n3 = Array.IndexOf(a, 100);
            Console.WriteLine("100 is found at " + n3);


            //Clear Example
            int[] b = new int[] { 100, 20, 300, 40, 5, 60 };

            Array.Clear(b, 0, 3);
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //resize array to 7
            Array.Resize(ref b, 7);
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //sort ascending order
            Array.Sort(b);
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            b[0] = 1;
            b[1] = 2;
            b[2] = 3;

            //reverse the array (it becomes descending order)
            Array.Reverse(b);
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(b[^3]); // Output 3
            //range operator
            int[] result3 = b[2..4]; 
            foreach(int item in result3)
            {
                Console.WriteLine(item);  //3, 5, 0;
            }

            Console.ReadKey();
        }
    }
}

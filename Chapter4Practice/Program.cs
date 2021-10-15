using System;
using System.IO;
using System.Collections.Generic;

namespace Chapter4Practice
{
    public interface ITransformer
    {
        int Transform(int x);
    }
    //delegate int Transformer(int x);
    //public delegate void ProgressReporter(int percentComplete);
    public class Util
    {
        public static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Transform(values[i]);
        }
    }

    public class Squarer : ITransformer 
    {
        public int Transform(int x) => x * x;
    }
    //    public static void HardWork (ProgressReporter p)
    //    {
    //        for (int i = 0; i < 10; i++)
    //        {
    //            p(i * 10);
    //            System.Threading.Thread.Sleep(100);
    //        }
    //    }
    //}
    class Test
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4 };
            Util.TransformAll(values, new Squarer());

            
            foreach (int i in values)
             {
                Console.WriteLine(i);
                WriteProgressToFile(i.ToString());
             }
                

            //Transformer t = Square;
            //int result = t(3);

          //  ProgressReporter p = WriteProgressToConsole;
          //  p += WriteProgressToFile;
          //  Util.HardWork(p);
        }
     //   static void WriteProgressToConsole(int percentComplete) => Console.WriteLine(percentComplete);
        static void WriteProgressToFile(string i) => System.IO.File.AppendAllText("progress.txt", (i.ToString() + Environment.NewLine));
    //    static int Square(int x) => x * x;
        //static void WriteSquare(int x) => System.IO.File.WriteAllLines("progress2.txt", );
    }
}

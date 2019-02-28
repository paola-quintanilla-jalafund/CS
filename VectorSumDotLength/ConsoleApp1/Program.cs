
using System;

namespace ConsoleApp1
{
    class Program
    {
   
        static void Main(string[] args)
        {
            string[] dat = new string[] { "1,4", "1,4" };
            try {
                Vector2D data1 = new Vector2D(dat[0]);
                Vector2D data2 = new Vector2D(dat[1]);
                var resultVector = data1.Sum(data2);
                Console.WriteLine($"ResultSum: {resultVector.ToString()}");
                int resultDot = data1.Dot(data2);
                Console.WriteLine($"ResultDot: {resultDot.ToString()}");
                var resultLength = data1.Length();
                Console.WriteLine($"ResultLength: {resultLength.ToString()}");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
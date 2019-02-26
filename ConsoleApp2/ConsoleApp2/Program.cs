using System;

namespace ConsoleApp2
{
    class Program
    {
        //
        public static int[] Convert(string a)
        {
            string[] b = a.Split(',');
            int[] num = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                num[i] = int.Parse(b[i]);
            }
            return num;

        }

        // utilizar templates

        public static string sum(string[] a)
        {
            // int[] listaEnt;
            // for(int i = 0 ; i < listaEnt.Length ; i++)
            // {

            // }
            int dato1 = 0;
            int dato2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                d += Convert(a[i], 1);
                d2 += Convert(a[i], 2);

            }
            int[] b = Convert(a[0]);//1,2
            int[] c = Convert(a[1]);//
            // int res;
            // for(int i = 0; i < b.Length - 1 ; i++)
            // {
            //     res +=  
            // }
            string d = (b[0] + c[0]).ToString();
            string d2 = (b[1] + c[1]).ToString();
            return "[" + d + "," + d2 + "]";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sum(args));
        }

    }
}
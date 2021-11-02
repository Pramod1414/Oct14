using System;
using System.Collections;

namespace Oct14
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter the number");
            //ArrayList al1 = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{

            //    int x = int.Parse(Console.ReadLine());
            //    al1.Add(x);
            //}
            //al1.Sort();
            //al1.Reverse();
            //Console.WriteLine("sorted list");
            //foreach (object i in al1)
            //{

            //    Console.WriteLine(i);
            //}



            ArrayList al1 = new ArrayList();
            al1.Add(1);
            al1.Add("Ram");
            al1.Add(0.3f);

            ArrayList al = new ArrayList();
            al.Add(3);
            al.Add("Ramesh");
            al.Add(0.5f);
            al.AddRange(al1);

            al.Remove("Ramesh");
            al.RemoveAt(2);

            foreach (object o in al)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();

        }

        
    }
}

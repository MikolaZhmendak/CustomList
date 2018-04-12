using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomList<int> list1 = new MyCustomList<int>();
            list1.Add(12);
            list1.Add(22);
            list1.Add(32);
            MyCustomList<int> list2 = new MyCustomList<int>();
             
            list2.Add(42);
            list2.Add(62);
            list2.Add(72);


            MyCustomList<int> listoneplustwo = new MyCustomList<int>();
            listoneplustwo = list1 + list2;

            foreach ( int number in listoneplustwo)
                Console.WriteLine(number);
            Console.ReadLine();
          
        }
    }
}

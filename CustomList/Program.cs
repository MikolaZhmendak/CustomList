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
            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(12);
            list.Add(22);
            list.Add(32);
            list.Add(42);
            list.Add(62);
            list.Add(72);
            list.Add(82);
            list.Add(92);
            list.Remove(32);
            list.Remove(92);
            foreach ( int number in list)
                Console.WriteLine(number);
            Console.ReadLine();
          
        }
    }
}

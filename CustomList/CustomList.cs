using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyCustomList<T> : IEnumerable<T>
    {
        T[] tempValue;
        int arraySize;
        int count;


        public MyCustomList()
        {
            arraySize = 10;
            tempValue = new T[arraySize];

        }

        public T this[int i]
        {
            get
            {
                return tempValue[i];
            }
            set
            {
                tempValue[i] = value;
            }
        }

        public int ListCount
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }


        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)tempValue).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)tempValue).GetEnumerator();
        }

        public void Add(T input)
        {
            tempValue[count] = input; 
            count++;

        }
    }
}
   




    

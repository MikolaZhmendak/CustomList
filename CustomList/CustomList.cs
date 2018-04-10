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
        T[] temporaryArray;
        int arraySize;
        int count;


        public MyCustomList()
        {
            arraySize = 10;
            temporaryArray = new T[arraySize];

        }

        public T this[int i]
        {
            get
            {
                return temporaryArray[i];
            }
            set
            {
               temporaryArray[i] = value;
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
            return ((IEnumerable<T>)temporaryArray).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)temporaryArray).GetEnumerator();
        }

        public void Add(T input)
        {
            temporaryArray[count] = input;
            count++;

        }
        public bool Remove(T input)
        {

            for (int i = 0; i < count; i++)
            {
                if (temporaryArray[i].Equals(input))
                {
                    count--;
                    temporaryArray[i] = temporaryArray[i + 1];
                 
                    return true;
                }

            }
            return false;


        }

                }

            }
     
    


   




    

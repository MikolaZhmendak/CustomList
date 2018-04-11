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
        T[] resizedArray;
        int index;
        double newCapasityCheck;
        int arraySize;
        int count;


        public MyCustomList()
        {
            arraySize = 5;
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

        public int Count
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
        public int ArraySize
        {
            get
            {
                return arraySize;
            }
            set
            {
                arraySize = value;

            }

        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        public void AddMoreSpaceToArray()
        {
            arraySize = arraySize * 2;
            resizedArray = new T[arraySize];
            for (int i = 0; i <= count - 1; i++)
            {
                resizedArray[i] = temporaryArray[i];
            }

            temporaryArray = resizedArray;
            newCapasityCheck = 0;
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return this[i];
            }
        }

        public void Add(T input)
        {
            if (count == 0)
            {
                index = 0;
                this[index] = input;
            }
            else
            {

                index = count;
                this[index] = input;
            }
            count++;
            newCapasityCheck = ((double)count / arraySize);
            if (newCapasityCheck > .50)
            {
                AddMoreSpaceToArray();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Remove(T input)
        {
            T[] resizedArray = new T[arraySize];
            bool itemReomoved = false;
            for (int i = 0; i <= count; i++)
            {
                if (this[i].Equals(input))
                {
                    count--;
                    resizedArray[i] = temporaryArray[i + 1];
                    itemReomoved = true;

                }
                else if (itemReomoved)
                {
                    resizedArray[i] = temporaryArray[i + 1];
                }
                else
                {
                    resizedArray[i] = temporaryArray[i];
                }

            }

            temporaryArray = resizedArray;
            //int count = 0;
            //T[] resizedArray = new T[temporaryArray.Length-1];
            //for ( int i )

        }

    }

        }
    
     
    


   




    

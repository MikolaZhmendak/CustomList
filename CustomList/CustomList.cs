using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyCustomList<T>
    {
        T[] tempValue;
        int arraySize;
        int count;


        public MyCustomList()
            {
            arraySize = 10;
            tempValue = new T[arraySize];

        //my generic list
        // methods to create here:
        // 1. Write a  method that will store values inside the array;
        // 2. Wtite a method that will add objects in my list;
        // 3. Write a method that will remove objects from my list;
        // 4. Write a method that will add two instances of my custom lits;
        // 5. Write a method that will zip two instances of my custom class. See exapmle in user story.
    }

        //    Define the indexer to allow client code to use[] notation.
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

        public void StoreToList (T input)
        {
            
         


        }
 
    }

}



    

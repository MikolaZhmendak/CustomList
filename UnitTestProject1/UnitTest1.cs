using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Store_Int_PutIntInTheArray()
        {
            //  int expectedValue;
            MyCustomList<int> list = new MyCustomList<int>();
            int value = 1;
            list.StoreToList(value);

            Assert.AreEqual(list[0], value);

         }
            
            
        }
    }


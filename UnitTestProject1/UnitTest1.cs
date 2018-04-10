using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Store_Data_CheckTheCount()
        {

            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int expected = 3;

            int mycount = list.ListCount;

            Assert.AreEqual(expected, mycount);

        }

        [TestMethod]
        public void Store_String_CheckIndex2()
        {
            MyCustomList<string> list = new MyCustomList<string>();
            list.Add("Hello");
            list.Add("Mikola");
            list.Add("Zhmendak");
            string expected = "Zhmendak";

            Assert.AreEqual(expected, list[2]);

        }


        [TestMethod]
        public void Remove_String_CheckIndex4()
        {
            MyCustomList<string> list = new MyCustomList<string>();
            list.Add("Hello");
            list.Add("Mikola");
            list.Add("Zhmendak");
            list.Add("The");
            list.Add("Ukr");
            list.Remove("Mikola");
            string expected = "Hello";

            Assert.AreEqual(expected, list[2]);


        }

        }

}

        
    




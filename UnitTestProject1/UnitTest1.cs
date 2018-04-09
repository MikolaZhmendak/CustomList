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
            string expected = "Mikola";
            int mycount = list.ListCount;
            Assert.AreEqual(expected, mycount);

            // }
            // [TestMethod]
            // public void Store_double_PutdoubleInTheArray()
            // {
            //     //  int expectedValue;
            //     MyCustomList<double> list = new MyCustomList<double>();
            //     double value = 234;
            ////     list.StoreToList(value);

            //     Assert.AreEqual(list[0], value);

        }
        //     [TestMethod]
        //       public void Count_Int_CountIntInTheArray()






    }

}

        
    




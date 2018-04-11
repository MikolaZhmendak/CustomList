using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Int_CheckTheCount()
        {

            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int expected = 3;

            int mycount = list.Count;

            Assert.AreEqual(expected, mycount);

        }

        [TestMethod]
        public void Store_Data_CheckTheCapasity()
        {

            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);


            int extectedArraySize = 10;

            int mycount = list.ArraySize;

            Assert.AreEqual(extectedArraySize, mycount);
        }




        [TestMethod]
        public void Check_Count_EmptyList()
        {

            MyCustomList<int> list = new MyCustomList<int>();

            int mycount = list.Count;



            Assert.AreEqual(mycount, 0);
        }

        [TestMethod]
        public void Check_Value_IndexZeroEmptyList()
        {

            MyCustomList<int> list = new MyCustomList<int>();

            int checkValue = list[0];



            Assert.AreEqual(checkValue, 0);

        }

        [TestMethod]
        public void Check_Value_IndexOfNextItemInListAfterAddingItemInTheList()
        {
            MyCustomList<int> list = new MyCustomList<int>();

            list.Add(5);

            int checkValue = list[1];
            Assert.AreEqual(checkValue, 0);
        }
        [TestMethod]
        public void Add_String_CheckIndex2()
        {
            MyCustomList<string> list = new MyCustomList<string>();
            list.Add("Hello");
            list.Add("Mikola");
            list.Add("Zhmendak");
            string expected = "Zhmendak";

            Assert.AreEqual(expected, list[2]);

        }
        [TestMethod]
        public void Add_String_CheckIfTheValueIsAssignedToCorrectIndex()
        {
            MyCustomList<string> list = new MyCustomList<string>();
            list.Add("Hello");
            list.Add("Mikola");
            list.Add("Zhmendak");
            string expected = "Zhmendak";

            Assert.AreEqual(expected, list[2]);

        }


        [TestMethod]
        public void _Data_Check_Capasity()
        {

            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            int expected = 10;

            int mycount = list.ArraySize;

            Assert.AreEqual(expected, mycount);

        }

        [TestMethod]
        public void Remove_Int_CheckSize()
        {
            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Remove(10);
            int expected = 4;

            int actual = list.Count;

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Remove_Integer_CheckValueIndex2()
        {
            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Remove(30);

            int expected = 40;
            int actual = list[2];

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Remove_Integer_CheckIfIndexHasShifted()
        {
            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Remove(30);

            int expected = 40;
            int actual = list[2];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Integer_CheckIfSizeChangedByRemovingItemsThatAreNotThere()
        {
            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(10);
            list.Add(50);
            list.Remove(60);

            int expected = 5;
            int actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Integer_CheckTheSizeOFTheListIfYouRemoveDuplicated()
        {
            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(10);
            list.Add(50);
            list.Remove(10);

            int expected = 3;
            int actual = list.Count;

            Assert.AreEqual(expected, actual);

        }
    }
}
        
    




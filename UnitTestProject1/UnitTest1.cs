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

        //++++++++++++++++++++++++++++++++ Test overload + operator ++++++++++++++++++++++++++++++++
        [TestMethod]
        public void Add_TwoLists_CheckExpactedCapasity()
        {
            MyCustomList<int> list1 = new MyCustomList<int>();
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);

            MyCustomList<int> list2 = new MyCustomList<int>();
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);

            MyCustomList<int> listOnePlusTwo = new MyCustomList<int>();
            listOnePlusTwo.Add(5);
            listOnePlusTwo.Add(6);
            listOnePlusTwo.Add(7);
            listOnePlusTwo.Add(7);
            listOnePlusTwo.Add(8);
            listOnePlusTwo.Add(9);
            MyCustomList<int> actualCombinedList = new MyCustomList<int>();

         
            int expected = 6;
            actualCombinedList = list1 + list2;

            Assert.AreEqual(expected, actualCombinedList.Count);
        }

        [TestMethod]
        public void Add_TwoLists_CheckIndexValueIndex0()
        {
            MyCustomList<int> list1 = new MyCustomList<int>();
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);

            MyCustomList<int> list2 = new MyCustomList<int>();
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);

            MyCustomList<int> listOnePlusTwo = new MyCustomList<int>();
            listOnePlusTwo.Add(5);
            listOnePlusTwo.Add(6);
            listOnePlusTwo.Add(7);
            listOnePlusTwo.Add(7);
            listOnePlusTwo.Add(8);
            listOnePlusTwo.Add(9);

            MyCustomList<int> actualCombinedList = new MyCustomList<int>();

            int expected = 5;
            actualCombinedList = list1 + list2;

            Assert.AreEqual(expected, actualCombinedList[0]);
        }
        [TestMethod]
        public void Add_TwoLists_CheckIndexValueIndex3()
        {
            MyCustomList<int> list1 = new MyCustomList<int>();
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);

            MyCustomList<int> list2 = new MyCustomList<int>();
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);

            MyCustomList<int> listOnePlusTwo = new MyCustomList<int>();
            listOnePlusTwo.Add(5);
            listOnePlusTwo.Add(6);
            listOnePlusTwo.Add(7);
            listOnePlusTwo.Add(7);
            listOnePlusTwo.Add(8);
            listOnePlusTwo.Add(9);

            MyCustomList<int> actualCombinedList = new MyCustomList<int>();

            actualCombinedList = list1 + list2;

            int expected = 7;
            

            Assert.AreEqual(expected, actualCombinedList[3]);
        }
        [TestMethod]
        public void Add_TwoLists_CheckLastItmemIndex()
        {
            MyCustomList<int> list1 = new MyCustomList<int>();
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);

            MyCustomList<int> list2 = new MyCustomList<int>();
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);

            MyCustomList<int> listOnePlusTwo = new MyCustomList<int>();
            listOnePlusTwo.Add(5);
            listOnePlusTwo.Add(6);
            listOnePlusTwo.Add(7);
            listOnePlusTwo.Add(7);
            listOnePlusTwo.Add(8);
            listOnePlusTwo.Add(9);

            MyCustomList<int> actualCombinedList = new MyCustomList<int>();

            actualCombinedList = list1 + list2;
            int expected = 9;

            Assert.AreEqual(expected, actualCombinedList[5]);
        }
    }
}

        
    




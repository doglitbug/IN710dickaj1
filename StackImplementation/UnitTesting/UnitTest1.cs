using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        //////Test Push Method
        [TestMethod]
        public void Push_OneItemOnNewStackCallPeek_ReturnItem()
        {
            Stack target = new Stack();
            String testItem = "MyApplesAreBad";

            target.Push(testItem);

            String expected = testItem;
            String actual = target.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Push_OneItemOnAlargeStackCallPeek_ReturnItem()
        {
            Stack target = new Stack();
            String testItem = "MyApplesAreBad";

            target.Push("a");
            target.Push("b");
            target.Push("c");
            target.Push("d");

            target.Push(testItem);

            String expected = testItem;
            String actual = target.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Push_SeveralItemsStackCallCount_ReturnItemCount()
        {
            Stack target = new Stack();

            target.Push("a");
            target.Push("b");
            target.Push("c");
            target.Push("d");

            int expected = 4;
            int actual = target.Count();

            Assert.AreEqual(expected, actual);
        }

        //////Test Pop Method

        //////Test Peek Method 

        //////Test Count Method
        [TestMethod]
        public void Count_CalledOnNewStack_ReturnZero()
        {
            Stack target = new Stack();

            int expected = 0;
            int actual = target.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_PushSeveralPopAll_ReturnZero()
        {
            Stack target = new Stack();
            //Push several items
            target.Push("a");
            target.Push("b");
            target.Push("c");
            target.Push("d");
            target.Push("e");
            target.Push("f");
            target.Push("g");

            //Pop all items
            target.Pop();
            target.Pop();
            target.Pop();
            target.Pop();
            target.Pop();
            target.Pop();
            target.Pop();

            int expected = 0;
            int actual = target.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_PushOneItem_ReturnOne()
        {
            Stack target = new Stack();

            target.Push("a");

            int expected = 1;
            int actual = target.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_PushSevenItems_ReturnSeven()
        {
            Stack target = new Stack();

            target.Push("a");
            target.Push("b");
            target.Push("c");
            target.Push("d");
            target.Push("e");
            target.Push("f");
            target.Push("g");

            int expected = 7;
            int actual = target.Count();

            Assert.AreEqual(expected,actual);
        }

        ///////Test IsEmpty Method
        [TestMethod]
        public void IsEmpty_CalledOnNewStack_ReturnTrue() {
            Stack target = new Stack();

            Boolean expected = true;
            Boolean actual = target.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_PushSeveralAndPopAll_ReturnTrue() {
            Stack target = new Stack();
            //Push several items
            target.Push("a");
            target.Push("b");
            target.Push("c");
            target.Push("d");
            target.Push("e");
            target.Push("f");
            target.Push("g");

            //Pop all items
            target.Pop();
            target.Pop();
            target.Pop();
            target.Pop();
            target.Pop();
            target.Pop();
            target.Pop();

            Boolean expected = true;
            Boolean actual = target.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_CalledOnNonEmptyStack_ReturnFalse() {
            Stack target = new Stack();
            //Push several items
            target.Push("a");
            target.Push("b");
            target.Push("c");
            target.Push("d");
            target.Push("e");
            target.Push("f");
            target.Push("g");

            Boolean expected = false;
            Boolean actual = target.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_CalledOnStackWithOneItem_ReturnFalse() {
            Stack target = new Stack();

            target.Push("a");

            Boolean expected = false;
            Boolean actual = target.IsEmpty();

            Assert.AreEqual(expected, actual);
        }   
    }
}

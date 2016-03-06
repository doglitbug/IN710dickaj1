using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
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

        ///////IsEmpty Method
        [TestMethod]
        public void IsEmpty_CalledOnNewStack_ReturnTrue() { }

        [TestMethod]
        public void IsEmpty_PushSeveralAndPopAll_ReturnTrue() { }

        [TestMethod]
        public void IsEmpty_CalledOnNonEmptyStack_ReturnFalse() { }

        [TestMethod]
        public void IsEmpty_CalledOnStackWithOneItem_ReturnFalse() { }
    }
}

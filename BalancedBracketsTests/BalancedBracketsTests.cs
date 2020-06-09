using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));

        }

        [TestMethod]
        
        public void BracketsWithChar()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Hello]"));
        }

        [TestMethod]
        
        public void SingleRightBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Hello"));
        }

        [TestMethod]
        
        public void PositiveRightBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Hello[World]"));
        }

        [TestMethod]
       
        public void SingleLeftBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Hello]"));
        }

        [TestMethod]
        
        public void NegitiveBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Hello] world]"));
        }

        [TestMethod]
        public void DoubleBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

        [TestMethod]
        public void DoubleBracketWithChar()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]Hello![]"));
        }

        [TestMethod]
       
        public void TestFilppedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]Hello["));
        }

        [TestMethod]
        
        public void TestNests()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[stri[ng]test]"));
        }

        [TestMethod]

        public void TestBackwardNests()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]stri]ng[test["));
        }









        //[TestMethod]
        //public void PositiveBrackets()
        //{
        //    Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Hello[World]"), "You Have too many right facing brackets '['....");
        //}

        //[TestMethod]
        //public void PositiveBrackets()
        //{
        //    Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Hello[World]"), "You Have too many right facing brackets '['....");
        //}

        //[TestMethod]
        //public void PositiveBrackets()
        //{
        //    Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Hello[World]"), "You Have too many right facing brackets '['....");
        //}

        //[TestMethod]
        //public void PositiveBrackets()
        //{
        //    Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Hello[World]"), "You Have too many right facing brackets '['....");
        //}




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveDuplicates;
namespace RemoveDuplicatesUnitTestProject
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void RemoveDuplicatesMethodFirstTest()
        {
            var actualValue = Program.RemoveDuplicatesMethodFirst(new int[] {1, 2, 2, 3, 4, 5, 5, 6});
            var expectedValue = new List<int> { 1, 2, 3, 4, 5, 6 };
            Assert.IsTrue(actualValue.SequenceEqual(expectedValue));
        }

        [TestMethod]
        public void RemoveDuplicatesMethodSecondTest()
        {
            var actualValue = Program.RemoveDuplicatesMethodSecond(new int[] { 1, 2, 2, 3, 4, 5, 5, 6 });
            var expectedValue = new List<int> { 1, 2, 3, 4, 5, 6 };
            Assert.IsTrue(actualValue.SequenceEqual(expectedValue));
        }

        [TestMethod]
        public void RemoveDuplicatesMethodThirdTest()
        {
            var actualValue = Program.RemoveDuplicatesMethodThird(new int[] { 1, 2, 2, 3, 4, 5, 5, 6 });
            var expectedValue = new List<int> { 1, 2, 3, 4,  5, 6 };
            Assert.IsTrue(actualValue.SequenceEqual(expectedValue));
        }
    }
}

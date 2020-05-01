using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDDTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var val = TDDLesson.UI.Calculation.Sum(2, 5);
            Assert.AreEqual(7, val);
        }

        [TestMethod]        
        public void 平均値を求める()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var result = TDDLesson.UI.Calculation.Ave(list);
            Assert.AreEqual(3, result);
        }
    }
}

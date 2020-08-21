using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort_Array;

namespace SortArrayTests
{
    [TestClass]
    public class SortArrTests
    {
        [TestMethod]
        public void Success()
        {
            char[] array = { 'с', 'с', 'з', 'с', 'к', 'з', 'з', 'з', 'к', 'к', 'с', 'з', 'с', 'с', 'к', 'з' };
            char[] sort_array = { 'з', 'з', 'з', 'з', 'з', 'з', 'с', 'с', 'с', 'с', 'с', 'с', 'к', 'к', 'к', 'к' };
            char[] actual = SortArray.Sort(array);
            for (int i = 0; i < sort_array.Length; i++)
            {
                Assert.AreEqual(sort_array[i], actual[i]);
            }
                
        }
    }
}

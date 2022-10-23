using TDD02;

namespace TDD02TestsMsTest
{
    [TestClass]
    public class ToolsTests
    {
        [TestMethod]
        public void GetIndexOfElementInAStringArrayReturnsExpectedIndex()
        {
            string[] strArray = { "ta", "to", "ti", "tp" };
            var index = Tools.GetIndexOfElementInArray(strArray, "to");
            var index2 = Tools.GetIndexOfElementInArray(strArray, "tp");
            Assert.AreEqual(1, index);
            Assert.AreEqual(3, index2);
        }

        [TestMethod]
        public void GetIndexOfElementInIntArrayReturnsExpectedIndex()
        {
            int[] intArray = { 2, 5, 6, 7};
            var index = Tools.GetIndexOfElementInArray(intArray, 5);
            var index2 = Tools.GetIndexOfElementInArray(intArray, 2);
            Assert.AreEqual(1, index);
            Assert.AreEqual(0, index2);
        }
    }
}
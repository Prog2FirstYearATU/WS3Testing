namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {

        private const string Expected = "Hello, World!";

        [TestMethod]
        public void TestMethod1()
        {
            using (StringWriter sw = new StringWriter())
            {

                Console.SetOut(sw);
                WS3Testing.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestGetLargestValue1()
        {
            Assert.AreEqual(90, WS3Code.Program.GetLargestValue([90]));
        }
        [TestMethod]
        public void TestGetLargestValue2()
        {
            Assert.AreEqual(0, WS3Code.Program.GetLargestValue([]));

        }
        [TestMethod]
        public void TestGetLargestValue3()
        {
            Assert.AreEqual(3,WS3Code.Program.GetLargestValue([1, 2, 3]));
        }
        [TestMethod]
        public void TestGetLargestValue4()
        {
            Assert.AreEqual(-1,WS3Code.Program.GetLargestValue([-1, -2, -3]));
        }
        [TestMethod]
        public void TestGetLargestValue5()
        {
            Assert.AreEqual(11, WS3Code.Program.GetLargestValue([11, -2, -3]));
        }
        [TestMethod]
        public void TestGetLargestValue()
        {

            Assert.AreEqual(89, WS3Code.Program.GetLargestValue([11, -2, -3,56,89,65,56,34]));
        }

        [TestMethod]
        public void TestGetSmallestValue1()
        {
            Assert.AreEqual(90,WS3Code.Program.GetSmallestValue([90]));
        }
        [TestMethod]
        public void TestGetSmallestValue2()
        {
            Assert.AreEqual(0,WS3Code.Program.GetSmallestValue([]));

        }
        [TestMethod]
        public void TestGetSmallestValue3()
        {
            Assert.AreEqual(1,WS3Code.Program.GetSmallestValue([1, 2, 3]));
        }
        [TestMethod]
        public void TestGetSmallestValue4()
        {
            Assert.AreEqual(WS3Code.Program.GetSmallestValue([-1, -2, -3]), -3);
        }
        [TestMethod]
        public void TestGetSmallestValue5()
        {
            Assert.AreEqual(-3,WS3Code.Program.GetSmallestValue([11, -2, -3]));
        }
        [TestMethod]
        public void TestGetSmallestValue6()
        {

            Assert.AreEqual(-3,WS3Code.Program.GetSmallestValue([11, -2, -3, 56, 89, 65, 56, 34]));
        }

        [TestMethod]
        public void IsAscending1()
        {

            Assert.AreEqual(true,WS3Code.Program.IsAscending([]));
        }

        [TestMethod]
        public void IsAscending2()
        {

            Assert.AreEqual(false,WS3Code.Program.IsAscending([11, -2, -3, 56, 89, 65, 56, 34]));
        }

        [TestMethod]
        public void IsAscending3()
        {

            Assert.AreEqual(true,WS3Code.Program.IsAscending([-90]));
        }

        [TestMethod]
        public void IsAscending4()
        {

            Assert.AreEqual(true,WS3Code.Program.IsAscending([-90,7,56,456]));
        }

        [TestMethod]
        public void IsAscending5()
        {

            Assert.AreEqual(false, WS3Code.Program.IsAscending([-90, 7, 56, 55, 456]));
        }

        [TestMethod]
        public void MoveLargestToLast()
        {
            int[] test1 = [-90, 7, 56, 55, 456];
            int[] expected = [-90, 7, 56, 55, 456];
            WS3Code.Program.MoveLargestToLast(test1);

            CollectionAssert.AreEqual(expected, test1);
        }

        [TestMethod]
        public void MoveLargestToLast2()
        {
            int[] test1 = [456];
            int[] expected = [456];
            WS3Code.Program.MoveLargestToLast(test1);

            CollectionAssert.AreEqual(expected, test1);
        }

        [TestMethod]
        public void MoveLargestToLast3()
        {
            int[] test1 = [];
            int[] expected = [];
            WS3Code.Program.MoveLargestToLast(test1);

            CollectionAssert.AreEqual(expected, test1);
        }

        [TestMethod]
        public void MoveLargestToLast4()
        {
            int[] test1 = [67,45,64,34,456,45];
            int[] expected = [67, 45, 64, 34, 45, 456];
            WS3Code.Program.MoveLargestToLast(test1);

            CollectionAssert.AreEqual(expected, test1);
        }

        [TestMethod]
        public void MoveLargestToLast5()
        {
            int[] test1 = [900, 7, 56, 55, 456];
            int[] expected = [7, 56, 55, 456, 900];
            WS3Code.Program.MoveLargestToLast(test1);

            CollectionAssert.AreEqual(expected, test1);
        }

        [TestMethod]
        public void MoveLargestToLast6()
        {
            int[] test1 = [900, 7, 900, 55, 456];
            WS3Code.Program.MoveLargestToLast(test1);
            int[] expected = [900, 7, 55, 456, 900];

            CollectionAssert.AreEqual(expected, test1);
        }


    }


}

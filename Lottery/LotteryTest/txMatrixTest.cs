using Lottery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LotteryTest
{
    
    
    /// <summary>
    ///This is a test class for txMatrixTest and is intended
    ///to contain all txMatrixTest Unit Tests
    ///</summary>
    [TestClass()]
    public class txMatrixTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest()
        {
            txMatrix2 m = new txMatrix2(); // TODO: Initialize to an appropriate value
            m.m00 = 1.0;
            m.m01 = 2.0;
            m.m10 = 3.0;
            m.m11 = 4.0;
            txVector2 v = new txVector2(); // TODO: Initialize to an appropriate value
            v.x = 1.0;
            v.y = 2.0;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = 5.0;
            expected.y = 11.0;
            txVector2 actual;
            actual = (m * v);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

using Lottery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LotteryTest
{
    
    
    /// <summary>
    ///This is a test class for txMatrix2Test and is intended
    ///to contain all txMatrix2Test Unit Tests
    ///</summary>
    [TestClass()]
    public class txMatrix2Test
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
        ///A test for Scale
        ///</summary>
        [TestMethod()]
        public void ScaleTest()
        {
            txMatrix2 target = new txMatrix2(); // TODO: Initialize to an appropriate value
            target.m00 = 1.0;
            target.m01 = 4.0;
            target.m10 = 5.0;
            target.m11 = 6.0;
            double s = 0F; // TODO: Initialize to an appropriate value
            s = 3.0;
            txMatrix2 expected = new txMatrix2(); // TODO: Initialize to an appropriate value
            expected.m00 = 3.0;
            expected.m01 = 4.0;
            expected.m10 = 5.0;
            expected.m11 = 18.0;
            txMatrix2 actual;
            actual = target.Scale(s);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for txMatrix2 Constructor
        ///</summary>
        [TestMethod()]
        public void txMatrix2ConstructorTest()
        {
            double m00_ = 0F; // TODO: Initialize to an appropriate value
            double m01_ = 0F; // TODO: Initialize to an appropriate value
            double m10_ = 0F; // TODO: Initialize to an appropriate value
            double m11_ = 0F; // TODO: Initialize to an appropriate value
            txMatrix2 target = new txMatrix2(m00_, m01_, m10_, m11_);
            Assert.AreEqual(target.m00, m00_);
            Assert.AreEqual(target.m01, m01_);
            Assert.AreEqual(target.m10, m10_);
            Assert.AreEqual(target.m11, m11_);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for txMatrix2 Constructor
        ///</summary>
        [TestMethod()]
        public void txMatrix2ConstructorTest1()
        {
            double theta = 0F; // TODO: Initialize to an appropriate value
            theta = Math.PI;
            txMatrix2 target = new txMatrix2(theta);
            Assert.AreEqual(target.m00, -1.0);
            Assert.IsTrue(Math.Abs(target.m01) < txVector2.VECTOR_PRECISION);
            Assert.IsTrue(Math.Abs(target.m01)<txVector2.VECTOR_PRECISION);
            Assert.IsTrue(Math.Abs(target.m10) < txVector2.VECTOR_PRECISION);
            Assert.IsTrue(Math.Abs(target.m10)<txVector2.VECTOR_PRECISION);
            Assert.IsTrue(Math.Abs(target.m11+1.0)<txVector2.VECTOR_PRECISION);

            double theata2 = Math.PI / 3.0;
            double cos2 = Math.Cos(theata2);
            double sin2 = Math.Sin(theata2);
            txMatrix2 target2 = new txMatrix2(theata2);
            Assert.IsTrue(Math.Abs(cos2 - target2.m00) < txVector2.VECTOR_PRECISION);
            Assert.IsTrue(Math.Abs(sin2 + target2.m01) < txVector2.VECTOR_PRECISION);
            Assert.IsTrue(Math.Abs(sin2 - target2.m10) < txVector2.VECTOR_PRECISION);
            Assert.IsTrue(Math.Abs(cos2 - target2.m11) < txVector2.VECTOR_PRECISION);
            //Assert.IsTrue(false);
            // Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for YImageOperation
        ///</summary>
        [TestMethod()]
        public void YImageOperationTest()
        {
            txMatrix2 expected = new txMatrix2(); // TODO: Initialize to an appropriate value
            expected.m00 = 1.0;
            expected.m01 = 0.0;
            expected.m10 = 0.0;
            expected.m11 = -1.0;
            txMatrix2 actual;
            actual = txMatrix2.YImageOperation();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

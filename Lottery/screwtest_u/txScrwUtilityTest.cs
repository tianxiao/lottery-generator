using screwtest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using txGeometry;

namespace screwtest_u
{
    
    
    /// <summary>
    ///This is a test class for txScrwUtilityTest and is intended
    ///to contain all txScrwUtilityTest Unit Tests
    ///</summary>
    [TestClass()]
    public class txScrwUtilityTest
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
        ///A test for Domain0
        ///</summary>
        [TestMethod()]
        public void Domain0Test()
        {
            double r = 10F; // TODO: Initialize to an appropriate value
            double theta = 0F; // TODO: Initialize to an appropriate value
            txMatrix2 m = new txMatrix2(); // TODO: Initialize to an appropriate value
            m = txMatrix2.Identity();
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = r;
            expected.y = 0;
            txVector2 actual;
            actual = txScrwUtility.Domain0(r, theta, m);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

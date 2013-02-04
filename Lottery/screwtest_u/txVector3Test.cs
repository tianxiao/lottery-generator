using utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace screwtest_u
{
    
    
    /// <summary>
    ///This is a test class for txVector3Test and is intended
    ///to contain all txVector3Test Unit Tests
    ///</summary>
    [TestClass()]
    public class txVector3Test
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
        ///A test for txVector3 Constructor
        ///</summary>
        [TestMethod()]
        public void txVector3ConstructorTest()
        {
            double x_ = 0F; // TODO: Initialize to an appropriate value
            double y_ = 0F; // TODO: Initialize to an appropriate value
            double z_ = 0F; // TODO: Initialize to an appropriate value
            txVector3 target = new txVector3(x_, y_, z_);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}

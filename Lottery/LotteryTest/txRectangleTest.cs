using Lottery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LotteryTest
{
    
    
    /// <summary>
    ///This is a test class for txRectangleTest and is intended
    ///to contain all txRectangleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class txRectangleTest
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
        ///A test for txRectangle Constructor
        ///</summary>
        [TestMethod()]
        public void txRectangleConstructorTest()
        {
            const double Length = 10.0;
            txVector2 v0_ = new txVector2(); // TODO: Initialize to an appropriate value
            v0_.x = -Length;
            v0_.y = -Length;
            txVector2 v1_ = new txVector2(); // TODO: Initialize to an appropriate value
            v1_.x = Length;
            v1_.y = -Length;
            txVector2 v2_ = new txVector2(); // TODO: Initialize to an appropriate value
            v2_.x = Length;
            v2_.y = Length;
            txVector2 v3_ = new txVector2(); // TODO: Initialize to an appropriate value
            v3_.x = -Length;
            v3_.y = Length;
            double omega_ = 0F; // TODO: Initialize to an appropriate value
            omega_ = Math.PI;
            txRectangle target = new txRectangle(v0_, v1_, v2_, v3_, omega_);
            Assert.AreEqual(target.LeftBottomV, v0_);
            Assert.AreEqual(target.RightBottomV, v1_);
            Assert.AreEqual(target.RightTopV, v2_);
            Assert.AreEqual(target.LeftTopV, v3_);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AssemblyLineSegmentList
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Lottery.exe")]
        public void AssemblyLineSegmentListTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            txRectangle_Accessor target = new txRectangle_Accessor(param0); // TODO: Initialize to an appropriate value
            target.AssemblyLineSegmentList();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Rotate
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Lottery.exe")]
        public void RotateTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            txRectangle_Accessor target = new txRectangle_Accessor(param0); // TODO: Initialize to an appropriate value
            double t = 0F; // TODO: Initialize to an appropriate value
            target.Rotate(t);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Tick
        ///</summary>
        [TestMethod()]
        public void TickTest()
        {
            const double Length = 10.0;
            txVector2 v0_ = new txVector2(); // TODO: Initialize to an appropriate value
            v0_.x = -Length;
            v0_.y = -Length;
            txVector2 v1_ = new txVector2(); // TODO: Initialize to an appropriate value
            v1_.x = Length;
            v1_.y = -Length;
            txVector2 v2_ = new txVector2(); // TODO: Initialize to an appropriate value
            v2_.x = Length;
            v2_.y = Length;
            txVector2 v3_ = new txVector2(); // TODO: Initialize to an appropriate value
            v3_.x = -Length;
            v3_.y = Length;

            double omega = Math.PI / 60.0;
            txRectangle target = new txRectangle(v0_, v1_, v2_, v3_, omega); // TODO: Initialize to an appropriate value
            double t = 0F; // TODO: Initialize to an appropriate value
            t = 60.0;
            target.Tick(t);

            Assert.IsTrue(target.LeftBottomV == v2_);
            Assert.IsTrue(target.RightBottomV == v3_);
            Assert.IsTrue(target.RightTopV == v0_);
            Assert.IsTrue(target.LeftTopV == v1_);
            
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}

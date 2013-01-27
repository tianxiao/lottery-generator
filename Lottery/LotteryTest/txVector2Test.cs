using Lottery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LotteryTest
{
    
    
    /// <summary>
    ///This is a test class for txVector2Test and is intended
    ///to contain all txVector2Test Unit Tests
    ///</summary>
    [TestClass()]
    public class txVector2Test
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
        ///A test for op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest()
        {
            txVector2 l = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 10;
            l.y = 5;
            txVector2 r = new txVector2(); // TODO: Initialize to an appropriate value
            r.x = 20;
            r.y = 20;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = 30;
            expected.y = 25;
            txVector2 actual;
            actual = (l + r);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest()
        {
            txVector2 v = new txVector2(); // TODO: Initialize to an appropriate value
            v.x = 1.0;
            v.y = 2.0;
            double a = 3.0; // TODO: Initialize to an appropriate value
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = 3.0;
            expected.y = 6.0;
            txVector2 actual;
            actual = (v * a);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest1()
        {
            txVector2 l = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 1.0;
            l.y = 2.0;
            txVector2 r = new txVector2(); // TODO: Initialize to an appropriate value
            r.x = 3.0;
            r.y = 4.0;
            double expected = 0F; // TODO: Initialize to an appropriate value
            expected = 11.0;
            double actual;
            actual = (l * r);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest2()
        {
            double a = 0F; // TODO: Initialize to an appropriate value
            a = 3.0;
            txVector2 v = new txVector2(); // TODO: Initialize to an appropriate value
            v.x = 3.0;
            v.y = 4.0;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = 9.0;
            expected.y = 12.0;
            txVector2 actual;
            actual = (a * v);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest()
        {
            txVector2 l = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 10.0;
            l.y = 3.0;
            txVector2 r = new txVector2(); // TODO: Initialize to an appropriate value
            r.x = 11.0;
            r.y = 0.0;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = -1.0;
            expected.y = 3.0;
            txVector2 actual;
            actual = (l - r);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }



        /// <summary>
        ///A test for txVector2 Constructor
        ///</summary>
        [TestMethod()]
        public void txVector2ConstructorTest()
        {
            double x_ = 0F; // TODO: Initialize to an appropriate value
            double y_ = 0F; // TODO: Initialize to an appropriate value
            txVector2 target = new txVector2(x_, y_);
            txVector2 expected;
            expected.x = 0.0;
            expected.y = 0.0;
            Assert.AreEqual(target, expected);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Distance
        ///</summary>
        [TestMethod()]
        public void DistanceTest()
        {
            txVector2 target = new txVector2(); // TODO: Initialize to an appropriate value
            target.x = 3.0;
            target.y = 4.0;
            txVector2 v_ = new txVector2(); // TODO: Initialize to an appropriate value
            v_.x = 0.0;
            v_.y = 0.0;
            double expected = 0F; // TODO: Initialize to an appropriate value
            expected = 5.0;
            double actual;
            actual = target.Distance(v_);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Length
        ///</summary>
        [TestMethod()]
        public void LengthTest()
        {
            txVector2 target = new txVector2(); // TODO: Initialize to an appropriate value
            target.x = 3.0;
            target.y = 4.0;
            double expected = 0F; // TODO: Initialize to an appropriate value
            expected = 5.0;
            double actual;
            actual = target.Length();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Normalize
        ///</summary>
        [TestMethod()]
        public void NormalizeTest()
        {
            txVector2 target = new txVector2(); // TODO: Initialize to an appropriate value
            //target.x = 5;
            //target.y = 12;
            target.x = 3;
            target.y = 4;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = .6;
            expected.y = .8;
            txVector2 actual;
            actual = target.Normalize();
            double deltax = Math.Abs(expected.x - actual.x);
            double deltay = Math.Abs(expected.y - actual.y);

            Assert.IsTrue(deltax < txVector2.VECTOR_PRECISION);
            Assert.IsTrue(deltay < txVector2.VECTOR_PRECISION);
            ///??????
            /// Why here the expected and actual don't equal???
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PointOrientationTest
        ///</summary>
        [TestMethod()]
        public void PointOrientationTestTest()
        {
            TestOrientationCaseLeft();
            TestOrientationCaseRight();
            TestOrientationCaseCollinear();
            //Assert.Inconclusive("Verify the correctness of this test method.");

        }

        private void TestOrientationCaseCollinear()
        {
            txVector2 pa = new txVector2(); // TODO: Initialize to an appropriate value
            pa.x = 0.0;
            pa.y = 0.0;
            txVector2 pb = new txVector2(); // TODO: Initialize to an appropriate value
            pb.x = 2.0;
            pb.y = 2.0;
            txVector2 pc = new txVector2(); // TODO: Initialize to an appropriate value
            pc.x = 2.0;
            pc.y = 0.0;
            txOrientationState expected = new txOrientationState(); // TODO: Initialize to an appropriate value
            expected = txOrientationState.RIGHT;
            txOrientationState actual;
            actual = txVector2.PointOrientationTest(pa, pb, pc);
            Assert.AreEqual(expected, actual);
        }

        private void TestOrientationCaseRight()
        {
            txVector2 pa = new txVector2(); // TODO: Initialize to an appropriate value
            pa.x = 0.0;
            pa.y = 0.0;
            txVector2 pb = new txVector2(); // TODO: Initialize to an appropriate value
            pb.x = 2.0;
            pb.y = 2.0;
            txVector2 pc = new txVector2(); // TODO: Initialize to an appropriate value
            pc.x = 1.0;
            pc.y = 1.0;
            txOrientationState expected = new txOrientationState(); // TODO: Initialize to an appropriate value
            expected = txOrientationState.COLLINEAR;
            txOrientationState actual;
            actual = txVector2.PointOrientationTest(pa, pb, pc);
            Assert.AreEqual(expected, actual);
        }

        private static void TestOrientationCaseLeft()
        {
            txVector2 pa = new txVector2(); // TODO: Initialize to an appropriate value
            pa.x = 0.0;
            pa.y = 0.0;
            txVector2 pb = new txVector2(); // TODO: Initialize to an appropriate value
            pb.x = 2.0;
            pb.y = 2.0;
            txVector2 pc = new txVector2(); // TODO: Initialize to an appropriate value
            pc.x = 0.0;
            pc.y = 2.0;
            txOrientationState expected = new txOrientationState(); // TODO: Initialize to an appropriate value
            expected = txOrientationState.LEFT;
            txOrientationState actual;
            actual = txVector2.PointOrientationTest(pa, pb, pc);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SquareDistance
        ///</summary>
        [TestMethod()]
        public void SquareDistanceTest()
        {
            txVector2 target = new txVector2(); // TODO: Initialize to an appropriate value
            target.x = 3.0;
            target.y = 4.0;
            txVector2 v_ = new txVector2(); // TODO: Initialize to an appropriate value
            v_.x = 6.0;
            v_.y = 8.0;
            double expected = 0F; // TODO: Initialize to an appropriate value
            expected = 25.0;
            double actual;
            actual = target.SquareDistance(v_);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SquareLength
        ///</summary>
        [TestMethod()]
        public void SquareLengthTest()
        {
            txVector2 target = new txVector2(); // TODO: Initialize to an appropriate value
            target.x = 3.0;
            target.y = 4.0;
            double expected = 0F; // TODO: Initialize to an appropriate value
            expected = 25.0;
            double actual;
            actual = target.SquareLength();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Zero
        ///</summary>
        [TestMethod()]
        public void ZeroTest()
        {
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = 0.0;
            expected.y = 0.0;
            txVector2 actual;
            actual = txVector2.Zero();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest1()
        {
            txVector2 l = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 1.0;
            l.y = 2.0;
            txVector2 r = new txVector2(); // TODO: Initialize to an appropriate value
            r.x = 2.0;
            r.y = 3.0;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = 3.0;
            expected.y = 5.0;
            txVector2 actual;
            actual = (l + r);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Equality
        ///</summary>
        [TestMethod()]
        public void op_EqualityTest()
        {
            txVector2 l = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 0.0;
            l.y = 0.0;
            txVector2 r = new txVector2(); // TODO: Initialize to an appropriate value
            r.x = 0.0;
            r.y = 0.0;
            bool expected = false; // TODO: Initialize to an appropriate value
            expected = true;
            bool actual;
            actual = (l == r);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Inequality
        ///</summary>
        [TestMethod()]
        public void op_InequalityTest()
        {
            txVector2 l = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 0.0;
            l.y = 1.0;
            txVector2 r = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 0.0;
            l.y = 1.0000000000000000000009;
            bool expected = false; // TODO: Initialize to an appropriate value
            expected = false;
            bool actual;
            actual = (l != r);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest3()
        {
            txVector2 l = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 0.0;
            l.y = 3.0;
            txVector2 r = new txVector2(); // TODO: Initialize to an appropriate value
            r.x = 0.0;
            r.y = 4.0;
            double expected = 0F; // TODO: Initialize to an appropriate value
            expected = 12.0;
            double actual;
            actual = (l * r);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest4()
        {
            txVector2 v = new txVector2(); // TODO: Initialize to an appropriate value
            v.x = 1.0;
            v.y = 3.0;
            double a = 0F; // TODO: Initialize to an appropriate value
            a = 4.0;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = 4.0;
            expected.y = 12.0;
            txVector2 actual;
            actual = (v * a);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest5()
        {
            double a = 0F; // TODO: Initialize to an appropriate value
            txVector2 v = new txVector2(); // TODO: Initialize to an appropriate value
            v.x = 4.0;
            v.y = 5.0;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = 0.0;
            expected.y = 0.0;
            txVector2 actual;
            actual = (a * v);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest1()
        {
            txVector2 l = new txVector2(); // TODO: Initialize to an appropriate value
            l.x = 0.0;
            l.y = .0;
            txVector2 r = new txVector2(); // TODO: Initialize to an appropriate value
            r.x = 10.0;
            r.y = 11.0;
            txVector2 expected = new txVector2(); // TODO: Initialize to an appropriate value
            expected.x = -10.0;
            expected.y = -11.0;
            txVector2 actual;
            actual = (l - r);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

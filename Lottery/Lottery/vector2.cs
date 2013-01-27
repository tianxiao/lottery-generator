using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    public enum txOrientationState { 
        LEFT,
        RIGHT,
        COLLINEAR
    }

    
    public struct txVector2
    {
        // when we do the sqrt we got this answer
        //sqrt(3.0*3.0+4.0*4.0) = 4.9999999......?
        // then the normalized (3.0.4.0);
        // will be (0.6000000000000000009, 0.8)
        // So must be a precision to eliminate this error!
        public static double VECTOR_PRECISION = 1.0e-14;

        public double x;
        public double y;

        public txVector2(double x_, double y_ ) {
            x = x_;
            y = y_;
        }

        public static txVector2 operator *(txVector2 v, double a)
        {
            txVector2 rtn;
            rtn.x = a * v.x;
            rtn.y = a * v.y;
            return rtn;
        }

        public static txVector2 operator *(double a, txVector2 v)
        {
            txVector2 rtn;
            rtn.x = a * v.x;
            rtn.y = a * v.y;
            return rtn;
        }

        public static txVector2 operator + (txVector2 l, txVector2 r) {
            txVector2 rtn;
            rtn.x = l.x + r.x;
            rtn.y = l.y + r.y;
            return rtn;
        }

        public static txVector2 operator -(txVector2 l, txVector2 r) {
            txVector2 rtn;
            rtn.x = l.x - r.x;
            rtn.y = l.y - r.y;
            return rtn;
        }

        //public txVector2 CrossProduct(txVector2 r)
        //{ 
            
        //}

        public static double operator *(txVector2 l, txVector2 r)
        {
            return l.x * r.x + l.y * r.y;
        }

        public txVector2 Normalize() {
            return 1.0 / Length() * this;
        }

        //public static void operator += (txVector2 r) {
        //    this = this + r;
        //}

        public double SquareDistance(txVector2 v_)
        {
            double xl = x-v_.x;
            double yl = y-v_.y;
            return xl * xl + yl * yl;
        }

        public double Distance(txVector2 v_)
        {
            return Math.Sqrt(SquareDistance(v_));
        }

        public double Length()
        {
            return Math.Sqrt(SquareLength());
        }

        public double SquareLength()
        {
            return x * x + y * y;
        }

        public static txVector2 Zero()
        {
            txVector2 rtn;
            rtn.x = 0.0;
            rtn.y = 0.0;
            return rtn;
        }

        // See http://www.cs.cmu.edu/~quake/robust.html
        public static txOrientationState PointOrientationTest(txVector2 pa, txVector2 pb, txVector2 pc)
        {
            double det = (pa.x - pc.x) * (pb.y - pc.y) - (pa.y - pc.y) * (pb.x - pc.x);
            if (det > 0.0)
            {
                return txOrientationState.LEFT;
            }
            if (det < 0.0)
            {
                return txOrientationState.RIGHT;
            }

            return txOrientationState.COLLINEAR;
        }

        // for unit test
        public static bool operator ==(txVector2 l, txVector2 r)
        {
            // If both are null, or both are same instance, return true;
            if (System.Object.ReferenceEquals(l, r))
            {
                return true;
            }

            // If one is null, but not both, return false;
            if (((object)l == null || ((object)r == null)))
            {
                return false;
            }

            bool state = Math.Abs(l.x - r.x)<VECTOR_PRECISION && Math.Abs(l.y - r.y)<VECTOR_PRECISION;

            return state;
        }

        public static bool operator !=(txVector2 l, txVector2 r)
        {
            return !(l == r);
        }

        //public override bool Equals(object obj)
        //{
        //    //return this == obj;
        //    //return base.Equals(obj);
        //}



    }


    
}

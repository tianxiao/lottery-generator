using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace txGeometry
{
    public struct txMatrix2
    {
        public double m00, m01, m10, m11;

        public txMatrix2(double m00_, double m01_, double m10_, double m11_) {
            m00 = m00_;
            m01 = m01_;
            m10 = m10_;
            m11 = m11_;
        }

        public txMatrix2(double theta) {
            double costheat = Math.Cos(theta);
            double sintheat = Math.Sin(theta);
            m00 = costheat;
            m01 = -sintheat;
            m10 = sintheat;
            m11 = costheat;
        }

        public static txMatrix2 RotationThetaMatrix(double theta)
        {
            double costheat = Math.Cos(theta);
            double sintheat = Math.Sin(theta);

            txMatrix2 m;
            m.m00 = costheat;
            m.m01 = -sintheat;
            m.m10 = sintheat;
            m.m11 = costheat;

            return m;
        }

        public static txVector2 operator *(txMatrix2 m, txVector2 v) {
            txVector2 rtn;
            rtn.x = m.m00 * v.x + m.m01 * v.y;
            rtn.y = m.m10 * v.x + m.m11 * v.y;
            return rtn;
        }

        public static txMatrix2 YImageOperation()
        {
            txMatrix2 rtn;
            rtn.m00 = 1.0;
            rtn.m01 = 0.0;
            rtn.m10 = 0.0;
            rtn.m11 = -1.0;
            return rtn;
        }

        public txMatrix2 Scale(double s)
        {
            m00 *= s;
            m11 *= s;
            return this;
         }

        public static txMatrix2 Identity()
        {
            txMatrix2 m;
            m.m00 = 1.0;
            m.m01 = 0.0;
            m.m10 = 0.0;
            m.m11 = 1.0;

            return m;
        }
    }
}

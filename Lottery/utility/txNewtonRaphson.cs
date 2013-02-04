using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace utility
{
    class txNewtonRaphson
    {
        List<double> xlist = new List<double>();
        double xstart;
        double xend;
        double fepsilon;
        double xepsilon;
        const double DerivativeEpsilon = 1e-12;

        public List<double> XList { get { return xlist; } }

        public txNewtonRaphson(double xstart_, double xend_, double fepsiolon_ = 1e-5, double xepsilon_=1e-5)
        {
            xstart = xstart_;
            xend = xend_;
            fepsilon = fepsiolon_;
            xepsilon = xepsilon_;
        }

        public double Calculate()
        {
            double x = (xstart + xend) / 2.0;
            while (Math.Abs(f0(x)) > fepsilon)
            {
                Trace.Assert(Math.Abs(DerivativeEpsilon) > fp0(x));
                x = x - f0(x) / fp0(x);
                xlist.Add(x);
            }

            return x;
        }

        private double f0(double x)
        {
            double rtn;
            rtn = x * x * x - 0.165 * x * x + 3.993 * 0.0001;
            return rtn;
        }

        private double fp0(double x)
        {
            double rtn;
            rtn = 3 * x * x - 0.33 * x;
            return rtn;
        }

        
    }
}

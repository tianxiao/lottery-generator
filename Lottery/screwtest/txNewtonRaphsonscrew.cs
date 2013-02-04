using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace screwtest
{
    class txNewtonRaphsonscrew
    {
        double x0;
        double y0;
        double px0;
        double py0;
        double p;
        double omega;
        double A;
        double kappa;

        double thetastart;
        double thetaend;

        const double FEpsilon = 1e-10;
        const double XEpsilon = 1e-12;

        List<double> xlistdebug = new List<double>();

        public txNewtonRaphsonscrew(double x0_, double y0_, double px0_, double py0_, double p_, double omega_, double A_, double thetastart_, double thetaend_)
        {
            x0 = x0_;
            y0 = y0_;
            px0 = px0_;
            py0 = py0_;
            p = p_;
            omega = omega_;

            A = A_;

            Trace.Assert(Math.Abs(px0) > XEpsilon);
            kappa = py0 / px0;

            thetastart = thetastart_;
            thetaend = thetaend_;
        }

        public double Calcualte()
        {
            double theta = (thetastart + thetaend) / 2.0;
            while ( Math.Abs(f(theta))>FEpsilon)
            {
                double pfv = pf(theta);
                Trace.Assert(Math.Abs(pfv) > XEpsilon);
                theta = theta - pf(theta);
                // if theta large or small than the range...
                xlistdebug.Add(theta);
            }

            return theta;
        }

        private double pf(double theta)
        {
            double rtn = 0.0;
            rtn = (p0123n0(theta) / p0123donimator0(theta) - p0123n1(theta) / p0123donimator0(theta) - p0123n2(theta) / p0123donimator0(theta) + p0123n3(theta) / p0123donimator1(theta) + p0123n4(theta) / p0123donimator0(theta) - p0123n5(theta) / p0123donimator1(theta));
            return rtn;
        }

        private double p0123n5(double theta)
        {
            double rtn = 0.0;
            rtn = (Math.Sin(omega) * Math.Cos(theta) * y0 - Math.Sin(omega) * Math.Sin(theta) * x0) * (Math.Sin(theta) * y0 + Math.Cos(theta) * x0 - A) * ((Math.Sin(omega) * kappa * Math.Sin(theta) * Math.Sin(theta) + Math.Sin(omega) * kappa * Math.Cos(theta) * Math.Cos(theta)) * y0 + (Math.Sin(omega) * Math.Sin(theta) * Math.Sin(theta) + Math.Sin(omega) * Math.Cos(theta) * Math.Cos(theta)) * x0 + p * Math.Cos(omega) * kappa * Math.Sin(theta) + p * Math.Cos(omega) * Math.Cos(theta));
            return rtn;
        }

        private double p0123n4(double theta)
        {
            double rtn = 0.0;
            rtn = (Math.Cos(theta) * y0 - Math.Sin(theta) * x0) * ((Math.Sin(omega) * kappa * Math.Sin(theta) * Math.Sin(theta) + Math.Sin(omega) * kappa * Math.Cos(theta) * Math.Cos(theta)) * y0 + (Math.Sin(omega) * Math.Sin(theta) * Math.Sin(theta) + Math.Sin(omega) * Math.Cos(theta) * Math.Cos(theta)) * x0 + p * Math.Cos(omega) * kappa * Math.Sin(theta) + p * Math.Cos(omega) * Math.Cos(theta));
            return rtn;
        }

        private double p0123n3(double theta)
        {
            double rtn = 0.0;
            rtn = ((p * Math.Cos(omega) * Math.Sin(omega) + p * Math.Cos(omega) *Math.Cos(omega)) * Math.Sin(theta) + (-p * Math.Cos(omega) * Math.Sin(omega) - p * Math.Cos(omega)* Math.Cos(omega)) * kappa * Math.Cos(theta)) * (Math.Sin(omega) * Math.Cos(theta) * y0 - Math.Sin(omega) * Math.Sin(theta) * x0) * (Math.Cos(omega) * (Math.Cos(theta) * y0 - Math.Sin(theta) * x0) + p * Math.Cos(omega) * theta);
            return rtn;
        }

        private double p0123n2(double theta)
        {
            double rtn = 0.0;
            rtn = ((p * Math.Cos(omega) * Math.Sin(omega) + p * Math.Cos(omega) * Math.Cos(omega)) * Math.Cos(theta) - (-p * Math.Cos(omega) * Math.Sin(omega) - p * Math.Cos(omega) * Math.Cos(omega)) * kappa * Math.Sin(theta)) * (Math.Cos(omega) * (Math.Cos(theta) * y0 - Math.Sin(theta) * x0) + p * Math.Cos(omega) * theta);
            return rtn;
        }

        private double p0123n1(double theta)
        {
            double rtn = 0.0;
            rtn = ((p * Math.Cos(omega) * Math.Sin(omega) + p * Math.Cos(omega) * Math.Cos(omega)) * Math.Sin(theta) + (-p * Math.Cos(omega) * Math.Sin(omega) - p * Math.Cos(omega) * Math.Cos(omega)) * kappa * Math.Cos(theta)) * (Math.Cos(omega) * (-Math.Sin(theta) * y0 - Math.Cos(theta) * x0) + p * Math.Cos(omega));
            return rtn;
        }

        private double p0123n0(double theta)
        {
            double rtn = 0.0;
            rtn = (p * Math.Cos(omega) * kappa * Math.Cos(theta) - p * Math.Cos(omega) * Math.Sin(theta)) * (Math.Sin(theta) * y0 + Math.Cos(theta) * x0 - A);
            return rtn;
        }

        private double p0123donimator1(double theta)
        {
            double rtn = 0.0;
            rtn = (Math.Sin(omega) * Math.Sin(theta) * y0 + Math.Sin(omega) * Math.Cos(theta) * x0 + p * Math.Cos(omega));
            rtn *= rtn;
            return rtn;
        }

        private double p0123donimator0(double theta)
        {
            double rtn = 0.0;
            rtn = Math.Sin(omega) * Math.Sin(theta) * y0 + Math.Sin(omega) * Math.Cos(theta) * x0 + p * Math.Cos(omega); 
            return rtn;
        }

        private double f(double theta)
        {
            double rtn = 0.0;
            rtn = pp0(theta) * pp1(theta) + pp2(theta) * pp3(theta);
            return rtn;
        }

        private double pp3(double theta)
        {
            double rtn = 0.0;
            double nominator = (p * Math.Cos(omega) * Math.Sin(omega) + p * Math.Cos(omega) * Math.Cos(omega)) * Math.Sin(theta) + (-p * Math.Cos(omega) * Math.Sin(omega) - p * Math.Cos(omega) * Math.Cos(omega)) * kappa * Math.Cos(theta);
            double denominator = Math.Sin(omega) * Math.Sin(theta) * y0 + Math.Sin(omega) * Math.Cos(theta) * x0 + p * Math.Cos(omega);
            rtn = - nominator / denominator;
            return rtn;
        }

        private double pp2(double theta)
        {
            double rtn = 0.0;
            rtn = Math.Cos(omega) * (Math.Cos(theta) * y0 - Math.Sin(theta) * x0) + p * Math.Cos(omega) * theta;
            return rtn;
        }

        private double pp1(double theta)
        {
            double rtn = 0.0;
            rtn = ((Math.Sin(omega) * kappa * Math.Sin(theta) * Math.Sin(theta) + Math.Sin(omega) * kappa * Math.Cos(theta) * Math.Cos(theta)) * y0 + (Math.Sin(omega) * Math.Sin(theta) * Math.Sin(theta) + Math.Sin(omega) * Math.Cos(theta) * Math.Cos(theta)) * x0 + p * Math.Cos(omega) * kappa *Math.Sin(theta) + p * Math.Cos(omega) * Math.Cos(theta)) / (Math.Sin(omega) * Math.Sin(theta) * y0 + Math.Sin(omega) * Math.Cos(theta) * x0 + p * Math.Cos(omega));
            return rtn;
        }

        private double pp0(double theta)
        {
            double rtn = 0.0;
            rtn = Math.Sin(theta) * y0 + Math.Cos(theta) * x0 - A;
            return rtn;
        }

    }
}

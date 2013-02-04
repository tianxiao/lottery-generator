using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using txGeometry;
// The following math is according to this paper
// Design of three-screw positive displacement rotary pumps
namespace screwtest
{
    public class txScrwUtility
    {
        const double screwRadius = 10.0;
        const double screwRadiusE = 17.0;
        const double alpha = Math.PI / 4.0;
        double beta;
        double alphact;
        const double h = 15.0;

        public double Beta { get {return beta;} }
        public double ScrewRadius { get { return screwRadius; } }
        public double Alpha { get { return alpha; } }
        public double ScrewRadiusE { get { return screwRadiusE; } }
        public double Alphact { get { return alphact; } }
        public double H { get { return h; } }

        public txScrwUtility()
        {
            // const double radiusE = 2.0 * screwRadius;
            const double cosinaphact = (5.0 * screwRadius * screwRadius - screwRadiusE * screwRadiusE) / (4.0 * screwRadius * screwRadius);
            alphact = Math.Acos(cosinaphact);
            double y = (2 * screwRadius * Math.Sin(alphact) - screwRadius * Math.Sin(2 * alphact));
            double x = (2 * screwRadius * Math.Cos(alphact) - screwRadius * Math.Cos(2 * alphact));
            beta = Math.Atan2(y,x);
            
        }


        public static txVector2 Domain0(double r, double theta, txMatrix2 m)
        {
            txVector2 rtn;
            rtn.x = 2.0 * r * Math.Cos(theta) - r * Math.Cos(2.0 * theta);
            rtn.y = 2.0 * r * Math.Sin(theta) - r * Math.Sin(2.0 * theta);

            rtn = m * rtn;
            
            return rtn;
        }

        public static txVector2 Domain1(double r, double theta)
        {
            txVector2 rtn;
            rtn.x = r * Math.Cos(theta);
            rtn.y = r * Math.Sin(theta);
            return rtn;
        }


    }
}

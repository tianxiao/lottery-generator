using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    public class txRectangle
    {
        txVector2 leftBottomV;
        txVector2 rightBottomV;
        txVector2 leftTopV;
        txVector2 rightTopV;
        double omega;
        txMatrix2 met;

        List<txLineSegment> linesegmentlist;

        public txVector2 LeftBottomV {  get { return leftBottomV; }  }
        public txVector2 RightBottomV { get { return rightBottomV; } }
        public txVector2 LeftTopV { get { return leftTopV; } }
        public txVector2 RightTopV { get { return rightTopV; } }
        public txMatrix2 RotationMatrix { get { return met; } }
        public List<txLineSegment> LineSegmentList { get { return linesegmentlist; } }

        public txRectangle(txVector2 v0_, txVector2 v1_, txVector2 v2_, txVector2 v3_, double omega_) {
            leftBottomV = v0_;
            rightBottomV = v1_;
            rightTopV = v2_;
            leftTopV = v3_;
            omega = omega_;
            met = new txMatrix2(1.0,0.0,0.0,1.0);
            AssemblyLineSegmentList();
        }

        public void Tick(double t) {
            Rotate(t);
        }

        private void Rotate(double t) {
            met = new txMatrix2(t * omega);
            leftBottomV = met * leftBottomV;
            rightBottomV = met * rightBottomV;
            rightTopV = met * rightTopV;
            leftTopV = met * leftTopV;
            AssemblyLineSegmentList();
        }

        private void AssemblyLineSegmentList()
        {
            // assembly the line segment list;
            linesegmentlist = new List<txLineSegment>();
            txLineSegment bottomline;
            bottomline.start = leftBottomV;
            bottomline.end = rightBottomV;
            txLineSegment rightline;
            rightline.start = rightBottomV;
            rightline.end = rightTopV;
            txLineSegment topline;
            topline.start = rightTopV;
            topline.end = leftTopV;
            txLineSegment leftline;
            leftline.start = leftTopV;
            leftline.end = leftBottomV;
            linesegmentlist.Add(bottomline);
            linesegmentlist.Add(rightline);
            linesegmentlist.Add(topline);
            linesegmentlist.Add(leftline);
        }

        //public void Draw()
    }
}

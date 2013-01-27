using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lottery
{
    public class txWorld
    {
        List<txPhysicalShpere> disklist = new List<txPhysicalShpere>();
        txRectangle rectboundary;

        txForceUpdator forceupdator;
        //txAccelerationUpdator accelerationupdator;
        //txPositionUpdator positionupdator;

        double globaltime;

        public List<txPhysicalShpere> DiskList{ get { return disklist; }  }
        public txRectangle RectBoundary { get { return rectboundary; } }

        // Constant parameters
        const double gravityparameter = 10000;
        const double stiffnessparameter = 100;

        public void SetUpScene()
        {
            SetUpBoundary();

            SetUpDisk1010();

            // set up gravity
            forceupdator = new txForceUpdator();
            txVector2 g;
            g.x = 0.0;
            g.y = -gravityparameter;
            forceupdator.GlobalForce = g;

            // reset the time
            globaltime = 0.0;
        }

        private void SetUpDisk1010()
        {
            // set up disklist
            const double xstart = -132.0;
            const double ystart = -132.0;
            double x = xstart;
            double y = ystart;
            const double deltax = 21.0;
            const double deltay = 21.0;
            for (int i = 0; i < 10; i++)
            {
                x = xstart;
                for (int j = 0; j < 10; j++)
                {
                    txPhysicalShpere disk = new txPhysicalShpere();
                    txVector2 position;
                    position.x = x;
                    position.y = y;
                    disk.Position = position;
                    disk.Velocity = txVector2.Zero();
                    disk.Acceleration = txVector2.Zero();
                    disk.Force = txVector2.Zero();
                    disk.Stiffness = stiffnessparameter;
                    disk.Id = -1;
                    disk.CollisionPatches.Clear();
                    disklist.Add(disk);
                    x += deltax;
                }
                y += deltay;
            }
        }

        private void SetUpDisk00()
        { 
            
        }

        private void SetUpBoundary()
        {
            // set up container
            txVector2 leftbottom, rightbottom, righttop, lefttop;
            double halfline = 264.0;
            double omega = Math.PI / 60.0;
            leftbottom.x = -halfline; leftbottom.y = -halfline;
            rightbottom.x = halfline; rightbottom.y = -halfline;
            righttop.x = halfline; righttop.y = halfline;
            lefttop.x = -halfline; lefttop.y = halfline;
            rectboundary = new txRectangle(leftbottom, rightbottom, righttop, lefttop, omega);
        }

        public void Simulate(double step)
        { 
            // rotate the rectangle boundary
            rectboundary.Tick(globaltime);
            //forceupdator.UpdateDiskListForce(disklist);
            txCollider.DiskListToDiskList(disklist);
            txCollider.DiskListToLineSegmentList(disklist, rectboundary.LineSegmentList);

            forceupdator.UpdateDiskListForce(disklist);

            txAccelerationUpdator.UpdateAcceleration(disklist);

            txPositionUpdator.UpdateDiskPosition(disklist, step);          

            globaltime += step;
        }

        public txLineSegment BoundingBox()
        {
            txVector2 p0 = disklist[0].Position;
            double xmin = p0.x;
            double xmax = p0.x;
            double ymin = p0.y;
            double ymax = ymin;
            txVector2 pstart;
            txVector2 pend;
            pstart.x = xmin;
            pstart.y = ymin;
            pend.x = xmax;
            pend.y = ymax;
            foreach (txPhysicalShpere disk in disklist)
            {
                double x = disk.Position.x;
                double y = disk.Position.y;
                xmin = x < xmin ? x : xmin;
                xmax = x > xmax ? x : xmax;
                ymin = y < ymin ? y : ymin;
                ymax = y > ymax ? y : ymax;

            }
            
            txLineSegment linesegment;
            linesegment.start = pstart;
            linesegment.end = pend;
            return linesegment; 
        }

    }
}

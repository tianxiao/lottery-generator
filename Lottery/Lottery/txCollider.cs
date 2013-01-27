using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    public struct txColliderPatch{
        public txVector2 normal;
        public double penetrationdepth;
    }

    enum txColliderState { 
        PENETRATION,
        CONTACT,
        SEPERATE
    }

    class txCollider
    {
        // precision 
        public const double CONTACT_PRECISION = 1e-31;
        public const double CONTACT_SQUARE_PRECISION = 2 * CONTACT_PRECISION;
        /// <summary>
        /// check & update the disk list self interference
        /// </summary>
        /// <param name="disklist"></param>
        public static void DiskListToDiskList(List<txPhysicalShpere> disklist)
        {
            foreach (txPhysicalShpere it in disklist)
            {
                DiskToDiskList(it, disklist);
            }
        }

        public static void DiskToDiskList(txPhysicalShpere d_, List<txPhysicalShpere> dlist_) 
        {
            txColliderPatch currentpatch = new txColliderPatch();
            foreach (txPhysicalShpere it in dlist_) 
            {
                if (it != d_) 
                {
                    txColliderState collstate = DiskDisk(it, d_, ref currentpatch);
                    currentpatch = AddNewPatchToDisk(d_, currentpatch, collstate);
                }
            }
             
        }

        public static void DiskListToLineSegmentList(List<txPhysicalShpere> disklist, List<txLineSegment> linelist)
        {
            foreach (txPhysicalShpere disk in disklist)
            {
                DiskToLineSegmentList(disk, linelist);
            }
        }

        private static txColliderPatch AddNewPatchToDisk(txPhysicalShpere d_, txColliderPatch currentpatch, txColliderState collstate)
        {
            if (txColliderState.PENETRATION == collstate)
            {
                d_.CollisionPatches.Add(currentpatch);
            }
            else if (txColliderState.SEPERATE == collstate)
            {

            }
            else
            {

            }
            return currentpatch;
        }

        // Calcualte the I's patch
        // In later versiont the J will be calculate at the same time to be more efficiency!
        public static txColliderState DiskDisk(txPhysicalShpere I, txPhysicalShpere J, ref txColliderPatch patch)
        {
            double squaredistance = I.SquareDistanceToShpere(J);
            if (squaredistance < txPhysicalShpere.RADIUS4SQUARE) {
                patch.normal = (J.Position - I.Position).Normalize();
                patch.penetrationdepth = 0.25 * (txPhysicalShpere.DIAMETER - Math.Sqrt(squaredistance));
                return txColliderState.PENETRATION;
            }
            else if (squaredistance > txPhysicalShpere.RADIUS4SQUARE)
            {
                return txColliderState.SEPERATE;
            }
            else {
                return txColliderState.CONTACT;
            };
        }

        public static void DiskToLineSegmentList(txPhysicalShpere d_, List<txLineSegment> llist)
        {
            txColliderPatch currentpatch = new txColliderPatch();
            foreach (txLineSegment it in llist)
            {
                txColliderState collisionstate = DiskLineSegment(d_, it,ref currentpatch);
                AddNewPatchToDisk(d_,currentpatch,collisionstate);
            }
        }

        public static txColliderState DiskLineSegment(txPhysicalShpere d_, txLineSegment line, ref txColliderPatch patch)
        {
            txVector2 a = d_.Position - line.start;
            txVector2 b = line.end - line.start;
            // debug 
            //double ab = a * b;
            //txVector2 bnormal = b.Normalize();

            txVector2 disVec = a - a * b * (b.Normalize()) * (1 / b.Length());
            txVector2 normal = disVec.Normalize();
            double distance = disVec.Length();
            txOrientationState orientationstate = txVector2.PointOrientationTest(line.start, line.end, d_.Position);
            if (txOrientationState.LEFT == orientationstate)
            {
                if (distance < txPhysicalShpere.RADIUS)
                {
                    patch.penetrationdepth = 0.5 * (txPhysicalShpere.RADIUS - distance);
                    patch.normal = normal;
                    return txColliderState.PENETRATION;
                }

                if (distance == txPhysicalShpere.RADIUS)
                {
                    patch.penetrationdepth = 0.0;
                    patch.normal = normal;
                    return txColliderState.CONTACT;
                }
                // >
                return txColliderState.SEPERATE;
            }
            
            if (txOrientationState.RIGHT == orientationstate)
            {
                patch.penetrationdepth = distance + txPhysicalShpere.RADIUS;
                patch.normal = -1.0 * normal;
                return txColliderState.PENETRATION;
            }

            // If I embed the following code into the comment code
            // The compiler will issue a error
            // not all code paths return a value????
            //if (txOrientationState.COLLINEAR == orientationstate)
            //{
                txVector2 verticalv;
                verticalv.x = b.y;
                verticalv.y = -b.x;
                patch.penetrationdepth = txPhysicalShpere.RADIUS;
                patch.normal = verticalv.Normalize();
                return txColliderState.PENETRATION;
            //}
        }
    }
}

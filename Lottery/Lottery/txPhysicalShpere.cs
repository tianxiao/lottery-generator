using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    public class txPhysicalShpere
    {
        public const double RADIUS = 10;
        public const double RADIUS4SQUARE = 4 * RADIUS * RADIUS;
        public const double DIAMETER = RADIUS * 2;
        public const double DISKMESS = 10.0;
        public const double DISKMESSINVERSE = 0.1;
        txVector2 position;
        txVector2 velocity;
        txVector2 acceleration;
        txVector2 force;
        double stiffness;
        int id;
        List<txColliderPatch> collisionpatches = new List<txColliderPatch>();


        public txVector2 Position {
            get { return position; }
            set { position = value; }
        }

        public txVector2 Velocity {
            get { return velocity; }
            set { velocity = value; }
        }

        public txVector2 Acceleration {
            get { return acceleration; }
            set { acceleration = value; }
        }

        public txVector2 Force {
            get { return force; }
            set { force = value; }
        }

        public double Stiffness {
            get { return stiffness; }
            set { stiffness = value; }
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public List<txColliderPatch> CollisionPatches {
            get { return collisionpatches; }
            set { collisionpatches = value; }
        }

        public static txVector2 CalculateForceFromPenetrationDepth (double stiffness_, double penetrationDepth, txVector2 normal_) { 
           // using Lottery;
            txVector2 rtnvec2;
            rtnvec2 = stiffness_ * penetrationDepth * (-1.0) * normal_;
            return rtnvec2;
        }

        public void AddForcToDisk(txVector2 f) {
            force = force + f;
        }

        public double DistanceToShere(txPhysicalShpere s_) {
            return position.Distance(s_.position);
        }

        public double SquareDistanceToShpere(txPhysicalShpere s_)
        {
            return position.SquareDistance(s_.position);
        }
 
    }
}

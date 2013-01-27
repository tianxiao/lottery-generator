using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    class txForceUpdator
    {
        public txVector2 globalforce;
        public txVector2 GlobalForce
        {
            get { return globalforce; }
            set { globalforce = value; }
        }

        public void UpdateDiskListForce(List<txPhysicalShpere> disklist)
        {

            foreach (txPhysicalShpere it in disklist)
            {
                txVector2 force;
                force.x = 0.0;
                force.y = 0.0;
                it.Force = txVector2.Zero();
                foreach (txColliderPatch patch in it.CollisionPatches)
                {
                    force = force + txPhysicalShpere.CalculateForceFromPenetrationDepth(it.Stiffness, patch.penetrationdepth, patch.normal);
                }
                it.Force = it.Force + globalforce + force;
                it.CollisionPatches.Clear();
            }
        }
    }
}

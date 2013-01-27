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
                    // penetration force will take consideration after the rigid body dynamic have been finished
                    // Here Only consider the disk to disk collision and the disk to boundary collision
                    // consider these collision to be the elastic
                    // disk0 to disk1 the velocity of two disk will change
                    // disk to boundary the velocity of the boundary normal of the disk will reverse
                    // only took consider the two body condistion ?
                    // the three disks collision???
                    //force = force + txPhysicalShpere.CalculateForceFromPenetrationDepth(it.Stiffness, patch.penetrationdepth, patch.normal);

                }
                it.Force = it.Force + globalforce + force;
                // update velocity direction during contact!
                it.CollisionPatches.Clear();
            }
        }
    }
}

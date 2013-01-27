using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    class txPositionUpdator
    {
        public static void UpdateDiskPosition(List<txPhysicalShpere> disklist, double deltat)
        {
            foreach (txPhysicalShpere it in disklist)
            { 
                // update velocity
                it.Velocity = it.Velocity + it.Acceleration * deltat;
                it.Velocity = 0.6 * it.Velocity;
                // update position
                it.Position =it.Position + it.Velocity * deltat;
            }
        }
    }
}

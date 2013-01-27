using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    class txAccelerationUpdator
    {
        public static void UpdateAcceleration(List<txPhysicalShpere> disklist)
        {
            foreach (txPhysicalShpere it in disklist)
            {
                it.Acceleration = it.Force * txPhysicalShpere.DISKMESSINVERSE;
            }
        }
    }
}

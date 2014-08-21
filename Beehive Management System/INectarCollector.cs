using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Management_System
{
    interface INectarCollector
    {
        void FindFlowers();
        void GatherNectar();
        int ReturnToHive();
    }
}

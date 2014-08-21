using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Management_System
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StringerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Console_App
{
    internal class SkeletonFactory: MonsterFactory
    {
        protected override Monster CreateMonster()
        {
            return new Skeleton();
        }
    }
}

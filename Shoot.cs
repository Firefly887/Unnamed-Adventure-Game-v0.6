using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdvGameLibV2
{
    class Shoot
    {
        public void _Shoot(byte noun, int chap)
        {
            if (chap == 1)
            {
                switch (noun)
                {
                    case 1:
                        WriteLine("I shoot finger guns at the mirror...\nThe guy in the mirror copies me...\nHow rude!");
                        break;
                    case 2:
                        WriteLine("I shoot finger guns at the table\nIt plays dead.");
                        break;
                    case 4:
                        if (MainLogic.isHoleChap1 == true)
                            WriteLine("I shoot finger guns into the hole...\nNothing happens.");
                        else
                            WriteLine("What hole?");
                        break;
                    default:
                        WriteLine("I shoot finger guns...\nAnd miss! :(");
                        break;
                }
            }
        }
    }
}

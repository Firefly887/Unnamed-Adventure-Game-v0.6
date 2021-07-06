using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdvGameLibV2
{
    class Talk
    {
        public void _Talk(byte noun, int chap)
        {
            if (chap == 1)
            {
                WriteLine("I have nobody to talk to...\n*PEW PEW*");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdvGameLibV2
{
    class Search
    {
        public void _Search(byte noun, int chap)
        {
            if (chap ==1)
            {
                switch (noun)
                {
                    case 1:
                        if (MainLogic.inventory.Contains("Saw"))
                        {
                            WriteLine($"I hold the {MainLogic.inventory[MainLogic.inventory.IndexOf("Saw")]} in front of the mirror...\nI look really handy!");
                        }
                        if (!MainLogic.inventoryUsed.Contains("Saw"))
                        {
                            WriteLine("I looked in the mirror to see what i saw...\nAcquired a Saw.");
                            MainLogic.inventory.Add("Saw");
                        }
                        else
                        {
                            WriteLine("I have already done that...\nI don't think doing it again will help...")
                        }
                        break;
                    default:
                        WriteLine("I'm not sure what to do here.");
                        break;
                }
            }
        }
    }
}

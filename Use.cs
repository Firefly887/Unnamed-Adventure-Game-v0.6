using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdvGameLibV2
{
    class Use
    {
        public void _Use(byte noun, byte verb, int chap)
        {
            if (chap == 1)
            {
                switch (noun)
                {
                    case 2:
                        if (MainLogic.isHoleChap1 == false)
                        {
                            WriteLine($"I use the {MainLogic.inventory[MainLogic.inventory.IndexOf("Saw")]} to cut a hole in the table...\nIt seems i can travel through here...");
                            WriteLine("The saw disappeared in my hands...\nStrange that!");
                            MainLogic.isHoleChap1 = true;
                            MainLogic.inventory.Remove("Saw");
                            MainLogic.inventoryUsed.Add("Saw");
                        }
                        else
                        {
                            WriteLine("There is already a hole!...\nMaybe i can travel through it?");
                        }
                        break;
                    default:
                        WriteLine("I don't know what to do here...");
                        break;
                }
            }
        }
    }
}

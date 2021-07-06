using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdvGameLibV2
{
    class Go
    {
        public int _Go(byte noun, int chap)
        {
            if (chap == 1)
            {
                switch (noun)
                {
                    case 2:
                    case 3:
                        if (MainLogic.isHoleChap1 == true)
                        {
                            WriteLine("I Climb through the hole...\nI wonder where it leads?");
                            WriteLine("Inside the hole in the table was a portal...Fancy that!");
                            WriteLine("Travelling through the portal leads to...");
                            WriteLine("......................................................"); 
                            return chap++;
                        }
                        else if (MainLogic.isHoleChap1 == false & noun == 2)
                        {
                            WriteLine("I can't travel through a table!");
                            return chap;
                        }
                        else
                        {
                            WriteLine("What hole?");
                            return chap;
                        }
                    default:
                        WriteLine("I can't do that...");
                        return chap;
                }
            }
            else
                return chap;
        }


    }
}

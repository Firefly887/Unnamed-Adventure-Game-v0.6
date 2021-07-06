﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvGameLibV2
{
    enum Verb : byte
    {
        go = 1,
        head = go,
        travel = go,
        use = 2,
        talk = 3,
        speak = talk,
        shoot = 4,
        fire = 5,
        check = 6,
        look = 7,
        saw = 8,
        search = 9,
        cut = 10,
    }
}

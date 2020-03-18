﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Power_action : Distant_action
    {
        public override string grab()
        {
            return "pick up";
        }

        public override string hit()
        {
            return "slam!";
        }

    }
}

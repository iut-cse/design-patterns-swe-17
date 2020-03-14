﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    abstract class DistantAction
    {
        public IEnumerable<string>
        ExecuteDistantAction()
        {
            yield return Move();
        }

        private string Move()
        {
            return "move";
        }
    }
}

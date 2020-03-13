using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Head: CloseAction
    {
        string executeAction()
        {
            return "head head";
        }

        string CloseAction.ExecuteAction()
        {
            throw new NotImplementedException();
        }
    }
}

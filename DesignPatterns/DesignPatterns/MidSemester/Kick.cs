using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester{
    public class Kick : ICloseAction{
        public string ExecuteCloseAction(){
            return "kick";
        }
    }
}
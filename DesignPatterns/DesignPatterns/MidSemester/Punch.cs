using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester{
    public class Punch : ICloseAction{ 
        public string ExecuteCloseAction(){
            return "punch";
        }
    }
}
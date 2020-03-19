using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester{
    public class Head : ICloseAction{
        public string ExecuteCloseAction(){
            return "head head";
        }
    }
}
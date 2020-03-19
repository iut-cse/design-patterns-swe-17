using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester{
    public class Power : DistantAction{
        public override string Grab(){
            return "pick up";
        }
        public override string Hit(){
            return "slam!";
        }
    }
}
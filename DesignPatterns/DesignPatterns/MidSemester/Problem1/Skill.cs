using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester.Problem1
{
    public class Skill : DistantAction
    {
        public override string Hit(){
            return "knee! knee!! knee!!!";
        }
        public override string Grab()
        {
            return "hold collar";
        } 
    }
}
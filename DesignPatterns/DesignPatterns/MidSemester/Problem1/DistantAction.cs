using System;
using System.Collections.Generic;
using System.Text;
namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction.Problem1
    {
        public IEnumerable<string> ExecuteDistantAction(){
            yield return Grab();
            yield return Hit();
            yield return Move(); 
        }
        public abstract string Grab();
        public abstract string Hit();
        private string Move(){
            return "move";
        }  
    }
}
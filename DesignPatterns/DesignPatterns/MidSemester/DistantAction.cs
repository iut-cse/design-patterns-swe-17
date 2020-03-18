using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{

        public abstract class IDistantAction
        {
            public IEnumerable<String> TemplateMethod()
            {
                yield return move();
                yield return grab();
                yield return hit();
            }
             String move()
            {
                return "move";    // Concrete Method
            }

             public abstract String grab();
             public abstract String hit();
        }

        public class Power : IDistantAction
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

        public class Skill :IDistantAction
        {
            public override string grab()
            {
                return "hold collar";
            }

            public override string hit()
            {
                return "knee! knee!! knee!!!";
            }
        }

    }


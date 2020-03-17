using System.Collections.Generic;
namespace DesignPatterns.MidSemester
{
    public interface IDistantAction
    {
        IEnumerable<string> Execute();
    }

}
using System;
namespace DesignPatterns.MidSemester
{
    public interface IClose_action
{
    string action();
}

public class punch : IClose_action
{
    public string action()
    {
        return "punch_enemy";
    }
}

public class kick : IClose_action
{
    public string action()
    {
        return "kick_enemy";
    }
}

public class head : IClose_action
{
    public string action()
    {
        return "headHit_enemy";
    }
}
}

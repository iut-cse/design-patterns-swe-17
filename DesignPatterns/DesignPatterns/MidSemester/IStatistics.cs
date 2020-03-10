using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface IStatistics
    {
        public string conversion(string text);
        
    }

    public class plaintext:IStatistics
    {
        public string conversion(string text)
      {
            return text;
      }
    }
    public class StatisticDecorator : IStatistics
    {
        IStatistics stat;
        public StatisticDecorator(IStatistics stat)
        {
            this.stat = stat;
        }
        public virtual string conversion(string text)
        {
            return stat.conversion(text);
        }
    }
    public class Encryption : StatisticDecorator
    {
        public Encryption(IStatistics stat):base(stat)
        {   
        }
         public override string conversion(string text)
        {
            return base.conversion(text).ToLower();
        }
    }

    public class Compression : StatisticDecorator
    {
        public Compression(IStatistics stat) : base(stat)
        {
        }
        public override string conversion(string text)
        {
            if (text.Length<3)
            {
                return base.conversion(text);
            }
            else
            {
                return base.conversion(text).Substring(0, text.Length - 1);
            }
            
        }
    }
    public class base64encodeing : StatisticDecorator
    {
        public base64encodeing(IStatistics stat) : base(stat)
        {
        }
        public override string conversion(string text)
        {
            return "("+ base.conversion(text)+ ")";
        }
    }
}

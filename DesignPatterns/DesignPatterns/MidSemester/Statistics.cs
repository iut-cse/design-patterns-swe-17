using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface IStatistics
    {
        public string conversion(string text);

    }

    public class PlainText : IStatistics
    {
        public string conversion(string text)
        {
            return text;
        }
    }
    public class StatisticsDecorator : IStatistics
    {
        IStatistics statistics;
        public StatisticsDecorator(IStatistics statistics)
        {
            this.statistics = statistics;
        }
        public virtual string conversion(string text)
        {
            return statistics.conversion(text);
        }
    }
    public class Encryptor : StatisticsDecorator
    {
        public Encryptor(IStatistics statistics) : base(statistics)
        {
        }
        public override string conversion(string text)
        {
            return base.conversion(text).ToLower();
        }
    }

    public class Compressor : StatisticsDecorator
    {
        public Compressor(IStatistics statistics) : base(statistics)
        {
        }
        public override string conversion(string text)
        {
            if (text.Length < 3)
            {
                return base.conversion(text);
            }
            else
            {
                return base.conversion(text).Substring(0, text.Length - 1);
            }

        }
    }
    public class base64encoder : StatisticsDecorator
    {
        public base64encoder(IStatistics statistics) : base(statistics)
        {
        }
        public override string conversion(string text)
        {
            return "(" + base.conversion(text) + ")";
        }
    }
}
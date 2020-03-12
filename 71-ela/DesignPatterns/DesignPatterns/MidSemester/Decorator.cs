using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{

    public interface IStatistics
    {
        public string conversion(string plaintext);
    }
    public class PlainText : IStatistics
    {
        public string conversion(string plaintext)
        {
            return plaintext;
        }
    }
    public abstract class Decorator : IStatistics
    {
        protected IStatistics iStatistics;
        public Decorator(IStatistics iStatistics)
        {
            this.iStatistics = iStatistics;

        }
        public virtual string conversion(string plaintext)
        {
            return iStatistics.conversion(plaintext);
            
        }
    }
    public class Encryption : Decorator
    {
        
        public Encryption(IStatistics iStatistics) :base(iStatistics)
        {
           

        }
        public override string conversion(string plaintext)
        {
            return iStatistics.conversion(plaintext).ToLower();

        }

    }
   
    public class Compression : Decorator
    {
        public Compression(IStatistics iStatistics) : base(iStatistics)
        {
        }
        public override string conversion(string plaintext)
        {
            if (plaintext.Length >= 3)
            {

                return iStatistics.conversion(plaintext).Remove(plaintext.Length - 2);
                
            }
            else
            {
                return iStatistics.conversion(plaintext);
            }

        }
    }
    public class Encoding : Decorator
    {
        public Encoding(IStatistics iStatistics) : base(iStatistics)
        {
        }
        public override string conversion(string plaintext)
        {
            return "(" + iStatistics.conversion(plaintext) + ")";
        }
    }
}

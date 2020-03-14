using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class Mid_problem2TestCase
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            IConversion stat = new plaintext();
            var converted = stat.conversion(original);
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IConversion stat = new plaintext();
            stat = new Compression(stat);
            stat = new Encryption(stat);
            var converted = stat.conversion(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IConversion stat = new plaintext();
            stat = new Encryption(stat);
            stat = new Compression(stat);
            stat = new Base_64_encodeing(stat);
            stat = new Compression(stat);
            var converted = stat.conversion(original);
            Assert.Equal("(top score is )", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IConversion stat = new plaintext();
            stat = new Compression(stat);
            stat = new Base_64_encodeing(stat);
            stat = new Encryption(stat);
            var converted = stat.conversion(original);
            Assert.Equal("(top score is 3)", converted);
          
        }
    }
}

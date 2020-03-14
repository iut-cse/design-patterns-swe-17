using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            IStatistics statistics = new PlainText();
            var converted = statistics.conversion(original);
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics statistics = new PlainText();
            statistics = new Compressor(statistics);
            statistics = new Encryptor(statistics);
            var converted = statistics.conversion(original);             
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IStatistics stat = new PlainText();
            stat = new Encryptor(stat);
            stat = new Compressor(stat);
            stat = new base64encoder(stat);
            stat = new Compressor(stat);
            var converted = stat.conversion(original);
            Assert.Equal("(top score is )", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics stat = new PlainText();
            stat = new Compressor(stat);
            stat = new base64encoder(stat);
            stat = new Encryptor(stat);
            var converted = stat.conversion(original);
            Assert.Equal("(top score is 3)", converted);            
        }
    }
}

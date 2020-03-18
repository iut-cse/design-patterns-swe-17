using Xunit;
using DesignPatterns.MidSemester.Task2;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            IStatistics stat = new PlainTxt();
            var converted = stat.convertTxt(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics stat = new PlainTxt();
            stat = new Compressed(stat);
            stat = new Encrypted(stat);
            var converted = stat.convertTxt(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IStatistics stat = new PlainTxt();
            stat = new Encrypted(stat);
            stat = new Compressed(stat);
            stat = new Encoded(stat);
            stat = new Compressed(stat);
            var converted = stat.convertTxt(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics stat = new PlainTxt();
            stat = new Compressed(stat);
            stat = new Encoded(stat);
            stat = new Encrypted(stat);
            var converted = stat.convertTxt(original);
            Assert.Equal("(top score is 3)", converted);
        }
    }
}

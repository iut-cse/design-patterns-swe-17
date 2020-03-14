using Xunit;
using DesignPatterns.MidSemester.Task_2;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            IStatistics stat = new SourceStatistics();
            var converted = stat.conversion(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics stat = new SourceStatistics();
            stat = new Encryptor(stat);
            stat = new Compressor(stat);
            var converted = stat.conversion(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IStatistics stat = new SourceStatistics();
            stat = new Encryptor(stat);
            stat = new Compressor(stat);
            stat = new Encoder(stat);
            stat = new Compressor(stat);
            var converted = stat.conversion(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatistics stat = new SourceStatistics();
            stat = new Compressor(stat);
            stat = new Encoder(stat);
            stat = new Encryptor(stat);
            var converted = stat.conversion(original); // do the convertion
            Assert.Equal("(top score is 3)", converted);
        }
    }
}

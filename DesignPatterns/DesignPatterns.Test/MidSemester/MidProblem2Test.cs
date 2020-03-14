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
            IPlayerStatistics statistics1 = new PlayerStatistics();
            var converted = statistics1.Statistics(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IPlayerStatistics statistics2 = new Encryption(new Compression(new PlayerStatistics()));
            var converted = statistics2.Statistics(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IPlayerStatistics statistics3 = new Compression(new Encoder(new Compression(new Encryption(new PlayerStatistics()))));
            var converted = statistics3.Statistics(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IPlayerStatistics statistics4 = new Encryption(new Compression(new Encoder(new PlayerStatistics())));
            var converted = statistics4.Statistics(original); // compress then encryppt.
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
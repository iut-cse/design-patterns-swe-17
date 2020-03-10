using Xunit;
using DesignPatterns.MidSemester;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            IStatSaver f1 = new GamerStat();
            var converted = f1.statistics(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatSaver f1 = new EncryptionDecor(new CompressionDecor(new GamerStat()));
            var converted = f1.statistics(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IStatSaver f1 = new CompressionDecor(new EncoderDecor(new CompressionDecor(new EncryptionDecor(new GamerStat()))));
            var converted = f1.statistics(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IStatSaver f1 = new EncryptionDecor(new EncoderDecor(new CompressionDecor(new GamerStat())));
            var converted = f1.statistics(original); // do the convertion
            Assert.Equal("(top score is 3)", converted);
        }
    }
}

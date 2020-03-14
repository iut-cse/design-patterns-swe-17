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
            GamerStat gamer = new GamerStat();

            var converted = gamer.Stat(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            BaseDecorator gamer = new EncryptorDecorator(new CompressorDecorator(new GamerStat()));
            var converted = gamer.Stat(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            BaseDecorator gamer = new CompressorDecorator(new EncoderDecorator(new CompressorDecorator(new EncryptorDecorator(new GamerStat()))));
            var converted = gamer.Stat(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            BaseDecorator gamer = new EncryptorDecorator(new EncoderDecorator(new CompressorDecorator(new GamerStat())));
            var converted = gamer.Stat(original);
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
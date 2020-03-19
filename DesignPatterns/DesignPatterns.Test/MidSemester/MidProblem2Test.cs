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
            var converted = gamer.stat(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            BaseDecorator gamer = new encryptorDec(new ComDec(new GamerStat()));
            var converted = gamer.stat(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            BaseDecorator gamer = new ComDec(new EncoderDec(new ComDec(new encryptorDec( new GamerStat()))));
            var converted = gamer.stat(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            var original = "Top Score is 305";
            BaseDecorator gamer = new encryptorDec(new EncoderDec(new ComDec(new GamerStat())));
            var converter = gamer.stat(original);
            Assert.Equal("(top score is 3)",converter);
        }
    }
}

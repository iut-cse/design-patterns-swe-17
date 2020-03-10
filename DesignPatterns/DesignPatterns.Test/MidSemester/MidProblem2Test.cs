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
            var converted = new RawData(original).printline(); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new Encrypter(new Compressor(new RawData(original))).printline(); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted = new Compressor(new Encoder(new Compressor(new Encrypter(new RawData(original))))).printline(); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new Encrypter(new Encoder(new Compressor(new RawData(original)))).printline();
            Assert.Equal("(top score is 3)", converted);
        }
    }
}

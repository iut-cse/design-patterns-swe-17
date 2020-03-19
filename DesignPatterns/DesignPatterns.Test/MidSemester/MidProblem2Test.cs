using Xunit;
using DesignPatterns.MidSemester.Problem2;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            var converted = new NoConv().Converter(original);// Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new Compression(new Encryption(new NoConvert())).Converter(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted = new Encryption(new Compression(new Encoder(new Compression(new NoConv())))).Converter(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            // TODO: Implement this;
            var original = "Top Score is 305";
            var converted = new Compression(new Encoder(new Encryption(new NoConv()))).Converter(original);
            Assert.Equal("top score is 3", converted);
        }
    }
}

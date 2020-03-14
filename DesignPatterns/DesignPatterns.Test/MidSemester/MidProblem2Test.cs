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
            IConverter d1 = new NoConversion();
            var converted = d1.Convert(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            IConverter d2 = new Encrypt(new Compress(new NoConversion()));
            var converted = d2.Convert(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            IConverter d3 = new Encrypt(new Compress(new Encode(new Compress(new NoConversion()))));
            var converted = d3.Convert(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            IConverter d2 = new Encrypt(new Compress(new Encode(new NoConversion())));
            var converted = d2.Convert(original); // compress then encryppt.
            Assert.Equal("(top score is 3)", converted);
        }
    }
}

using DesignPatterns.MidSemester.Problem2;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new Compresser(new Encrypter(null)).Convert(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted = new Encrypter(new Compresser(new Encoder(new Compresser(null)))).Convert(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }
    }
}

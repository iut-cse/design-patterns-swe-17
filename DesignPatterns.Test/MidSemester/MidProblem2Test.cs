using Xunit;
using DesignPatterns.MidSemester.Problem_2;
using Microsoft.VisualBasic;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            var converted = new NoConversion().Convert(original);  // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new Encrypt(new Compress(new NoConversion())).Convert(original); // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted = new Compress(new Encode(new Compress(new Encrypt(new NoConversion())))).Convert(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            
            var original = "Top Score is 305";
            var converted = new Encrypt(new Encode(new Compress(new NoConversion()))).Convert(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 3", converted);
        }
    }
}

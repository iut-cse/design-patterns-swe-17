using DesignPatterns.MidSemester.Problemset_2;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            var converted = new Plain(original).getString(); 
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new Encrypt(new Compress(new Plain(original))).getString(); 
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            var converted = new Compress(new Encode(new Compress(new Encrypt(new Plain(original))))).getString(); 
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            var converted = new Encrypt(new Encode(new Compress(new Plain(original)))).getString(); 
            Assert.Equal("(top score is 3)", converted);
            
        }
    }
}

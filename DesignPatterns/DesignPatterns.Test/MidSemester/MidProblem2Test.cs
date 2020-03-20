using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var data = "Top Score is 305";
            value = new rawData(data);
            Assert.Equal(data, value);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var data = "Top Score is 305";
            value = new Encryption(new Compression(data));
            Assert.Equal("Top Score is 305", value);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var data = "Top Score is 305";
            value = new Compress(new Encoding(new Compression(new Encryption(data))));
            Assert.Equal("Top Score is 305", value);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var data = "Top Score is 305";
            value = new Encryption(new Encoding(new Compression(data)));
            Assert.Equal("Top Score is 305", value);
        }
    }
}

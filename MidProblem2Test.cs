using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var data = "Hello World";
            value = new rawData(data);
            Assert.Equal(data, value);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var data = "Hello World";
            value = new Encryption(new Compression());
            Assert.Equal("hw", value);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var data = "Hello World";
            value = new Compress(new Encoding(new Compression(new Encryption())));
            Assert.Equal("hw", value);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var data = "Hello World";
            value = new Encryption(new Encoding(new Compression()));
            Assert.Equal("hw", value);
        }
    }
}

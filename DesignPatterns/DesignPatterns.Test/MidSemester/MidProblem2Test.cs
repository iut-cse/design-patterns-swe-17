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
            DataSource data = new PlainTextFile();
            var converted = data.Convert(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            DataSource data = new EncryptionDecorator(new CompressionDecorator(new PlainTextFile()));
            var converted = data.Convert(original); // Do the "No Change" conversion.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            DataSource data = new CompressionDecorator(new EncodingDecorator(new CompressionDecorator(new EncryptionDecorator(new PlainTextFile()))));
            var converted = data.Convert(original); // do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            DataSource data = new EncryptionDecorator(new EncodingDecorator(new CompressionDecorator(new PlainTextFile())));
            var converted = data.Convert(original);
            Assert.Equal("(top score is 3)", converted);
        }
    }
}

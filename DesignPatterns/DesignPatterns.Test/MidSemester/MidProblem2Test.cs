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
            DataSource d1 = new PlainTextFile();
            var converted = d1.convertion(original); // Do the "No Change" conversion.
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            DataSource d2 = new EncryptionDecorator(new CompressionDecorator(new PlainTextFile()));
            string converted = d2.convertion(original);    // compress then encryppt.
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            DataSource d3 = new CompressionDecorator(new EncodingDecorator(new CompressionDecorator(new EncryptionDecorator(new PlainTextFile()))));
            var converted = d3.convertion(original);// do the convertion
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            DataSource f1 = new EncryptionDecorator(new EncodingDecorator(new CompressionDecorator(new PlainTextFile())));
            var converted = f1.convertion(original); // do the convertion
            Assert.Equal("(top score is 3)", converted);
        }
    }
}

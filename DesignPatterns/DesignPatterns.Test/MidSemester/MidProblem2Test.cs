using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem2Test
    {
        [Fact]
        void NoChange()
        {
            var original = "Top Score is 305";
            DataSource source = new RawData();
            var converted = source.convertion(original);
            Assert.Equal("Top Score is 305", converted);
        }

        [Fact]
        void CompressThenEncrypt()
        {
            var original = "Top Score is 305";
            DataSource source = new EncryptionDecorator(new CompressionDecorator(new RawData()));
            var converted = source.convertion(original); 
            Assert.Equal("top score is 3", converted);
        }

        [Fact]
        void EncryptThenCompressThenEncodeThenCompress()
        {
            var original = "Top Score is 305";
            DataSource source = new CompressionDecorator(new EncodingDecorator(new CompressionDecorator(new EncryptionDecorator(new RawData()))));
            var converted = source.convertion(original);
            Assert.Equal("(top score is ", converted);
        }

        [Fact]
        void CompressThenEncodeThenEncrypt()
        {
            var original = "Top Score is 305";
            DataSource source = new EncryptionDecorator(new EncodingDecorator(new CompressionDecorator(new RawData())));
            var converted = source.convertion(original);
            Assert.Equal("(top score is 3)", converted);
        }
    }
}
